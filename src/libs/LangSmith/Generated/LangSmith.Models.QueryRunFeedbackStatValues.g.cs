
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `values` is the distribution of categorical feedback labels for this key, mapping each label to its occurrence count. Empty (`{}`) for purely numeric feedback.
    /// </summary>
    public sealed partial class QueryRunFeedbackStatValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}