
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesStartPreviewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_number")]
        public int? PrNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesStartPreviewResponse" /> class.
        /// </summary>
        /// <param name="prNumber"></param>
        /// <param name="previewUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesStartPreviewResponse(
            int? prNumber,
            string? previewUrl)
        {
            this.PrNumber = prNumber;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesStartPreviewResponse" /> class.
        /// </summary>
        public TracerSessionIssuesStartPreviewResponse()
        {
        }

    }
}