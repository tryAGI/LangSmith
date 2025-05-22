
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartsSectionsCloneRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        public global::System.Guid? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionsCloneRequest" /> class.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsSectionsCloneRequest(
            global::System.Guid? sectionId,
            global::System.Guid? sessionId)
        {
            this.SectionId = sectionId;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionsCloneRequest" /> class.
        /// </summary>
        public CustomChartsSectionsCloneRequest()
        {
        }
    }
}