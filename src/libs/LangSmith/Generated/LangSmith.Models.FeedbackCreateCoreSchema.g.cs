
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema used for creating feedback without run id or session id.
    /// </summary>
    public sealed partial class FeedbackCreateCoreSchema
    {
        /// <summary>
        /// When the feedback was created, as an ISO 8601 timestamp. Defaults to now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the feedback was last modified, as an ISO 8601 timestamp. Defaults to now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The numeric or boolean score. Numbers must be between -99999.9999 and 99999.9999 with at most 4 decimal places.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>))]
        public global::LangSmith.AnyOf<double?, int?, bool?>? Score { get; set; }

        /// <summary>
        /// A non-numeric value, such as a category label or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>))]
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Value { get; set; }

        /// <summary>
        /// A free-text comment explaining the feedback. Truncated at the feedback size limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The corrected output for the run, as a string or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>))]
        public global::LangSmith.AnyOf<object, string>? Correction { get; set; }

        /// <summary>
        /// Groups feedback written together, such as one comparison in a pairwise experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_group_id")]
        public global::System.Guid? FeedbackGroupId { get; set; }

        /// <summary>
        /// The ID of the comparative (pairwise) experiment this feedback was written for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_source")]
        public global::LangSmith.FeedbackSourceVariant1? FeedbackSource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        public global::LangSmith.FeedbackConfig? FeedbackConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateCoreSchema" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="createdAt">
        /// When the feedback was created, as an ISO 8601 timestamp. Defaults to now.
        /// </param>
        /// <param name="modifiedAt">
        /// When the feedback was last modified, as an ISO 8601 timestamp. Defaults to now.
        /// </param>
        /// <param name="score">
        /// The numeric or boolean score. Numbers must be between -99999.9999 and 99999.9999 with at most 4 decimal places.
        /// </param>
        /// <param name="value">
        /// A non-numeric value, such as a category label or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </param>
        /// <param name="comment">
        /// A free-text comment explaining the feedback. Truncated at the feedback size limit.
        /// </param>
        /// <param name="correction">
        /// The corrected output for the run, as a string or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </param>
        /// <param name="feedbackGroupId">
        /// Groups feedback written together, such as one comparison in a pairwise experiment.
        /// </param>
        /// <param name="comparativeExperimentId">
        /// The ID of the comparative (pairwise) experiment this feedback was written for.
        /// </param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="extra"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateCoreSchema(
            string key,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            global::LangSmith.AnyOf<double?, int?, bool?>? score,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object>? value,
            string? comment,
            global::LangSmith.AnyOf<object, string>? correction,
            global::System.Guid? feedbackGroupId,
            global::System.Guid? comparativeExperimentId,
            global::System.Guid? id,
            global::LangSmith.FeedbackSourceVariant1? feedbackSource,
            global::LangSmith.FeedbackConfig? feedbackConfig,
            object? extra)
        {
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Score = score;
            this.Value = value;
            this.Comment = comment;
            this.Correction = correction;
            this.FeedbackGroupId = feedbackGroupId;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.Id = id;
            this.FeedbackSource = feedbackSource;
            this.FeedbackConfig = feedbackConfig;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateCoreSchema" /> class.
        /// </summary>
        public FeedbackCreateCoreSchema()
        {
        }

    }
}