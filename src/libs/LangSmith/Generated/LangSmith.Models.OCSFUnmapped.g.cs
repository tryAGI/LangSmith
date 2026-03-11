
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF unmapped attribute for source-specific data.<br/>
    /// Reference: https://schema.ocsf.io/1.7.0/classes/base_event
    /// </summary>
    public sealed partial class OCSFUnmapped
    {
        /// <summary>
        /// Represents an audit log message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_audit_log")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.AuditLogMessage OriginalAuditLog { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFUnmapped" /> class.
        /// </summary>
        /// <param name="originalAuditLog">
        /// Represents an audit log message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFUnmapped(
            global::LangSmith.AuditLogMessage originalAuditLog)
        {
            this.OriginalAuditLog = originalAuditLog ?? throw new global::System.ArgumentNullException(nameof(originalAuditLog));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFUnmapped" /> class.
        /// </summary>
        public OCSFUnmapped()
        {
        }
    }
}