
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxapiContextHubMountSpec
    {
        /// <summary>
        /// InitialPullOnly syncs the repo once at startup instead of polling for<br/>
        /// updates for the sandbox's lifetime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_pull_only")]
        public bool? InitialPullOnly { get; set; }

        /// <summary>
        /// Repo is the Context Hub repository to sync, as "owner/repo"<br/>
        /// (e.g. "-/my-agent", where "-" is the current workspace). The repo's<br/>
        /// latest commit tree is mirrored into the mount path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiContextHubMountSpec" /> class.
        /// </summary>
        /// <param name="repo">
        /// Repo is the Context Hub repository to sync, as "owner/repo"<br/>
        /// (e.g. "-/my-agent", where "-" is the current workspace). The repo's<br/>
        /// latest commit tree is mirrored into the mount path.
        /// </param>
        /// <param name="initialPullOnly">
        /// InitialPullOnly syncs the repo once at startup instead of polling for<br/>
        /// updates for the sandbox's lifetime.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiContextHubMountSpec(
            string repo,
            bool? initialPullOnly)
        {
            this.InitialPullOnly = initialPullOnly;
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiContextHubMountSpec" /> class.
        /// </summary>
        public SandboxapiContextHubMountSpec()
        {
        }

    }
}