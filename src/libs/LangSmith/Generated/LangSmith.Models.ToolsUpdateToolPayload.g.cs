
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsUpdateToolPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returns")]
        public object? Returns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUpdateToolPayload" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <param name="returns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsUpdateToolPayload(
            string? description,
            bool? enabled,
            object? metadata,
            string? name,
            object? parameters,
            object? returns)
        {
            this.Description = description;
            this.Enabled = enabled;
            this.Metadata = metadata;
            this.Name = name;
            this.Parameters = parameters;
            this.Returns = returns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsUpdateToolPayload" /> class.
        /// </summary>
        public ToolsUpdateToolPayload()
        {
        }
    }
}