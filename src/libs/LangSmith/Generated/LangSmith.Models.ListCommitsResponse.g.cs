
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCommitsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups> Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommitsResponse" /> class.
        /// </summary>
        /// <param name="commits"></param>
        /// <param name="total"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListCommitsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups> commits,
            int total)
        {
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCommitsResponse" /> class.
        /// </summary>
        public ListCommitsResponse()
        {
        }
    }
}