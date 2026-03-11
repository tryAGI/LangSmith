
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response to preview a thread.
    /// </summary>
    public sealed partial class ThreadPreviewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ThreadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.Dictionary<string, string> Previews { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadPreviewResponse" /> class.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="previews"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadPreviewResponse(
            string threadId,
            global::System.Collections.Generic.Dictionary<string, string> previews)
        {
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Previews = previews ?? throw new global::System.ArgumentNullException(nameof(previews));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadPreviewResponse" /> class.
        /// </summary>
        public ThreadPreviewResponse()
        {
        }
    }
}