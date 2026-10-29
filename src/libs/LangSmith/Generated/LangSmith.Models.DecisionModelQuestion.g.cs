
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A question a decision model answers about each run.
    /// </summary>
    public sealed partial class DecisionModelQuestion
    {
        /// <summary>
        /// noul: a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DecisionModelQuestionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.DecisionModelQuestionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// What a yes answer means. noul only; set both yes and no, or neither.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yes")]
        public string? Yes { get; set; }

        /// <summary>
        /// What a no answer means. noul only; set both yes and no, or neither.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no")]
        public string? No { get; set; }

        /// <summary>
        /// 2 to 255 option names, or names mapped to descriptions. choice only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? Options { get; set; }

        /// <summary>
        /// 2 to 10 level names, lowest first. score only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("levels")]
        public global::System.Collections.Generic.IList<string>? Levels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelQuestion" /> class.
        /// </summary>
        /// <param name="type">
        /// noul: a yes/no question scored 0 to 1. choice: one of the options. score: one of the levels, scored by position.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="yes">
        /// What a yes answer means. noul only; set both yes and no, or neither.
        /// </param>
        /// <param name="no">
        /// What a no answer means. noul only; set both yes and no, or neither.
        /// </param>
        /// <param name="options">
        /// 2 to 255 option names, or names mapped to descriptions. choice only.
        /// </param>
        /// <param name="levels">
        /// 2 to 10 level names, lowest first. score only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionModelQuestion(
            global::LangSmith.DecisionModelQuestionType type,
            string instructions,
            string? yes,
            string? no,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? options,
            global::System.Collections.Generic.IList<string>? levels)
        {
            this.Type = type;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Yes = yes;
            this.No = no;
            this.Options = options;
            this.Levels = levels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionModelQuestion" /> class.
        /// </summary>
        public DecisionModelQuestion()
        {
        }

    }
}