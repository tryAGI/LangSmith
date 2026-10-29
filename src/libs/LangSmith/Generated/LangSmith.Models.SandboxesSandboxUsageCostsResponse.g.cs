
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageCostsResponse
    {
        /// <summary>
        /// Daily usage over the full filtered interval, independent of pagination.<br/>
        /// Omitted unless requested, supported, and unrestricted resource access is verified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public global::LangSmith.SandboxesSandboxUsageDailyResponse? Daily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Totals cover the entire filtered interval, independently of the cursor.<br/>
        /// Omitted unless requested and unrestricted resource access is verified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        public global::LangSmith.SandboxesSandboxUsageCostTotals? Totals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostsResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="daily">
        /// Daily usage over the full filtered interval, independent of pagination.<br/>
        /// Omitted unless requested, supported, and unrestricted resource access is verified.
        /// </param>
        /// <param name="nextCursor"></param>
        /// <param name="totals">
        /// Totals cover the entire filtered interval, independently of the cursor.<br/>
        /// Omitted unless requested and unrestricted resource access is verified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageCostsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost> items,
            global::LangSmith.SandboxesSandboxUsageDailyResponse? daily,
            string? nextCursor,
            global::LangSmith.SandboxesSandboxUsageCostTotals? totals)
        {
            this.Daily = daily;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
            this.Totals = totals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostsResponse" /> class.
        /// </summary>
        public SandboxesSandboxUsageCostsResponse()
        {
        }

    }
}