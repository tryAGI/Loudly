#nullable enable

using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Loudly;

/// <summary>
/// Extensions for using LoudlyClient as MEAI tools with any IChatClient.
/// </summary>
public static class LoudlyToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an AI song from a text prompt
    /// using Loudly's text-to-music API.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTextToMusicTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, int? duration, CancellationToken cancellationToken) =>
            {
                var response = await client.Ai.GenerateAiSongFromPromptAsync(
                    prompt: prompt,
                    duration: duration,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAiSong(response);
            },
            name: "LoudlyTextToMusic",
            description: "Generates a royalty-free AI music track from a text prompt describing the desired song. Optionally specify duration in seconds (30-420).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an AI song using musical parameters
    /// such as genre, BPM, energy, instruments, and key.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateMusicTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string genre,
                string? genreBlend,
                int? duration,
                string? energy,
                int? bpm,
                CancellationToken cancellationToken) =>
            {
                GenerateAiSongRequestEnergy? energyEnum = energy switch
                {
                    _ when string.Equals(energy, "low", StringComparison.OrdinalIgnoreCase) => GenerateAiSongRequestEnergy.Low,
                    _ when string.Equals(energy, "high", StringComparison.OrdinalIgnoreCase) => GenerateAiSongRequestEnergy.High,
                    _ when string.Equals(energy, "original", StringComparison.OrdinalIgnoreCase) => GenerateAiSongRequestEnergy.Original,
                    _ => null,
                };

                var response = await client.Ai.GenerateAiSongAsync(
                    genre: genre,
                    genreBlend: genreBlend,
                    duration: duration,
                    energy: energyEnum,
                    bpm: bpm,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatAiSong(response);
            },
            name: "LoudlyGenerateMusic",
            description: "Generates a royalty-free AI music track using musical parameters. Requires a genre (e.g. 'House', 'Hip Hop', 'Rock'). Optional: genreBlend, duration (30-420 seconds), energy ('low', 'high', 'original'), bpm.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available AI music genres
    /// along with their descriptions, instruments, and template suggestions.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListGenresTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var genres = await client.Ai.GetAiGenresAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { "Available genres:" };
                foreach (var genre in genres)
                {
                    var entry = $"- {genre.Name}";
                    if (!string.IsNullOrWhiteSpace(genre.Description))
                    {
                        entry += $": {genre.Description}";
                    }
                    if (genre.Instruments is { Count: > 0 })
                    {
                        entry += $" (instruments: {string.Join(", ", genre.Instruments)})";
                    }
                    parts.Add(entry);
                }

                return string.Join("\n", parts);
            },
            name: "LoudlyListGenres",
            description: "Lists all available AI music genres with their descriptions and suggested instruments.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available song structures
    /// for parameter-based AI music generation.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListStructuresTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var structures = await client.Ai.GetAiStructuresAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { "Available song structures:" };
                foreach (var structure in structures)
                {
                    var entry = $"- {structure.Name} (id: {structure.Id})";
                    if (!string.IsNullOrWhiteSpace(structure.Description))
                    {
                        entry += $": {structure.Description}";
                    }
                    parts.Add(entry);
                }

                return string.Join("\n", parts);
            },
            name: "LoudlyListStructures",
            description: "Lists all available song structures (e.g. Intro-Verse-Chorus) for AI music generation.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that searches the Loudly music catalog
    /// with optional filters for mood, genre, and musical key.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchCatalogTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? mood, string? genre, string? key, int? page, CancellationToken cancellationToken) =>
            {
                var songs = await client.Catalog.GetCatalogSongsAsync(
                    mood: mood,
                    genre: genre,
                    key: key,
                    page: page,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { $"Catalog songs ({songs.Count} results):" };
                foreach (var song in songs)
                {
                    var entry = $"- {song.Title}";
                    if (!string.IsNullOrWhiteSpace(song.Artist))
                    {
                        entry += $" by {song.Artist}";
                    }
                    if (song.Duration.HasValue)
                    {
                        entry += $" ({song.Duration:F0}s)";
                    }
                    if (song.Bpm.HasValue)
                    {
                        entry += $" {song.Bpm} BPM";
                    }
                    if (!string.IsNullOrWhiteSpace(song.MusicFilePath))
                    {
                        entry += $" - {song.MusicFilePath}";
                    }
                    parts.Add(entry);
                }

                return string.Join("\n", parts);
            },
            name: "LoudlySearchCatalog",
            description: "Searches the Loudly music catalog for pre-made royalty-free tracks. Optional filters: mood, genre, musical key, page number.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the account usage limits
    /// and remaining quota.
    /// </summary>
    /// <param name="client">The Loudly client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetAccountLimitsTool(this LoudlyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var limits = await client.Account.GetAccountLimitsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var parts = new List<string> { "Account usage limits:" };
                foreach (var limit in limits)
                {
                    parts.Add($"- {limit.RequestType}: {limit.Used}/{limit.Limit} used, {limit.Left} remaining");
                }

                return string.Join("\n", parts);
            },
            name: "LoudlyGetAccountLimits",
            description: "Retrieves the Loudly account usage limits showing how much quota has been used and how much remains.");
    }

    private static string FormatAiSong(AiSong song)
    {
        var parts = new List<string>
        {
            $"Generated song: {song.Title ?? "Untitled"}",
            $"ID: {song.Id}",
        };

        if (song.Duration.HasValue)
        {
            parts.Add($"Duration: {song.Duration:F0}s");
        }
        if (song.Bpm.HasValue)
        {
            parts.Add($"BPM: {song.Bpm}");
        }
        if (song.Key != null)
        {
            parts.Add($"Key: {song.Key.Name}");
        }
        if (!string.IsNullOrWhiteSpace(song.MusicFilePath))
        {
            parts.Add($"Music file: {song.MusicFilePath}");
        }

        return string.Join("\n", parts);
    }
}
