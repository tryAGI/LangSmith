
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesActivityResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("k8s_sandbox_name")]
        public string? K8sSandboxName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_activity")]
        public bool? TrackActivity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesActivityResult" /> class.
        /// </summary>
        /// <param name="k8sSandboxName"></param>
        /// <param name="trackActivity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesActivityResult(
            string? k8sSandboxName,
            bool? trackActivity)
        {
            this.K8sSandboxName = k8sSandboxName;
            this.TrackActivity = trackActivity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesActivityResult" /> class.
        /// </summary>
        public SandboxesActivityResult()
        {
        }
    }
}