
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Aggregate feedback for one feedback key.
    /// </summary>
    public sealed partial class SessionFeedbackStat
    {
        /// <summary>
        /// Number of feedback scores for this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int N { get; set; }

        /// <summary>
        /// Mean numeric score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        public double? Avg { get; set; }

        /// <summary>
        /// Median numeric score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        public double? Median { get; set; }

        /// <summary>
        /// Standard deviation of numeric scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdev")]
        public double? Stdev { get; set; }

        /// <summary>
        /// Lowest numeric score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Highest numeric score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Number of feedback entries recorded as errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errors { get; set; }

        /// <summary>
        /// Count of each categorical value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Values { get; set; }

        /// <summary>
        /// `PRIMARY` for recorded feedback, `COMPOSITE` for a score computed from other feedback keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SessionFeedbackStatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SessionFeedbackStatType Type { get; set; }

        /// <summary>
        /// Whether any feedback was left on a thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contains_thread_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContainsThreadFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackStat" /> class.
        /// </summary>
        /// <param name="n">
        /// Number of feedback scores for this key.
        /// </param>
        /// <param name="errors">
        /// Number of feedback entries recorded as errors.
        /// </param>
        /// <param name="values">
        /// Count of each categorical value.
        /// </param>
        /// <param name="type">
        /// `PRIMARY` for recorded feedback, `COMPOSITE` for a score computed from other feedback keys.
        /// </param>
        /// <param name="containsThreadFeedback">
        /// Whether any feedback was left on a thread.
        /// </param>
        /// <param name="avg">
        /// Mean numeric score.
        /// </param>
        /// <param name="median">
        /// Median numeric score.
        /// </param>
        /// <param name="stdev">
        /// Standard deviation of numeric scores.
        /// </param>
        /// <param name="min">
        /// Lowest numeric score.
        /// </param>
        /// <param name="max">
        /// Highest numeric score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionFeedbackStat(
            int n,
            int errors,
            global::System.Collections.Generic.Dictionary<string, int> values,
            global::LangSmith.SessionFeedbackStatType type,
            bool containsThreadFeedback,
            double? avg,
            double? median,
            double? stdev,
            double? min,
            double? max)
        {
            this.N = n;
            this.Avg = avg;
            this.Median = median;
            this.Stdev = stdev;
            this.Min = min;
            this.Max = max;
            this.Errors = errors;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Type = type;
            this.ContainsThreadFeedback = containsThreadFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackStat" /> class.
        /// </summary>
        public SessionFeedbackStat()
        {
        }

    }
}