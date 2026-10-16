
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A provider that model price maps apply to, with how many maps use it.
    /// </summary>
    public sealed partial class ModelPriceMapProviderSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapProviderSchema" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPriceMapProviderSchema(
            string provider,
            int count)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPriceMapProviderSchema" /> class.
        /// </summary>
        public ModelPriceMapProviderSchema()
        {
        }

    }
}