
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PermissionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AccessScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AccessScope AccessScope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="accessScope"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PermissionResponse(
            string name,
            string description,
            global::LangSmith.AccessScope accessScope)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.AccessScope = accessScope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResponse" /> class.
        /// </summary>
        public PermissionResponse()
        {
        }
    }
}