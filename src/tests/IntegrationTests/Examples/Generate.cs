/*
order: 10
title: Music Generation
slug: music-generation

Shows how to generate AI music using both parameter-based and text-prompt-based approaches.
*/

namespace Loudly.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateAiSong_ParameterBased()
    {
        //// Generate an AI song by specifying musical parameters like genre, duration, and energy.

        using var client = GetAuthenticatedClient();

        var song = await client.Ai.GenerateAiSongAsync(
            genre: "House",
            duration: 60,
            energy: GenerateAiSongRequestEnergy.High);

        song.Id.Should().NotBeNullOrWhiteSpace();
        song.MusicFilePath.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Example_GenerateAiSong_TextPrompt()
    {
        //// Generate an AI song from a natural language text prompt.

        using var client = GetAuthenticatedClient();

        var song = await client.Ai.GenerateAiSongFromPromptAsync(
            prompt: "A 60-second energetic house track with tropical vibes and a melodic flute line",
            duration: 60);

        song.Id.Should().NotBeNullOrWhiteSpace();
        song.MusicFilePath.Should().NotBeNullOrWhiteSpace();
    }
}
