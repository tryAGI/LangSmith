
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleRestrictionUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_restricted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRestricted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRestrictionUpdate" /> class.
        /// </summary>
        /// <param name="isRestricted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleRestrictionUpdate(
            bool isRestricted)
        {
            this.IsRestricted = isRestricted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRestrictionUpdate" /> class.
        /// </summary>
        public RoleRestrictionUpdate()
        {
        }

    }
}