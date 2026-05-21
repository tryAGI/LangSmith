
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Raw file map for paths the typed fields don't cover. Setting a typed<br/>
    /// field and the corresponding `files` entry returns 422.
    /// </summary>
    public sealed partial class AgentsCreateAgentRequestFiles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}