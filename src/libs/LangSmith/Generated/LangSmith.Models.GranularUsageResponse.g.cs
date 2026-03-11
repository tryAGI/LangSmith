
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response for granular usage query.
    /// </summary>
    public sealed partial class GranularUsageResponse
    {
        /// <summary>
        /// Stride configuration for time bucketing - only ONE field should be non-zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.GranularUsageStride Stride { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord> Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageResponse" /> class.
        /// </summary>
        /// <param name="stride">
        /// Stride configuration for time bucketing - only ONE field should be non-zero.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GranularUsageResponse(
            global::LangSmith.GranularUsageStride stride,
            global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord> usage)
        {
            this.Stride = stride ?? throw new global::System.ArgumentNullException(nameof(stride));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GranularUsageResponse" /> class.
        /// </summary>
        public GranularUsageResponse()
        {
        }
    }
}