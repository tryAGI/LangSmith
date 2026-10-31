
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// SessionTags are AWS session tags on the role session, for role policies that scope access with ${aws:PrincipalTag/&lt;key&gt;}. The role's trust policy must allow sts:TagSession. At most 50; keys are 1-128 and values 1-256 letters, numbers, spaces or _.:=+-@ (keys may also contain /); keys starting with aws: or langsmith: are reserved. Only valid with role_arn, and cannot be changed after creation.
    /// </summary>
    public sealed partial class SandboxesProxyAWSRoleConfigSessionTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}