
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Server and tool a Managed Tools gateway routed a call to.
    /// </summary>
    public sealed partial class AuditLogUpstream
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        public string? ServerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtin_server_key")]
        public string? BuiltinServerKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUpstream" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="serverId"></param>
        /// <param name="builtinServerKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogUpstream(
            string toolName,
            string? serverId,
            string? builtinServerKey)
        {
            this.ServerId = serverId;
            this.BuiltinServerKey = builtinServerKey;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUpstream" /> class.
        /// </summary>
        public AuditLogUpstream()
        {
        }

    }
}