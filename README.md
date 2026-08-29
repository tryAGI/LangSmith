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

<!-- EXAMPLES:START -->
### Create Dataset
```csharp
using var client = GetAuthorizedClient();

var response = await client.Datasets.CreateDatasetAsync(name: "test3");
try
{
    var response2 = await client.Datasets.DeleteDatasetAsync(datasetId: response.Id);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
```

### Ok
```csharp
using var client = GetAuthorizedClient();
var response = await client.OkAsync();
```

### Trace
```csharp
using var client = GetAuthorizedClient();
using var openAiClient = GetAuthorizedOpenAiClient();

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
// var parentRunId = Guid.NewGuid();
// await client.Run.CreateRunAsync(
//     name: "Chat Pipeline",
//     runType: CreateRunRequestRunType.Chain,
//     id: parentRunId,
//     inputs: new Dictionary<string, object>
//     {
//         ["question"] = question,
//     });
//
// // Create child run
// var childRunId = Guid.NewGuid();
// await client.Run.CreateRunAsync(
//     name: "OpenAI Call",
//     runType: CreateRunRequestRunType.Llm,
//     id: childRunId,
//     parentRunId: parentRunId,
//     inputs: new Dictionary<string, object>
//     {
//         ["messages"] = messages,
//     });

// Generate a completion
var chatCompletion = await openAiClient.Chat.CreateChatCompletionAsync(
    model: CreateChatCompletionRequestModel.Gpt35Turbo,
    messages: messages);

// End runs
// await client.Run.UpdateRunAsync(
//     runId: childRunId,
//     outputs: new Dictionary<string, object>
//     {
//         ["chatCompletion"] = chatCompletion,
//     },
//     endTime: DateTime.UtcNow.ToString("O"));
// await client.Run.UpdateRunAsync(
//     runId: parentRunId,
//     outputs: new Dictionary<string, object>
//     {
//         ["answer"] = chatCompletion.Choices[0].Message.Content ?? string.Empty,
//     },
//     endTime: DateTime.UtcNow.ToString("O"));
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/LangSmith/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LangSmith/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
