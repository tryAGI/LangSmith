
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RubricItemConditionRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RubricItemConditionRuleOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RubricItemConditionRuleOp Op { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<double>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RubricItemConditionRule" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="op"></param>
        /// <param name="values">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RubricItemConditionRule(
            string key,
            global::LangSmith.RubricItemConditionRuleOp op,
            global::System.Collections.Generic.IList<double>? values)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Op = op;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RubricItemConditionRule" /> class.
        /// </summary>
        public RubricItemConditionRule()
        {
        }

    }
}