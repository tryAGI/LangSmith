
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesResourceSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu")]
        public string? Cpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        public string? Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        public string? Storage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesResourceSpec" /> class.
        /// </summary>
        /// <param name="cpu"></param>
        /// <param name="memory"></param>
        /// <param name="storage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesResourceSpec(
            string? cpu,
            string? memory,
            string? storage)
        {
            this.Cpu = cpu;
            this.Memory = memory;
            this.Storage = storage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesResourceSpec" /> class.
        /// </summary>
        public SandboxesResourceSpec()
        {
        }
    }
}