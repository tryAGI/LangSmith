
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRunEvent
    {
        /// <summary>
        /// `kwargs` is the event payload — an opaque JSON object whose shape depends on `name` and on the emitting SDK. For example LangChain emits `{"token": {...}}` for `new_token` events, tool-call start/end details for tool events, and arbitrary user-defined payloads for custom events. Clients should treat `kwargs` as untyped JSON: do not assume specific keys exist for a given `name`, and tolerate additional unknown keys appearing over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kwargs")]
        public object? Kwargs { get; set; }

        /// <summary>
        /// `name` is the event kind. Common values emitted by the LangChain/LangSmith tracer SDKs include `"start"`, `"end"`, and `"new_token"`, but applications may emit arbitrary strings for their own instrumentation.<br/>
        /// Example: new_token
        /// </summary>
        /// <example>new_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// `time` is when the event occurred (RFC3339 date-time with millisecond precision).<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </summary>
        /// <example>2024-01-15T10:30:00.312Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public global::System.DateTime? Time { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunEvent" /> class.
        /// </summary>
        /// <param name="kwargs">
        /// `kwargs` is the event payload — an opaque JSON object whose shape depends on `name` and on the emitting SDK. For example LangChain emits `{"token": {...}}` for `new_token` events, tool-call start/end details for tool events, and arbitrary user-defined payloads for custom events. Clients should treat `kwargs` as untyped JSON: do not assume specific keys exist for a given `name`, and tolerate additional unknown keys appearing over time.
        /// </param>
        /// <param name="name">
        /// `name` is the event kind. Common values emitted by the LangChain/LangSmith tracer SDKs include `"start"`, `"end"`, and `"new_token"`, but applications may emit arbitrary strings for their own instrumentation.<br/>
        /// Example: new_token
        /// </param>
        /// <param name="time">
        /// `time` is when the event occurred (RFC3339 date-time with millisecond precision).<br/>
        /// Example: 2024-01-15T10:30:00.312Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRunEvent(
            object? kwargs,
            string? name,
            global::System.DateTime? time)
        {
            this.Kwargs = kwargs;
            this.Name = name;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunEvent" /> class.
        /// </summary>
        public QueryRunEvent()
        {
        }
    }
}