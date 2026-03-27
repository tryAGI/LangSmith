
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsArcadeAccountOrg
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsArcadeAccountOrg" /> class.
        /// </summary>
        /// <param name="isDefault"></param>
        /// <param name="name"></param>
        /// <param name="orgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsArcadeAccountOrg(
            bool? isDefault,
            string? name,
            string? orgId)
        {
            this.IsDefault = isDefault;
            this.Name = name;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsArcadeAccountOrg" /> class.
        /// </summary>
        public McpVendorsArcadeAccountOrg()
        {
        }
    }
}