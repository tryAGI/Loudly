/*
order: 30
title: AI Configuration
slug: ai-configuration

Shows how to list available genres, structures, and get random prompts for AI music generation.
*/

namespace Loudly.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetAiGenres()
    {
        //// List all available AI music genres with their descriptions and instruments.

        using var client = GetAuthenticatedClient();

        var genres = await client.Ai.GetAiGenresAsync();

        genres.Should().NotBeNull();
        genres.Count.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public async Task Example_GetAiStructures()
    {
        //// List available song structures for parameter-based AI music generation.

        using var client = GetAuthenticatedClient();

        var structures = await client.Ai.GetAiStructuresAsync();

        structures.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_GetRandomPrompt()
    {
        //// Get a random text prompt to inspire text-to-music generation.

        using var client = GetAuthenticatedClient();

        var result = await client.Ai.GetRandomPromptAsync();

        result.Prompt.Should().NotBeNullOrWhiteSpace();
    }
}
