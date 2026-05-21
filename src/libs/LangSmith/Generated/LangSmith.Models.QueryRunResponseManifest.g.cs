
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// `manifest` is the serialized configuration of the traced component (for example the model parameters, prompt template, or pipeline definition), when recorded.
    /// </summary>
    public sealed partial class QueryRunResponseManifest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}