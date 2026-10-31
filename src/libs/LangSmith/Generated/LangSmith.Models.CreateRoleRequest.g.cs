
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateRoleRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Permissions to grant. Organization roles do not require organization:read or organization:read-metadata. Omitting these permissions may limit access to organization settings pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// Scope of the role. Cannot be changed after creation.<br/>
        /// Default Value: workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AccessScopeJsonConverter))]
        public global::LangSmith.AccessScope? AccessScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoleRequest" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="permissions">
        /// Permissions to grant. Organization roles do not require organization:read or organization:read-metadata. Omitting these permissions may limit access to organization settings pages.
        /// </param>
        /// <param name="accessScope">
        /// Scope of the role. Cannot be changed after creation.<br/>
        /// Default Value: workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRoleRequest(
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::LangSmith.AccessScope? accessScope)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.AccessScope = accessScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoleRequest" /> class.
        /// </summary>
        public CreateRoleRequest()
        {
        }

    }
}