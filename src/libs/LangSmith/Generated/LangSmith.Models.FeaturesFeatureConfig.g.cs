
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_models")]
        public global::System.Collections.Generic.IList<string>? DisabledModels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature")]
        public string? Feature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesFeatureConfig" /> class.
        /// </summary>
        /// <param name="defaultModel"></param>
        /// <param name="disabledModels"></param>
        /// <param name="feature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeaturesFeatureConfig(
            string? defaultModel,
            global::System.Collections.Generic.IList<string>? disabledModels,
            string? feature)
        {
            this.DefaultModel = defaultModel;
            this.DisabledModels = disabledModels;
            this.Feature = feature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesFeatureConfig" /> class.
        /// </summary>
        public FeaturesFeatureConfig()
        {
        }
    }
}