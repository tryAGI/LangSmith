
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsCreateThreadOptions
    {
        /// <summary>
        /// SkipMemoryWriteProtection lets runs on this thread bypass the default<br/>
        /// long-term-memory write protection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_memory_write_protection")]
        public bool? SkipMemoryWriteProtection { get; set; }

        /// <summary>
        /// TestRun marks the thread as a test run; filtered out of usage and analytics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run")]
        public bool? TestRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadOptions" /> class.
        /// </summary>
        /// <param name="skipMemoryWriteProtection">
        /// SkipMemoryWriteProtection lets runs on this thread bypass the default<br/>
        /// long-term-memory write protection.
        /// </param>
        /// <param name="testRun">
        /// TestRun marks the thread as a test run; filtered out of usage and analytics.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsCreateThreadOptions(
            bool? skipMemoryWriteProtection,
            bool? testRun)
        {
            this.SkipMemoryWriteProtection = skipMemoryWriteProtection;
            this.TestRun = testRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadOptions" /> class.
        /// </summary>
        public ThreadsCreateThreadOptions()
        {
        }

    }
}