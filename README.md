# LangSmith SDK for .NET

[![Nuget package](https://img.shields.io/nuget/vpre/LangSmith)](https://www.nuget.org/packages/LangSmith/)
[![dotnet](https://github.com/tryAGI/LangSmith/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/LangSmith/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/LangSmith)](https://github.com/tryAGI/LangSmith/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official OpenAPI specification](https://api.smith.langchain.com/openapi.json) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Automatic releases of new preview versions if there was an update to the OpenAPI specification
- Source generator to define tools natively through C# interfaces
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

## Usage

### Initializing

```csharp
using var ollama = new OllamaApiClient();

var models = await ollama.Models.ListModelsAsync();

// Pulling a model and reporting progress
await foreach (var response in ollama.PullModelAsync("all-minilm", stream: true))
{
    Console.WriteLine($"{response.Status}. Progress: {response.Completed}/{response.Total}");
}
// or just pull the model and wait for it to finish
await ollama.Models.PullModelAndEnsureSuccessAsync("all-minilm");

// Generating an embedding
var embedding = await ollama.Embeddings.GenerateEmbeddingAsync(
    model: "all-minilm",
    prompt: "hello");

// Streaming a completion directly into the console
// keep reusing the context to keep the chat topic going
IList<long>? context = null;
var enumerable = ollama.Completions.GenerateCompletionAsync("llama3", "answer 5 random words", stream: true);
await foreach (var response in enumerable)
{
    Console.WriteLine($"> {response.Response}");
    
    context = response.Context;
}

var lastResponse = await ollama.Completions.GenerateCompletionAsync("llama3", "answer 123", stream: false, context: context).WaitAsync();
Console.WriteLine(lastResponse.Response);

var chat = ollama.Chat("mistral");
while (true)
{
    var message = await chat.SendAsync("answer 123");
    
    Console.WriteLine(message.Content);
    
    var newMessage = Console.ReadLine();
    await chat.Send(newMessage);
}
```

## Support

Priority place for bugs: https://github.com/tryAGI/LangSmith/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/LangSmith/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  