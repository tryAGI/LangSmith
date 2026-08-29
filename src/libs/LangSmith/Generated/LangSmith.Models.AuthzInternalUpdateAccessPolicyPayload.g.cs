
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthzInternalUpdateAccessPolicyPayload
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalUpdateAccessPolicyPayload" /> class.
        /// </summary>
        /// <param name="conditionGroups"></param>
        /// <param name="description"></param>
        /// <param name="effect"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalUpdateAccessPolicyPayload(
            global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? conditionGroups,
            string? description,
            string? effect,
            string? name)
        {
            this.ConditionGroups = conditionGroups;
            this.Description = description;
            this.Effect = effect;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalUpdateAccessPolicyPayload" /> class.
        /// </summary>
        public AuthzInternalUpdateAccessPolicyPayload()
        {
        }

    }
}