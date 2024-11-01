
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Message from an AI.<br/>
    /// AIMessage is returned from a chat model as a response to a prompt.<br/>
    /// This message represents the output of the model and consists of both<br/>
    /// the raw output as returned by the model together standardized fields<br/>
    /// (e.g., tool calls, usage metadata) added by the LangChain framework.
    /// </summary>
    public sealed partial class AIMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: ai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AIMessageTypeJsonConverter))]
        public global::LangSmith.AIMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public bool? Example { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_tool_calls")]
        public global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? InvalidToolCalls { get; set; }

        /// <summary>
        /// Usage metadata for a message, such as token counts.<br/>
        /// This is a standard representation of token usage that is consistent across models.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         {<br/>
        ///             "input_tokens": 350,<br/>
        ///             "output_tokens": 240,<br/>
        ///             "total_tokens": 590,<br/>
        ///             "input_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "cache_creation": 200,<br/>
        ///                 "cache_read": 100,<br/>
        ///             },<br/>
        ///             "output_token_details": {<br/>
        ///                 "audio": 10,<br/>
        ///                 "reasoning": 200,<br/>
        ///             }<br/>
        ///         }<br/>
        /// .. versionchanged:: 0.3.9<br/>
        ///     Added ``input_token_details`` and ``output_token_details``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_metadata")]
        public global::LangSmith.UsageMetadata? UsageMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::LangSmith.AIMessage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::LangSmith.AIMessage),
                jsonSerializerContext) as global::LangSmith.AIMessage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::LangSmith.AIMessage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.AIMessage>(
                json,
                jsonSerializerOptions);
        }

    }
}