
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalAccessPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_groups")]
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? ConditionGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_ids")]
        public global::System.Collections.Generic.IList<string>? RoleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalAccessPolicy" /> class.
        /// </summary>
        /// <param name="conditionGroups"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="roleIds"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalAccessPolicy(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? conditionGroups,
            string? createdAt,
            string? description,
            string? effect,
            string? id,
            string? name,
            global::System.Collections.Generic.IList<string>? roleIds,
            string? updatedAt)
        {
            this.ConditionGroups = conditionGroups;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Effect = effect;
            this.Id = id;
            this.Name = name;
            this.RoleIds = roleIds;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalAccessPolicy" /> class.
        /// </summary>
        public AuthzInternalAccessPolicy()
        {
        }
    }
}