
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageCostTotals
    {
        /// <summary>
        /// Total compute usage in Standard Units across the entire filtered interval,<br/>
        /// independent of pagination, as a decimal string, separate from LCU.<br/>
        /// Null means complete Standard compute usage is unavailable; "0" means known zero usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_standard_units")]
        public string? ComputeStandardUnits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lcu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lcu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lsu")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lsu { get; set; }

        /// <summary>
        /// Total storage usage in Standard Units across the entire filtered interval,<br/>
        /// independent of pagination, as a decimal string, separate from LSU.<br/>
        /// Null means complete Standard storage usage is unavailable; "0" means known zero usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_standard_units")]
        public string? StorageStandardUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostTotals" /> class.
        /// </summary>
        /// <param name="lcu"></param>
        /// <param name="lsu"></param>
        /// <param name="computeStandardUnits">
        /// Total compute usage in Standard Units across the entire filtered interval,<br/>
        /// independent of pagination, as a decimal string, separate from LCU.<br/>
        /// Null means complete Standard compute usage is unavailable; "0" means known zero usage.
        /// </param>
        /// <param name="storageStandardUnits">
        /// Total storage usage in Standard Units across the entire filtered interval,<br/>
        /// independent of pagination, as a decimal string, separate from LSU.<br/>
        /// Null means complete Standard storage usage is unavailable; "0" means known zero usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageCostTotals(
            string lcu,
            string lsu,
            string? computeStandardUnits,
            string? storageStandardUnits)
        {
            this.ComputeStandardUnits = computeStandardUnits;
            this.Lcu = lcu ?? throw new global::System.ArgumentNullException(nameof(lcu));
            this.Lsu = lsu ?? throw new global::System.ArgumentNullException(nameof(lsu));
            this.StorageStandardUnits = storageStandardUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCostTotals" /> class.
        /// </summary>
        public SandboxesSandboxUsageCostTotals()
        {
        }

    }
}