
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF API details object.
    /// </summary>
    public sealed partial class OCSFApi
    {
        /// <summary>
        /// Operations that are logged in audit_logs database table.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuditLogOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AuditLogOperation Operation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFApi" /> class.
        /// </summary>
        /// <param name="operation">
        /// Operations that are logged in audit_logs database table.
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