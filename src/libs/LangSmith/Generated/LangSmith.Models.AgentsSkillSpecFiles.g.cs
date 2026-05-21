
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Supporting files keyed by relative path. Each path becomes `skills/&lt;name&gt;/&lt;path&gt;`.<br/>
    /// Paths must be relative — no leading `/`, no `..` segments.
    /// </summary>
    public sealed partial class AgentsSkillSpecFiles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}