
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesBatchActivityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityReport> Activities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchActivityRequest" /> class.
        /// </summary>
        /// <param name="activities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBatchActivityRequest(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityReport> activities)
        {
            this.Activities = activities ?? throw new global::System.ArgumentNullException(nameof(activities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBatchActivityRequest" /> class.
        /// </summary>
        public SandboxesBatchActivityRequest()
        {
        }
    }
}