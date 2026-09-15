
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageCost
    {
        /// <summary>
        /// Recorded compute usage in LangSmith Compute Units (LCU), as a decimal string<br/>
        /// with up to six fractional digits and trailing zeros omitted. Snapshots return "0".<br/>
        /// Example: 1.234567
        /// </summary>
        /// <example>1.234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lcu { get; set; }

        /// <summary>
        /// Allocated storage usage in LangSmith Storage Units (LSU), as a decimal string<br/>
        /// with up to six fractional digits and trailing zeros omitted.<br/>
        /// Example: 0.000123
        /// </summary>
        /// <example>0.000123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lsu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodStart { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesUsageCostResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SandboxesUsageCostResourceType ResourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCost" /> class.
        /// </summary>
        /// <param name="lcu">
        /// Recorded compute usage in LangSmith Compute Units (LCU), as a decimal string<br/>
        /// with up to six fractional digits and trailing zeros omitted. Snapshots return "0".<br/>
        /// Example: 1.234567
        /// </param>
        /// <param name="lsu">
        /// Allocated storage usage in LangSmith Storage Units (LSU), as a decimal string<br/>
        /// with up to six fractional digits and trailing zeros omitted.<br/>
        /// Example: 0.000123
        /// </param>
        /// <param name="periodStart"></param>
        /// <param name="resourceId"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageCost(
            string lcu,
            string lsu,
            global::System.DateTime periodStart,
            global::System.Guid resourceId,
            global::LangSmith.SandboxesUsageCostResourceType resourceType)
        {
            this.Lcu = lcu ?? throw new global::System.ArgumentNullException(nameof(lcu));
            this.Lsu = lsu ?? throw new global::System.ArgumentNullException(nameof(lsu));
            this.PeriodStart = periodStart;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCost" /> class.
        /// </summary>
        public SandboxesSandboxUsageCost()
        {
        }

    }
}