
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesUpdatePoolPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdatePoolPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="replicas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUpdatePoolPayload(
            string? name,
            int? replicas)
        {
            this.Name = name;
            this.Replicas = replicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdatePoolPayload" /> class.
        /// </summary>
        public SandboxesUpdatePoolPayload()
        {
        }
    }
}