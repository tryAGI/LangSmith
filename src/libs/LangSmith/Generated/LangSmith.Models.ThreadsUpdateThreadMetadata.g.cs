
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsUpdateThreadMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pinned")]
        public global::LangSmith.ThreadsOptionalFieldBool? IsPinned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_test_run")]
        public global::LangSmith.ThreadsOptionalFieldBool? IsTestRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_status")]
        public global::LangSmith.ThreadsOptionalFieldBool? ReadStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_recreated_at")]
        public global::LangSmith.ThreadsOptionalFieldString? SandboxRecreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_memory_write_protection")]
        public global::LangSmith.ThreadsOptionalFieldBool? SkipMemoryWriteProtection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadMetadata" /> class.
        /// </summary>
        /// <param name="isPinned"></param>
        /// <param name="isTestRun"></param>
        /// <param name="readStatus"></param>
        /// <param name="sandboxRecreatedAt"></param>
        /// <param name="skipMemoryWriteProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsUpdateThreadMetadata(
            global::LangSmith.ThreadsOptionalFieldBool? isPinned,
            global::LangSmith.ThreadsOptionalFieldBool? isTestRun,
            global::LangSmith.ThreadsOptionalFieldBool? readStatus,
            global::LangSmith.ThreadsOptionalFieldString? sandboxRecreatedAt,
            global::LangSmith.ThreadsOptionalFieldBool? skipMemoryWriteProtection)
        {
            this.IsPinned = isPinned;
            this.IsTestRun = isTestRun;
            this.ReadStatus = readStatus;
            this.SandboxRecreatedAt = sandboxRecreatedAt;
            this.SkipMemoryWriteProtection = skipMemoryWriteProtection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadMetadata" /> class.
        /// </summary>
        public ThreadsUpdateThreadMetadata()
        {
        }

    }
}