/*
order: 20
title: Catalog
slug: catalog

Shows how to browse the Loudly music catalog and filter by mood, genre, and key.
*/

namespace Loudly.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetCatalogTags()
    {
        //// Retrieve the available tags (moods, genres, keys) for filtering catalog songs.

        using var client = GetAuthenticatedClient();

        var tags = await client.Catalog.GetCatalogTagsAsync();

        tags.Mood.Should().NotBeNull();
        tags.Genre.Should().NotBeNull();
        tags.Key.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Example_GetCatalogSongs()
    {
        //// Browse the pre-made music catalog with optional filters.

        using var client = GetAuthenticatedClient();

        var songs = await client.Catalog.GetCatalogSongsAsync(
            genre: "rock",
            page: 1);

        songs.Should().NotBeNull();
    }
}
