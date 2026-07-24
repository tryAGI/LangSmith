
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryPublicSharedTraceRunsRequestBody
    {
        /// <summary>
        /// `selects` lists which public run properties to include on each returned run.<br/>
        /// Example: [ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS, INPUTS_PREVIEW, OUTPUTS_PREVIEW, METADATA]
        /// </summary>
        /// <example>[ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS, INPUTS_PREVIEW, OUTPUTS_PREVIEW, METADATA]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("selects")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? Selects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPublicSharedTraceRunsRequestBody" /> class.
        /// </summary>
        /// <param name="selects">
        /// `selects` lists which public run properties to include on each returned run.<br/>
        /// Example: [ID, NAME, PROJECT_ID, START_TIME, RUN_TYPE, STATUS, INPUTS_PREVIEW, OUTPUTS_PREVIEW, METADATA]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryPublicSharedTraceRunsRequestBody(
            global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? selects)
        {
            this.Selects = selects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryPublicSharedTraceRunsRequestBody" /> class.
        /// </summary>
        public QueryPublicSharedTraceRunsRequestBody()
        {
        }

    }
}