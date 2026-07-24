
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiGitMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public global::LangSmith.SandboxapiGitMountRefSpec? Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_interval_seconds")]
        public int? RefreshIntervalSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiGitMountSpec" /> class.
        /// </summary>
        /// <param name="remoteUrl"></param>
        /// <param name="ref"></param>
        /// <param name="refreshIntervalSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiGitMountSpec(
            string remoteUrl,
            global::LangSmith.SandboxapiGitMountRefSpec? @ref,
            int? refreshIntervalSeconds)
        {
            this.Ref = @ref;
            this.RefreshIntervalSeconds = refreshIntervalSeconds;
            this.RemoteUrl = remoteUrl ?? throw new global::System.ArgumentNullException(nameof(remoteUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiGitMountSpec" /> class.
        /// </summary>
        public SandboxapiGitMountSpec()
        {
        }

    }
}