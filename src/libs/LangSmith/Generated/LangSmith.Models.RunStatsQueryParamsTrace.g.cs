
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Filter runs by trace ID. When set, limit and cursor-based pagination are not applied — all runs in the trace are returned in a single response.
    /// </summary>
    public sealed partial class RunStatsQueryParamsTrace
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}