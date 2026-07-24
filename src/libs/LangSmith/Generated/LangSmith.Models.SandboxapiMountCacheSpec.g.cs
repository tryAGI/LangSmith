
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiMountCacheSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size_bytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writeback_seconds")]
        public int? WritebackSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountCacheSpec" /> class.
        /// </summary>
        /// <param name="maxSizeBytes"></param>
        /// <param name="writebackSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiMountCacheSpec(
            long? maxSizeBytes,
            int? writebackSeconds)
        {
            this.MaxSizeBytes = maxSizeBytes;
            this.WritebackSeconds = writebackSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiMountCacheSpec" /> class.
        /// </summary>
        public SandboxapiMountCacheSpec()
        {
        }

    }
}