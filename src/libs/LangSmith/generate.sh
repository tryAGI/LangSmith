#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.smith.langchain.com/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
autosdk generate openapi.yaml \
  --namespace LangSmith \
  --clientClassName LangSmithClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --ignore-openapi-errors \
  --base-url https://api.smith.langchain.com \
  --security-scheme ApiKey:Header:X-API-Key
