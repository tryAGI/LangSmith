
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackFormulaWeightedVariable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"weighted_key"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartType { get; set; } = "weighted_key";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaWeightedVariable" /> class.
        /// </summary>
        /// <param name="partType"></param>
        /// <param name="weight"></param>
        /// <param name="key"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackFormulaWeightedVariable(
            string partType,
            double weight,
            string key)
        {
            this.PartType = partType ?? throw new global::System.ArgumentNullException(nameof(partType));
            this.Weight = weight;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaWeightedVariable" /> class.
        /// </summary>
        public FeedbackFormulaWeightedVariable()
        {
        }
    }
}