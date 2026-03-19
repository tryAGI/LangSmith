# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [LangSmith](https://smith.langchain.com/) LLM observability and evaluation platform (by LangChain), auto-generated from the LangSmith OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build LangSmith.slnx

# Build for release (also produces NuGet package)
dotnet build LangSmith.slnx -c Release

# Run integration tests (requires LANGSMITH_API_KEY and OPENAI_API_KEY env vars)
dotnet test src/tests/LangSmith.IntegrationTests/LangSmith.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/LangSmith && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code in `Generated/` is **auto-generated** — do not manually edit files in `src/libs/LangSmith/Generated/`.

1. `src/libs/LangSmith/openapi.json` — the LangSmith OpenAPI spec snapshot fetched from `https://api.smith.langchain.com/openapi.json`
2. `src/libs/LangSmith/generate.sh` — orchestrates: download spec → run AutoSDK CLI → output to `Generated/`
3. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Hand-Written Extensions

This file is **not** auto-generated and can be edited manually:

- `src/libs/LangSmith/SpecialJsonSerializerContext.cs` — Custom JSON serializer context for combining LangSmith and OpenAI serialization

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/LangSmith/` | Main SDK library (`LangSmithClient`) |
| `src/tests/LangSmith.IntegrationTests/` | Integration tests against real LangSmith API |

### Documentation Generation

Tests in `src/tests/LangSmith.IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/LangSmith.IntegrationTests/Examples`
### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
