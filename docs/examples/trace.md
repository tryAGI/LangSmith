# Trace



This example assumes `using LangSmith;` is in scope and `apiKey` contains your LangSmith API key.

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