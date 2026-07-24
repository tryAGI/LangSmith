
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAgentUsageLCUSpendResponse
    {
        /// <summary>
        /// DefaultMonthlySpendLimitLCU is the org-admin default applied when the admin limit<br/>
        /// is unset (NULL) — what the UI shows as "using the default". Lets the UI label the<br/>
        /// default without hardcoding it. Serialized as a string for NUMERIC precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_monthly_spend_limit_lcu")]
        public string? DefaultMonthlySpendLimitLcu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesAgentUsageLCUSpendItem>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_end")]
        public string? PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        public string? PeriodStart { get; set; }

        /// <summary>
        /// ResolvedMonthlySpendLimitLCU is the effective monthly LCU spend limit enforced for<br/>
        /// this org — the minimum of the finance, plan, and admin layers — or null when<br/>
        /// unlimited. Surfaced so the UI can render spend against the true enforced limit<br/>
        /// rather than the admin layer alone. Serialized as a string for NUMERIC precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_monthly_spend_limit_lcu")]
        public string? ResolvedMonthlySpendLimitLcu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_lcu")]
        public string? TotalLcu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_unpriced_row_count")]
        public int? TotalUnpricedRowCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAgentUsageLCUSpendResponse" /> class.
        /// </summary>
        /// <param name="defaultMonthlySpendLimitLcu">
        /// DefaultMonthlySpendLimitLCU is the org-admin default applied when the admin limit<br/>
        /// is unset (NULL) — what the UI shows as "using the default". Lets the UI label the<br/>
        /// default without hardcoding it. Serialized as a string for NUMERIC precision.
        /// </param>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
        /// <param name="organizationId"></param>
        /// <param name="periodEnd"></param>
        /// <param name="periodStart"></param>
        /// <param name="resolvedMonthlySpendLimitLcu">
        /// ResolvedMonthlySpendLimitLCU is the effective monthly LCU spend limit enforced for<br/>
        /// this org — the minimum of the finance, plan, and admin layers — or null when<br/>
        /// unlimited. Surfaced so the UI can render spend against the true enforced limit<br/>
        /// rather than the admin layer alone. Serialized as a string for NUMERIC precision.
        /// </param>
        /// <param name="totalLcu"></param>
        /// <param name="totalUnpricedRowCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAgentUsageLCUSpendResponse(
            string? defaultMonthlySpendLimitLcu,
            global::System.Collections.Generic.IList<global::LangSmith.IssuesAgentUsageLCUSpendItem>? items,
            string? nextCursor,
            string? organizationId,
            string? periodEnd,
            string? periodStart,
            string? resolvedMonthlySpendLimitLcu,
            string? totalLcu,
            int? totalUnpricedRowCount)
        {
            this.DefaultMonthlySpendLimitLcu = defaultMonthlySpendLimitLcu;
            this.Items = items;
            this.NextCursor = nextCursor;
            this.OrganizationId = organizationId;
            this.PeriodEnd = periodEnd;
            this.PeriodStart = periodStart;
            this.ResolvedMonthlySpendLimitLcu = resolvedMonthlySpendLimitLcu;
            this.TotalLcu = totalLcu;
            this.TotalUnpricedRowCount = totalUnpricedRowCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAgentUsageLCUSpendResponse" /> class.
        /// </summary>
        public IssuesAgentUsageLCUSpendResponse()
        {
        }

    }
}