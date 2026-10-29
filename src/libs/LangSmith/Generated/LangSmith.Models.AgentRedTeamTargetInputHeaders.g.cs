
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Headers are write-only and required unless clearing. An empty value<br/>
    /// keeps that header's saved value while the url is unchanged.
    /// </summary>
    public sealed partial class AgentRedTeamTargetInputHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}