#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.smith.langchain.com/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec -fsSL -o openapi.json https://api.smith.langchain.com/openapi.json
autosdk generate openapi.json \
  --namespace LangSmith \
  --clientClassName LangSmithClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --ignore-openapi-errors \
  --base-url https://api.smith.langchain.com \
  --security-scheme ApiKey:Header:X-API-Key \
  --auth-env-var LANGSMITH_API_KEY
