
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
        [global::System.Text.Json.Serialization.JsonPropertyName("part_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.FeedbackFormulaWeightedVariablePartTypeJsonConverter))]
        public global::LangSmith.FeedbackFormulaWeightedVariablePartType PartType { get; set; }

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
            double weight,
            string key,
            global::LangSmith.FeedbackFormulaWeightedVariablePartType partType)
        {
            this.Weight = weight;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.PartType = partType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormulaWeightedVariable" /> class.
        /// </summary>
        public FeedbackFormulaWeightedVariable()
        {
        }
    }
}