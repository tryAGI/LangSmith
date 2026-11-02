
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommitsListCommitsResponse
    {
        /// <summary>
        /// List of commits with lookup information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? Commits { get; set; }

        /// <summary>
        /// NextCursor is the cursor for the next page, or null when there are no more commits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Total number of commits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsListCommitsResponse" /> class.
        /// </summary>
        /// <param name="commits">
        /// List of commits with lookup information
        /// </param>
        /// <param name="nextCursor">
        /// NextCursor is the cursor for the next page, or null when there are no more commits.
        /// </param>
        /// <param name="total">
        /// Total number of commits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitsListCommitsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? commits,
            string? nextCursor,
            int? total)
        {
            this.Commits = commits;
            this.NextCursor = nextCursor;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsListCommitsResponse" /> class.
        /// </summary>
        public CommitsListCommitsResponse()
        {
        }

    }
}