#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.MessagesItem2>
    {
        /// <inheritdoc />
        public override global::LangSmith.MessagesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.AIMessageOutput? ai = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.Ai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AIMessageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AIMessageOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.AIMessageOutput)}");
                ai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.HumanMessage? human = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.Human)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.HumanMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.HumanMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.HumanMessage)}");
                human = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.ChatMessage? chat = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.Chat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ChatMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ChatMessage)}");
                chat = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.SystemMessage? system = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.SystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.FunctionMessage? function = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.FunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.FunctionMessage)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.ToolMessage? tool = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.AIMessageChunkOutput? aIMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.AIMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AIMessageChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AIMessageChunkOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.AIMessageChunkOutput)}");
                aIMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.HumanMessageChunk? humanMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.HumanMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.HumanMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.HumanMessageChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.HumanMessageChunk)}");
                humanMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.ChatMessageChunk? chatMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.ChatMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ChatMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ChatMessageChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ChatMessageChunk)}");
                chatMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.SystemMessageChunk? systemMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.SystemMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SystemMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SystemMessageChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.SystemMessageChunk)}");
                systemMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.FunctionMessageChunk? functionMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.FunctionMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.FunctionMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.FunctionMessageChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.FunctionMessageChunk)}");
                functionMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.ToolMessageChunk? toolMessageChunk = default;
            if (discriminator?.Type == global::LangSmith.PlaygroundPromptCanvasResponseMessageDiscriminatorType.ToolMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ToolMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ToolMessageChunk> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ToolMessageChunk)}");
                toolMessageChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::LangSmith.MessagesItem2(
                discriminator?.Type,
                ai,
                human,
                chat,
                system,
                function,
                tool,
                aIMessageChunk,
                humanMessageChunk,
                chatMessageChunk,
                systemMessageChunk,
                functionMessageChunk,
                toolMessageChunk
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.MessagesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AIMessageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AIMessageOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.AIMessageOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ai, typeInfo);
            }
            else if (value.IsHuman)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.HumanMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.HumanMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.HumanMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Human, typeInfo);
            }
            else if (value.IsChat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ChatMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ChatMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.ChatMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chat, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.FunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.FunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.FunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsAIMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AIMessageChunkOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AIMessageChunkOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.AIMessageChunkOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AIMessageChunk, typeInfo);
            }
            else if (value.IsHumanMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.HumanMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.HumanMessageChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.HumanMessageChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HumanMessageChunk, typeInfo);
            }
            else if (value.IsChatMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ChatMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ChatMessageChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.ChatMessageChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatMessageChunk, typeInfo);
            }
            else if (value.IsSystemMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SystemMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SystemMessageChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SystemMessageChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessageChunk, typeInfo);
            }
            else if (value.IsFunctionMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.FunctionMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.FunctionMessageChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.FunctionMessageChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionMessageChunk, typeInfo);
            }
            else if (value.IsToolMessageChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ToolMessageChunk), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ToolMessageChunk?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.ToolMessageChunk).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolMessageChunk, typeInfo);
            }
        }
    }
}