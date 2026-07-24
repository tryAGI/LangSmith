
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesSandboxMountAuthConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws")]
        public global::LangSmith.SandboxesSandboxAWSMountAuthConfig? Aws { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp")]
        public global::LangSmith.SandboxesSandboxGCPMountAuthConfig? Gcp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxMountAuthConfig" /> class.
        /// </summary>
        /// <param name="aws"></param>
        /// <param name="gcp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxMountAuthConfig(
            global::LangSmith.SandboxesSandboxAWSMountAuthConfig? aws,
            global::LangSmith.SandboxesSandboxGCPMountAuthConfig? gcp)
        {
            this.Aws = aws;
            this.Gcp = gcp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxMountAuthConfig" /> class.
        /// </summary>
        public SandboxesSandboxMountAuthConfig()
        {
        }

    }
}