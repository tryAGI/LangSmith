#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -fsSL -o openapi.json https://api.smith.langchain.com/openapi.json
autosdk generate openapi.json \
  --namespace LangSmith \
  --clientClassName LangSmithClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --ignore-openapi-errors \
  --base-url https://api.smith.langchain.com \
  --security-scheme ApiKey:Header:X-API-Key
