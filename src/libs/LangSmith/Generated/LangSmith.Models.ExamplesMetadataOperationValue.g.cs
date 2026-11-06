
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The new value for a SET operation; any JSON value, at most 64 KB. Ignored by<br/>
    /// array operations.
    /// </summary>
    public sealed partial class ExamplesMetadataOperationValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}