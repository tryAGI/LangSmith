
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsUpdateThreadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::LangSmith.ThreadsUpdateThreadMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::LangSmith.ThreadsOptionalFieldString? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadRequest" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsUpdateThreadRequest(
            global::LangSmith.ThreadsUpdateThreadMetadata? metadata,
            global::LangSmith.ThreadsOptionalFieldString? title)
        {
            this.Metadata = metadata;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsUpdateThreadRequest" /> class.
        /// </summary>
        public ThreadsUpdateThreadRequest()
        {
        }

    }
}