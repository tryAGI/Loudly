/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use Loudly as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Loudly.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AsTextToMusicTool()
    {
        //// Use the text-to-music tool to generate music from a prompt.
        //// This tool can be passed to any IChatClient via ChatOptions.Tools.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsTextToMusicTool();

        tool.Name.Should().Be("LoudlyTextToMusic");
        tool.Description.Should().Contain("text prompt");
    }

    [TestMethod]
    public async Task Example_AsGenerateMusicTool()
    {
        //// Use the parameter-based music generation tool with genre, BPM, and energy options.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsGenerateMusicTool();

        tool.Name.Should().Be("LoudlyGenerateMusic");
        tool.Description.Should().Contain("genre");
    }

    [TestMethod]
    public async Task Example_AsListGenresTool()
    {
        //// Use the list genres tool to discover available genres for music generation.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsListGenresTool();

        tool.Name.Should().Be("LoudlyListGenres");
        tool.Description.Should().Contain("genres");
    }

    [TestMethod]
    public async Task Example_AsSearchCatalogTool()
    {
        //// Use the catalog search tool to find pre-made royalty-free tracks.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsSearchCatalogTool();

        tool.Name.Should().Be("LoudlySearchCatalog");
        tool.Description.Should().Contain("catalog");
    }
}
