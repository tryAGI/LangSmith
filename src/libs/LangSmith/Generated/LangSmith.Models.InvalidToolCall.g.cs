
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Allowance for errors made by LLM.<br/>
    /// Here we add an `error` key to surface errors made during generation<br/>
    /// (e.g., invalid JSON arguments.)
    /// </summary>
    public sealed partial class InvalidToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"invalid_tool_call"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_tool_call";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public string? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::LangSmith.AnyOf<int?, string>? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidToolCall" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="args"></param>
        /// <param name="error"></param>
        /// <param name="index"></param>
        /// <param name="extras"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvalidToolCall(
            string? id,
            string? name,
            string? args,
            string? error,
            global::LangSmith.AnyOf<int?, string>? index,
            object? extras,
            string type = "invalid_tool_call")
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
            this.Args = args;
            this.Error = error;
            this.Index = index;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidToolCall" /> class.
        /// </summary>
        public InvalidToolCall()
        {
        }
    }
}