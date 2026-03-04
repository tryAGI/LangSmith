
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalConditionGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthzInternalPermissionJsonConverter))]
        public global::LangSmith.AuthzInternalPermission? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalConditionGroup" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="permission"></param>
        /// <param name="resourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalConditionGroup(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? conditions,
            global::LangSmith.AuthzInternalPermission? permission,
            string? resourceType)
        {
            this.Conditions = conditions;
            this.Permission = permission;
            this.ResourceType = resourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalConditionGroup" /> class.
        /// </summary>
        public AuthzInternalConditionGroup()
        {
        }
    }
}