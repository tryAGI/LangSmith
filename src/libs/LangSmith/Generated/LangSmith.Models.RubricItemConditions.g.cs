
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RubricItemConditions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("join")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RubricItemConditionsJoinJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RubricItemConditionsJoin Join { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RubricItemConditions" /> class.
        /// </summary>
        /// <param name="join"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RubricItemConditions(
            global::LangSmith.RubricItemConditionsJoin join,
            global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule> rules)
        {
            this.Join = join;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RubricItemConditions" /> class.
        /// </summary>
        public RubricItemConditions()
        {
        }

    }
}