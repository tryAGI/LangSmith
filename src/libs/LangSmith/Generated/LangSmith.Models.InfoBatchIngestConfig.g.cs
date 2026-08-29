
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InfoBatchIngestConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_nempty_trigger")]
        public int? ScaleDownNemptyTrigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_nthreads_limit")]
        public int? ScaleUpNthreadsLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_up_qsize_trigger")]
        public int? ScaleUpQsizeTrigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit")]
        public int? SizeLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_limit_bytes")]
        public long? SizeLimitBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_multipart_endpoint")]
        public bool? UseMultipartEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoBatchIngestConfig" /> class.
        /// </summary>
        /// <param name="scaleDownNemptyTrigger"></param>
        /// <param name="scaleUpNthreadsLimit"></param>
        /// <param name="scaleUpQsizeTrigger"></param>
        /// <param name="sizeLimit"></param>
        /// <param name="sizeLimitBytes"></param>
        /// <param name="useMultipartEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfoBatchIngestConfig(
            int? scaleDownNemptyTrigger,
            int? scaleUpNthreadsLimit,
            int? scaleUpQsizeTrigger,
            int? sizeLimit,
            long? sizeLimitBytes,
            bool? useMultipartEndpoint)
        {
            this.ScaleDownNemptyTrigger = scaleDownNemptyTrigger;
            this.ScaleUpNthreadsLimit = scaleUpNthreadsLimit;
            this.ScaleUpQsizeTrigger = scaleUpQsizeTrigger;
            this.SizeLimit = sizeLimit;
            this.SizeLimitBytes = sizeLimitBytes;
            this.UseMultipartEndpoint = useMultipartEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoBatchIngestConfig" /> class.
        /// </summary>
        public InfoBatchIngestConfig()
        {
        }

    }
}