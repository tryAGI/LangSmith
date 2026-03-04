
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalCreateAccessPolicyPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_groups")]
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? ConditionGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect")]
        public string? Effect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// if present, attach to the specified roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_ids")]
        public global::System.Collections.Generic.IList<string>? RoleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalCreateAccessPolicyPayload" /> class.
        /// </summary>
        /// <param name="conditionGroups"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="name"></param>
        /// <param name="roleIds">
        /// if present, attach to the specified roles
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalCreateAccessPolicyPayload(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? conditionGroups,
            string? description,
            string? effect,
            string? name,
            global::System.Collections.Generic.IList<string>? roleIds)
        {
            this.ConditionGroups = conditionGroups;
            this.Description = description;
            this.Effect = effect;
            this.Name = name;
            this.RoleIds = roleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalCreateAccessPolicyPayload" /> class.
        /// </summary>
        public AuthzInternalCreateAccessPolicyPayload()
        {
        }
    }
}