
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Single entry in a Supabase SAML attribute_mapping.keys map.
    /// </summary>
    public sealed partial class SupabaseAttributeMappingKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array")]
        public bool? Array { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseAttributeMappingKey" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="array">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupabaseAttributeMappingKey(
            string name,
            bool? array)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Array = array;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseAttributeMappingKey" /> class.
        /// </summary>
        public SupabaseAttributeMappingKey()
        {
        }
    }
}