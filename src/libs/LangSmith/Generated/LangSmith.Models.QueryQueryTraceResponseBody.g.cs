
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryTraceResponseBody
    {
        /// <summary>
        /// `items` lists runs in the trace for the requested time window, in `start_time` order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryTraceResponseBody" /> class.
        /// </summary>
        /// <param name="items">
        /// `items` lists runs in the trace for the requested time window, in `start_time` order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryTraceResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? items)
        {
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryTraceResponseBody" /> class.
        /// </summary>
        public QueryQueryTraceResponseBody()
        {
        }
    }
}