
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF API details object.
    /// </summary>
    public sealed partial class OCSFApi
    {
        /// <summary>
        /// Operations that can be logged in audit_logs database table.<br/>
        /// NOTE: not all of @audit_log_operation(&lt;log name&gt;) names are currently used here.<br/>
        /// NOTE: OCSF mapping: endpoints with POST method and operation prefixed with "update_"<br/>
        /// map to OCSF UPDATE activity type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuditLogOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.AuditLogOperation Operation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFApi" /> class.
        /// </summary>
        /// <param name="operation">
        /// Operations that can be logged in audit_logs database table.<br/>
        /// NOTE: not all of @audit_log_operation(&lt;log name&gt;) names are currently used here.<br/>
        /// NOTE: OCSF mapping: endpoints with POST method and operation prefixed with "update_"<br/>
        /// map to OCSF UPDATE activity type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFApi(
            global::LangSmith.AuditLogOperation operation)
        {
            this.Operation = operation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFApi" /> class.
        /// </summary>
        public OCSFApi()
        {
        }
    }
}