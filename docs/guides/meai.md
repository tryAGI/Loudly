# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Loudly SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Loudly's AI music generation, genre listing, and catalog browsing.

## Available Tools

| Tool | Function Name | Description |
|------|--------------|-------------|
| `AsTextToMusicTool()` | `LoudlyTextToMusic` | Generate royalty-free music from a text prompt |
| `AsGenerateMusicTool()` | `LoudlyGenerateMusic` | Generate music with genre, BPM, energy parameters |
| `AsListGenresTool()` | `LoudlyListGenres` | List available genres and instruments |
| `AsListStructuresTool()` | `LoudlyListStructures` | List available song structures |
| `AsSearchCatalogTool()` | `LoudlySearchCatalog` | Search pre-made catalog tracks |
| `AsGetAccountLimitsTool()` | `LoudlyGetAccountLimits` | Check account usage and quotas |

## Usage with IChatClient

```csharp
using Loudly;
using Microsoft.Extensions.AI;

// Create the Loudly client
using var loudlyClient = new LoudlyClient(apiKey);

// Create tools
var tools = new[]
{
    loudlyClient.AsTextToMusicTool(),
    loudlyClient.AsGenerateMusicTool(),
    loudlyClient.AsListGenresTool(),
    loudlyClient.AsSearchCatalogTool(),
};

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var response = await chatClient.GetResponseAsync(
    "Generate a 60-second upbeat house track for a workout video",
    new ChatOptions { Tools = [.. tools] });
```
