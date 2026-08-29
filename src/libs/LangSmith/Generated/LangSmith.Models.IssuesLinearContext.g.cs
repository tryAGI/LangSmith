
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesLinearContext
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_pr_urls")]
        public global::System.Collections.Generic.IList<string>? GithubPrUrls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_state")]
        public string? WorkflowState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLinearContext" /> class.
        /// </summary>
        /// <param name="githubPrUrls"></param>
        /// <param name="workflowState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesLinearContext(
            global::System.Collections.Generic.IList<string>? githubPrUrls,
            string? workflowState)
        {
            this.GithubPrUrls = githubPrUrls;
            this.WorkflowState = workflowState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesLinearContext" /> class.
        /// </summary>
        public IssuesLinearContext()
        {
        }

    }
}