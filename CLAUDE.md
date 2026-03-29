# CLAUDE.md -- Loudly SDK

## Overview

Auto-generated C# SDK for [Loudly](https://www.loudly.com/) -- AI music generation platform with royalty-free tracks, genre selection, text-to-music, catalog browsing, and mood customization.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Loudly API documentation.

## Build & Test

```bash
dotnet build Loudly.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `API-KEY` header via `--security-scheme ApiKey:Header:API-KEY`):

```csharp
var client = new LoudlyClient(apiKey); // LOUDLY_API_KEY env var
```

## Key Files

- `openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Loudly)
- `src/libs/Loudly/generate.sh` -- Runs autosdk with `--security-scheme ApiKey:Header:API-KEY` (copies spec from repo root)
- `src/libs/Loudly/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Loudly/Extensions/LoudlyClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Base URL

`https://soundtracks.loudly.com`

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/b2b/account/limits` | GET | Check usage limits and remaining quota |
| `/b2b/songs/tags` | GET | List available catalog filter tags (mood, genre, key) |
| `/b2b/songs` | GET | Browse catalog songs with optional filters |
| `/b2b/ai/genres` | GET | List available AI music genres |
| `/b2b/ai/structures` | GET | List available song structures |
| `/b2b/ai/prompt/random` | GET | Get a random text prompt for inspiration |
| `/b2b/ai/songs` | POST | Generate AI song (parameter-based: genre, BPM, energy, etc.) |
| `/b2b/ai/prompt/songs` | POST | Generate AI song from text prompt |

## MEAI Tools

| Tool | Description |
|------|-------------|
| `AsTextToMusicTool()` | Generate music from a text prompt |
| `AsGenerateMusicTool()` | Generate music with genre, BPM, energy parameters |
| `AsListGenresTool()` | List available genres and instruments |
| `AsListStructuresTool()` | List available song structures |
| `AsSearchCatalogTool()` | Search pre-made catalog tracks |
| `AsGetAccountLimitsTool()` | Check account usage and quotas |
