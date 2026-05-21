
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryRunFeedbackStat
    {
        /// <summary>
        /// `avg` is the arithmetic mean of numeric feedback scores for this key on the run, or `null` when no numeric score has been recorded (for example purely categorical feedback).<br/>
        /// Example: 0.87F
        /// </summary>
        /// <example>0.87F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        public double? Avg { get; set; }

        /// <summary>
        /// `comments` is a sample of human-readable comments attached to feedback points for this key, in no particular order. May be empty; is not exhaustive when many comments exist.<br/>
        /// Example: [good answer, needs citation]
        /// </summary>
        /// <example>[good answer, needs citation]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public global::System.Collections.Generic.IList<string>? Comments { get; set; }

        /// <summary>
        /// `contains_thread_feedback` is true when at least one feedback point for this key was submitted at the thread level (rather than at an individual run). Always false on responses that already describe a single run in isolation.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contains_thread_feedback")]
        public bool? ContainsThreadFeedback { get; set; }

        /// <summary>
        /// `errors` is the number of feedback points recorded as errors rather than successful scores (for example an automated evaluator that raised an exception). Defaults to 0 when no errors occurred.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public int? Errors { get; set; }

        /// <summary>
        /// `max` is the largest numeric feedback score recorded for this key on the run, or `null` when no numeric score has been recorded.<br/>
        /// Example: 0.95F
        /// </summary>
        /// <example>0.95F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// `min` is the smallest numeric feedback score recorded for this key on the run, or `null` when no numeric score has been recorded.<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// `n` is the number of feedback points recorded for this key on the run. For numeric feedback this is the sample size behind `avg`, `min`, `max`, and `stdev`; for categorical feedback it is the sum of the `values` counts.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// `sources` is a sample of feedback sources for this key. Each entry is either a plain string identifier (for example `"api"`, `"app"`, `"model"`) or a JSON object describing a synthetic source (for example `{"type": "__ls_composite_feedback"}` for a computed aggregate). Clients must tolerate both shapes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<object>? Sources { get; set; }

        /// <summary>
        /// `stdev` is the sample standard deviation of numeric feedback scores for this key on the run, or `null` when it cannot be computed (for example fewer than two numeric scores, or purely categorical feedback).<br/>
        /// Example: 0.05F
        /// </summary>
        /// <example>0.05F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdev")]
        public double? Stdev { get; set; }

        /// <summary>
        /// `values` is the distribution of categorical feedback labels for this key, mapping each label to its occurrence count. Empty (`{}`) for purely numeric feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.Dictionary<string, long>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunFeedbackStat" /> class.
        /// </summary>
        /// <param name="avg">
        /// `avg` is the arithmetic mean of numeric feedback scores for this key on the run, or `null` when no numeric score has been recorded (for example purely categorical feedback).<br/>
        /// Example: 0.87F
        /// </param>
        /// <param name="comments">
        /// `comments` is a sample of human-readable comments attached to feedback points for this key, in no particular order. May be empty; is not exhaustive when many comments exist.<br/>
        /// Example: [good answer, needs citation]
        /// </param>
        /// <param name="containsThreadFeedback">
        /// `contains_thread_feedback` is true when at least one feedback point for this key was submitted at the thread level (rather than at an individual run). Always false on responses that already describe a single run in isolation.<br/>
        /// Example: false
        /// </param>
        /// <param name="errors">
        /// `errors` is the number of feedback points recorded as errors rather than successful scores (for example an automated evaluator that raised an exception). Defaults to 0 when no errors occurred.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="max">
        /// `max` is the largest numeric feedback score recorded for this key on the run, or `null` when no numeric score has been recorded.<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="min">
        /// `min` is the smallest numeric feedback score recorded for this key on the run, or `null` when no numeric score has been recorded.<br/>
        /// Example: 0.8F
        /// </param>
        /// <param name="n">
        /// `n` is the number of feedback points recorded for this key on the run. For numeric feedback this is the sample size behind `avg`, `min`, `max`, and `stdev`; for categorical feedback it is the sum of the `values` counts.<br/>
        /// Example: 42
        /// </param>
        /// <param name="sources">
        /// `sources` is a sample of feedback sources for this key. Each entry is either a plain string identifier (for example `"api"`, `"app"`, `"model"`) or a JSON object describing a synthetic source (for example `{"type": "__ls_composite_feedback"}` for a computed aggregate). Clients must tolerate both shapes.
        /// </param>
        /// <param name="stdev">
        /// `stdev` is the sample standard deviation of numeric feedback scores for this key on the run, or `null` when it cannot be computed (for example fewer than two numeric scores, or purely categorical feedback).<br/>
        /// Example: 0.05F
        /// </param>
        /// <param name="values">
        /// `values` is the distribution of categorical feedback labels for this key, mapping each label to its occurrence count. Empty (`{}`) for purely numeric feedback.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryRunFeedbackStat(
            double? avg,
            global::System.Collections.Generic.IList<string>? comments,
            bool? containsThreadFeedback,
            int? errors,
            double? max,
            double? min,
            int? n,
            global::System.Collections.Generic.IList<object>? sources,
            double? stdev,
            global::System.Collections.Generic.Dictionary<string, long>? values)
        {
            this.Avg = avg;
            this.Comments = comments;
            this.ContainsThreadFeedback = containsThreadFeedback;
            this.Errors = errors;
            this.Max = max;
            this.Min = min;
            this.N = n;
            this.Sources = sources;
            this.Stdev = stdev;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunFeedbackStat" /> class.
        /// </summary>
        public QueryRunFeedbackStat()
        {
        }

    }
}