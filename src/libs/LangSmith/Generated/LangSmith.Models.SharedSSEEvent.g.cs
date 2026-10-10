
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// One parsed event from a v2 query Server-Sent Events response.
    /// </summary>
    public sealed partial class SharedSSEEvent
    {
        /// <summary>
        /// The event name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SharedSSEEventEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SharedSSEEventEvent Event { get; set; }

        /// <summary>
        /// For data events, a JSON-encoded array of RFC 6902 patch operations; for end events, an empty string; for error events, a JSON-encoded ProblemDetails object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSSEEvent" /> class.
        /// </summary>
        /// <param name="event">
        /// The event name.
        /// </param>
        /// <param name="data">
        /// For data events, a JSON-encoded array of RFC 6902 patch operations; for end events, an empty string; for error events, a JSON-encoded ProblemDetails object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedSSEEvent(
            global::LangSmith.SharedSSEEventEvent @event,
            string data)
        {
            this.Event = @event;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedSSEEvent" /> class.
        /// </summary>
        public SharedSSEEvent()
        {
        }

    }
}