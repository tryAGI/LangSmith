
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsOrg
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        public bool? IsPersonal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrg" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="isPersonal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsOrg(
            string? displayName,
            string? id,
            bool? isPersonal)
        {
            this.DisplayName = displayName;
            this.Id = id;
            this.IsPersonal = isPersonal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsOrg" /> class.
        /// </summary>
        public OrgsOrg()
        {
        }

    }
}