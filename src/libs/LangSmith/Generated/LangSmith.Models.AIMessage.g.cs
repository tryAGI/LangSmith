
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>))]
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
        /// Initializes a new instance of the <see cref="AIMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: ai
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="example">
        /// Default Value: false
        /// </param>
        /// <param name="toolCalls"></param>
        /// <param name="invalidToolCalls"></param>
        /// <param name="usageMetadata">
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
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AIMessage(
            global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>> content,
            object? additionalKwargs,
            object? responseMetadata,
            global::LangSmith.AIMessageType? type,
            string? name,
            string? id,
            bool? example,
            global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? invalidToolCalls,
            global::LangSmith.UsageMetadata? usageMetadata)
        {
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Example = example;
            this.ToolCalls = toolCalls;
            this.InvalidToolCalls = invalidToolCalls;
            this.UsageMetadata = usageMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIMessage" /> class.
        /// </summary>
        public AIMessage()
        {
        }
    }
}