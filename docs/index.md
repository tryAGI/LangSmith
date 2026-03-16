# LangSmith SDK for .NET

[![Nuget package](https://img.shields.io/nuget/vpre/LangSmith)](https://www.nuget.org/packages/LangSmith/)
[![dotnet](https://github.com/tryAGI/LangSmith/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/LangSmith/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/LangSmith)](https://github.com/tryAGI/LangSmith/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAPI specification](https://api.smith.langchain.com/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Automatic releases of new preview versions if there was an update to the OpenAPI specification
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

## Usage

### Initializing

```csharp
using var client = new LangSmithClient();
using var openAiClient = new OpenAiClient();

client.JsonSerializerContext = new SpecialJsonSerializerContext(tryAGI.OpenAI.SourceGenerationContext.Default);

// This can be a user input to your app
var question = "Can you summarize this morning's meetings?";

// This can be retrieved in a retrieval step
const string context = "During this morning's meeting, we solved all world conflict.";
var messages = new[]
{
    "You are a helpful assistant. Please respond to the user's request only based on the given context."
        .AsSystemMessage(),
    $"Question: {question}\\nContext: {context}",
};

// Create parent run
var parentRunId = Guid.NewGuid();
await client.Run.CreateRunAsync(
    name: "Chat Pipeline",
    runType: CreateRunRequestRunType.Chain,
    id: parentRunId,
    inputs: new Dictionary<string, object>
    {
        ["question"] = question,
    });

// Create child run
var childRunId = Guid.NewGuid();
await client.Run.CreateRunAsync(
    name: "OpenAI Call",
    runType: CreateRunRequestRunType.Llm,
    id: childRunId,
    parentRunId: parentRunId,
    inputs: new Dictionary<string, object>
    {
        ["messages"] = messages,
    });

// Generate a completion
var chatCompletion = await openAiClient.Chat.CreateChatCompletionAsync(
    model: CreateChatCompletionRequestModel.Gpt35Turbo,
    messages: messages);

// End runs
await client.Run.UpdateRunAsync(
    runId: childRunId,
    outputs: new Dictionary<string, object>
    {
        ["chatCompletion"] = chatCompletion,
    },
    endTime: DateTime.UtcNow.ToString("O"));
await client.Run.UpdateRunAsync(
    runId: parentRunId,
    outputs: new Dictionary<string, object>
    {
        ["answer"] = chatCompletion.Choices[0].Message.Content ?? string.Empty,
    },
    endTime: DateTime.UtcNow.ToString("O"));
```

## Support

Priority place for bugs: https://github.com/tryAGI/LangSmith/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LangSmith/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).