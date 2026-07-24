
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesSandboxMountConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::LangSmith.SandboxesSandboxMountAuthConfig? Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounts")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? Mounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxMountConfig" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="mounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxMountConfig(
            global::LangSmith.SandboxesSandboxMountAuthConfig? auth,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? mounts)
        {
            this.Auth = auth;
            this.Mounts = mounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxMountConfig" /> class.
        /// </summary>
        public SandboxesSandboxMountConfig()
        {
        }

    }
}