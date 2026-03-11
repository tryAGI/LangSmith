
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Short summary of queue counts.
    /// </summary>
    public sealed partial class QueueInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Queued { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Active { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Scheduled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueInfoResponse" /> class.
        /// </summary>
        /// <param name="queued"></param>
        /// <param name="active"></param>
        /// <param name="scheduled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueInfoResponse(
            int queued,
            int active,
            int scheduled)
        {
            this.Queued = queued;
            this.Active = active;
            this.Scheduled = scheduled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueInfoResponse" /> class.
        /// </summary>
        public QueueInfoResponse()
        {
        }
    }
}