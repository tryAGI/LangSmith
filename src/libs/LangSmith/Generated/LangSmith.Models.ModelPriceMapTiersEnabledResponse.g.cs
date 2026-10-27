
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Whether pricing tiers apply to this workspace's runs.
    /// </summary>
    public sealed partial class ModelPriceMapTiersEnabledResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapTiersEnabledResponse" /> class.
        /// </summary>
        /// <param name="isEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPriceMapTiersEnabledResponse(
            bool isEnabled)
        {
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapTiersEnabledResponse" /> class.
        /// </summary>
        public ModelPriceMapTiersEnabledResponse()
        {
        }

    }
}