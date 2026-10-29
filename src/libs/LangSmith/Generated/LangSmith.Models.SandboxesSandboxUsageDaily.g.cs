
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxUsageDaily
    {
        /// <summary>
        /// Other combines resources outside the top groups. Their individual IDs are omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_other")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOther { get; set; }

        /// <summary>
        /// Memory usage in GiB-hours, as a decimal string. Null means complete usage is unavailable.
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
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesUsageCostResourceTypeJsonConverter))]
        public global::LangSmith.SandboxesUsageCostResourceType? ResourceType { get; set; }

        /// <summary>
        /// Recorded storage usage in GiB-hours from hourly samples. Missing intervals are excluded; null means no usable measurements are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_gib_hours")]
        public string? StorageGibHours { get; set; }

        /// <summary>
        /// CPU usage in vCPU-hours, as a decimal string. Null means complete usage is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpu_hours")]
        public string? VcpuHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageDaily" /> class.
        /// </summary>
        /// <param name="isOther">
        /// Other combines resources outside the top groups. Their individual IDs are omitted.
        /// </param>
        /// <param name="periodStart"></param>
        /// <param name="memoryGibHours">
        /// Memory usage in GiB-hours, as a decimal string. Null means complete usage is unavailable.
        /// </param>
        /// <param name="resourceId"></param>
        /// <param name="resourceType"></param>
        /// <param name="storageGibHours">
        /// Recorded storage usage in GiB-hours from hourly samples. Missing intervals are excluded; null means no usable measurements are available.
        /// </param>
        /// <param name="vcpuHours">
        /// CPU usage in vCPU-hours, as a decimal string. Null means complete usage is unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxUsageDaily(
            bool isOther,
            global::System.DateTime periodStart,
            string? memoryGibHours,
            global::System.Guid? resourceId,
            global::LangSmith.SandboxesUsageCostResourceType? resourceType,
            string? storageGibHours,
            string? vcpuHours)
        {
            this.IsOther = isOther;
            this.MemoryGibHours = memoryGibHours;
            this.PeriodStart = periodStart;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
            this.StorageGibHours = storageGibHours;
            this.VcpuHours = vcpuHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxUsageDaily" /> class.
        /// </summary>
        public SandboxesSandboxUsageDaily()
        {
        }

    }
}