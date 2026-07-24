
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeaturesFeatureConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        public string? DefaultModel { get; set; }

        /// <summary>
        /// DisabledModels is the effective disabled set for the feature: the union of<br/>
        /// this workspace's own disabled providers/models and the org-wide disabled<br/>
        /// providers. Every consumer (pickers, Fleet catalog) hides these.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_models")]
        public global::System.Collections.Generic.IList<string>? DisabledModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        public string? Feature { get; set; }

        /// <summary>
        /// OrgDisabledProviders is the subset of DisabledModels that is enforced at the<br/>
        /// organization level. The workspace settings UI renders these locked so a<br/>
        /// workspace admin cannot re-enable them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_disabled_providers")]
        public global::System.Collections.Generic.IList<string>? OrgDisabledProviders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesFeatureConfig" /> class.
        /// </summary>
        /// <param name="defaultModel"></param>
        /// <param name="disabledModels">
        /// DisabledModels is the effective disabled set for the feature: the union of<br/>
        /// this workspace's own disabled providers/models and the org-wide disabled<br/>
        /// providers. Every consumer (pickers, Fleet catalog) hides these.
        /// </param>
        /// <param name="feature"></param>
        /// <param name="orgDisabledProviders">
        /// OrgDisabledProviders is the subset of DisabledModels that is enforced at the<br/>
        /// organization level. The workspace settings UI renders these locked so a<br/>
        /// workspace admin cannot re-enable them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeaturesFeatureConfig(
            string? defaultModel,
            global::System.Collections.Generic.IList<string>? disabledModels,
            string? feature,
            global::System.Collections.Generic.IList<string>? orgDisabledProviders)
        {
            this.DefaultModel = defaultModel;
            this.DisabledModels = disabledModels;
            this.Feature = feature;
            this.OrgDisabledProviders = orgDisabledProviders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesFeatureConfig" /> class.
        /// </summary>
        public FeaturesFeatureConfig()
        {
        }

    }
}