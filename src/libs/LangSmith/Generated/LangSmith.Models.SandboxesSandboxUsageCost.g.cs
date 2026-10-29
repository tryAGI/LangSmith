
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageCost
    {
        /// <summary>
        /// Recorded compute usage in Standard Units, as a decimal string, separate from LCU.<br/>
        /// Null means complete Standard compute usage is unavailable; "0" means known zero usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_standard_units")]
        public string? ComputeStandardUnits { get; set; }

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
        /// Memory usage in GiB-hours, as a decimal string. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_gib_hours")]
        public string? MemoryGibHours { get; set; }

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
        /// Storage usage in GiB-hours from hourly attributed-byte samples, including checkpoints. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_gib_hours")]
        public string? StorageGibHours { get; set; }

        /// <summary>
        /// Allocated storage usage in Standard Units, as a decimal string, separate from LSU.<br/>
        /// Null means complete Standard storage usage is unavailable; "0" means known zero usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_standard_units")]
        public string? StorageStandardUnits { get; set; }

        /// <summary>
        /// CPU usage in vCPU-hours, as a decimal string. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpu_hours")]
        public string? VcpuHours { get; set; }

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
        /// <param name="computeStandardUnits">
        /// Recorded compute usage in Standard Units, as a decimal string, separate from LCU.<br/>
        /// Null means complete Standard compute usage is unavailable; "0" means known zero usage.
        /// </param>
        /// <param name="memoryGibHours">
        /// Memory usage in GiB-hours, as a decimal string. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </param>
        /// <param name="storageGibHours">
        /// Storage usage in GiB-hours from hourly attributed-byte samples, including checkpoints. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </param>
        /// <param name="storageStandardUnits">
        /// Allocated storage usage in Standard Units, as a decimal string, separate from LSU.<br/>
        /// Null means complete Standard storage usage is unavailable; "0" means known zero usage.
        /// </param>
        /// <param name="vcpuHours">
        /// CPU usage in vCPU-hours, as a decimal string. Available with RESOURCE granularity; null means complete usage is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageCost(
            string lcu,
            string lsu,
            global::System.DateTime periodStart,
            global::System.Guid resourceId,
            global::LangSmith.SandboxesUsageCostResourceType resourceType,
            string? computeStandardUnits,
            string? memoryGibHours,
            string? storageGibHours,
            string? storageStandardUnits,
            string? vcpuHours)
        {
            this.ComputeStandardUnits = computeStandardUnits;
            this.Lcu = lcu ?? throw new global::System.ArgumentNullException(nameof(lcu));
            this.Lsu = lsu ?? throw new global::System.ArgumentNullException(nameof(lsu));
            this.MemoryGibHours = memoryGibHours;
            this.PeriodStart = periodStart;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
            this.StorageGibHours = storageGibHours;
            this.StorageStandardUnits = storageStandardUnits;
            this.VcpuHours = vcpuHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageCost" /> class.
        /// </summary>
        public SandboxesSandboxUsageCost()
        {
        }

    }
}