
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `kwargs` is the event payload — an opaque JSON object whose shape depends on `name` and on the emitting SDK. For example LangChain emits `{"token": {...}}` for `new_token` events, tool-call start/end details for tool events, and arbitrary user-defined payloads for custom events. Clients should treat `kwargs` as untyped JSON: do not assume specific keys exist for a given `name`, and tolerate additional unknown keys appearing over time.
    /// </summary>
    public sealed partial class QueryRunEventKwargs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}