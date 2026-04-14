
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsIntegrationCatalogEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_invoke")]
        public bool? CanInvoke { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegrationCatalogEntry" /> class.
        /// </summary>
        /// <param name="canInvoke"></param>
        /// <param name="displayName"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsIntegrationCatalogEntry(
            bool? canInvoke,
            string? displayName,
            string? id,
            string? key)
        {
            this.CanInvoke = canInvoke;
            this.DisplayName = displayName;
            this.Id = id;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegrationCatalogEntry" /> class.
        /// </summary>
        public IntegrationsIntegrationCatalogEntry()
        {
        }
    }
}