using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using OpenAI;

namespace LangSmith.IntegrationTests;

public partial class Tests
{
    // https://docs.smith.langchain.com/how_to_guides/tracing/trace_with_api
    [TestMethod]
    public async Task Trace()
    {
        using var api = GetAuthorizedApi();
        using var openAiApi = GetAuthorizedOpenAiApi();
        
        api.JsonSerializerContext = new SpecialJsonSerializerContext(OpenAI.SourceGenerationContext.Default);
        
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
        await api.Run.CreateRunAsync(
            name: "Chat Pipeline",
            runType: CreateRunRequestRunType.Chain,
            id: parentRunId,
            inputs: new CreateRunRequestInputs
            {
                AdditionalProperties = new Dictionary<string, object>
                {
                    ["question"] = question,
                },
            });
        
        // Create child run
        var childRunId = Guid.NewGuid();
        await api.Run.CreateRunAsync(
            name: "OpenAI Call",
            runType: CreateRunRequestRunType.Llm,
            id: childRunId,
            parentRunId: parentRunId,
            inputs: new CreateRunRequestInputs
            {
                AdditionalProperties = new Dictionary<string, object>
                {
                    ["messages"] = messages,
                },
            });

        // Generate a completion
        var chatCompletion = await openAiApi.Chat.CreateChatCompletionAsync(
            model: CreateChatCompletionRequestModel.Gpt35Turbo,
            messages: messages);

        // End runs
        await api.Run.UpdateRunAsync(
            runId: childRunId,
            outputs: new UpdateRunRequestOutputs
            {
                AdditionalProperties = new Dictionary<string, object>
                {
                    ["chatCompletion"] = chatCompletion,
                },
            },
            endTime: DateTime.UtcNow.ToString("O"));
        await api.Run.UpdateRunAsync(
            runId: parentRunId,
            outputs: new UpdateRunRequestOutputs
            {
                AdditionalProperties = new Dictionary<string, object>
                {
                    ["answer"] = chatCompletion.Choices[0].Message.Content ?? string.Empty,
                },
            },
            endTime: DateTime.UtcNow.ToString("O"));
    }
}