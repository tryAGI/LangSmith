
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesRecordFixVerdictRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public object? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesRecordFixVerdictRequest" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesRecordFixVerdictRequest(
            object? detail,
            string? status)
        {
            this.Detail = detail;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesRecordFixVerdictRequest" /> class.
        /// </summary>
        public TracerSessionIssuesRecordFixVerdictRequest()
        {
        }

    }
}