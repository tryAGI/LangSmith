
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesListViewsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSessionIssuesViewedIssue>? Views { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesListViewsResponse" /> class.
        /// </summary>
        /// <param name="views"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesListViewsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.TracerSessionIssuesViewedIssue>? views)
        {
            this.Views = views;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesListViewsResponse" /> class.
        /// </summary>
        public TracerSessionIssuesListViewsResponse()
        {
        }

    }
}