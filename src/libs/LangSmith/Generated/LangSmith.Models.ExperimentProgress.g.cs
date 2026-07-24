
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpectedRunCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RunProgress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> EvaluatorProgress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentProgress" /> class.
        /// </summary>
        /// <param name="expectedRunCount"></param>
        /// <param name="runProgress"></param>
        /// <param name="evaluatorProgress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentProgress(
            int expectedRunCount,
            double runProgress,
            global::System.Collections.Generic.Dictionary<string, double> evaluatorProgress)
        {
            this.ExpectedRunCount = expectedRunCount;
            this.RunProgress = runProgress;
            this.EvaluatorProgress = evaluatorProgress ?? throw new global::System.ArgumentNullException(nameof(evaluatorProgress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentProgress" /> class.
        /// </summary>
        public ExperimentProgress()
        {
        }

    }
}