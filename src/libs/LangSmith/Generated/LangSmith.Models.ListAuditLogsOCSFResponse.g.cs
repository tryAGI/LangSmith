
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response model for listing audit logs in OCSF format with pagination.
    /// </summary>
    public sealed partial class ListAuditLogsOCSFResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsOCSFResponse" /> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAuditLogsOCSFResponse(
            global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity> items,
            string? cursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsOCSFResponse" /> class.
        /// </summary>
        public ListAuditLogsOCSFResponse()
        {
        }
    }
}