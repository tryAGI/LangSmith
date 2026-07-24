
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAgentUsageLCUSpendItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcu_total")]
        public string? LcuTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcu_unpriced_row_count")]
        public int? LcuUnpricedRowCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_name")]
        public string? TenantName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAgentUsageLCUSpendItem" /> class.
        /// </summary>
        /// <param name="lcuTotal"></param>
        /// <param name="lcuUnpricedRowCount"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="tenantId"></param>
        /// <param name="tenantName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAgentUsageLCUSpendItem(
            string? lcuTotal,
            int? lcuUnpricedRowCount,
            string? sessionId,
            string? sessionName,
            string? tenantId,
            string? tenantName)
        {
            this.LcuTotal = lcuTotal;
            this.LcuUnpricedRowCount = lcuUnpricedRowCount;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAgentUsageLCUSpendItem" /> class.
        /// </summary>
        public IssuesAgentUsageLCUSpendItem()
        {
        }

    }
}