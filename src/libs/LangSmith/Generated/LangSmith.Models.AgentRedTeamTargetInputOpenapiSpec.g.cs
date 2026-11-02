
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OpenAPISpec is the endpoint's OpenAPI 3 document, for an openapi target.<br/>
    /// Omit it to keep the saved document while the url is unchanged. An<br/>
    /// openapi target cannot clear it with null.
    /// </summary>
    public sealed partial class AgentRedTeamTargetInputOpenapiSpec
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}