
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsMCPServerHealth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.McptoolsMCPErrorCodeJsonConverter))]
        public global::LangSmith.McptoolsMCPErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        public bool? Ok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsMCPServerHealth" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="errorCode"></param>
        /// <param name="isDefault"></param>
        /// <param name="name"></param>
        /// <param name="ok"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsMCPServerHealth(
            string? error,
            global::LangSmith.McptoolsMCPErrorCode? errorCode,
            bool? isDefault,
            string? name,
            bool? ok,
            string? url)
        {
            this.Error = error;
            this.ErrorCode = errorCode;
            this.IsDefault = isDefault;
            this.Name = name;
            this.Ok = ok;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsMCPServerHealth" /> class.
        /// </summary>
        public AgentsMCPServerHealth()
        {
        }

    }
}