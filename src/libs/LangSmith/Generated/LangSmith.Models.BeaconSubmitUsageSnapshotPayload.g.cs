
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BeaconSubmitUsageSnapshotPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_timestamp")]
        public string? FromTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_key")]
        public string? LicenseKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measures")]
        public global::System.Collections.Generic.Dictionary<string, int>? Measures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_timestamp")]
        public string? ToTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconSubmitUsageSnapshotPayload" /> class.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="licenseKey"></param>
        /// <param name="measures"></param>
        /// <param name="toTimestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BeaconSubmitUsageSnapshotPayload(
            string? fromTimestamp,
            string? licenseKey,
            global::System.Collections.Generic.Dictionary<string, int>? measures,
            string? toTimestamp)
        {
            this.FromTimestamp = fromTimestamp;
            this.LicenseKey = licenseKey;
            this.Measures = measures;
            this.ToTimestamp = toTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BeaconSubmitUsageSnapshotPayload" /> class.
        /// </summary>
        public BeaconSubmitUsageSnapshotPayload()
        {
        }
    }
}