
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Supabase SAML provider attribute_mapping. Empty keys is a valid value<br/>
    /// (clears the mapping). Map key is the claim key written into identity_data;<br/>
    /// value points at the SAML assertion attribute name.
    /// </summary>
    public sealed partial class SupabaseAttributeMapping
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseAttributeMapping" /> class.
        /// </summary>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupabaseAttributeMapping(
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? keys)
        {
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupabaseAttributeMapping" /> class.
        /// </summary>
        public SupabaseAttributeMapping()
        {
        }

    }
}