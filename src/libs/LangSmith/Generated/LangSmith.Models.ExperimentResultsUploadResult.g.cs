
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Class for uploading the results of an already-run experiment.
    /// </summary>
    public sealed partial class ExperimentResultsUploadResult
    {
        /// <summary>
        /// Dataset schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.Dataset Dataset { get; set; }

        /// <summary>
        /// TracerSession schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.TracerSession Experiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUploadResult" /> class.
        /// </summary>
        /// <param name="dataset">
        /// Dataset schema.
        /// </param>
        /// <param name="experiment">
        /// TracerSession schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentResultsUploadResult(
            global::LangSmith.Dataset dataset,
            global::LangSmith.TracerSession experiment)
        {
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Experiment = experiment ?? throw new global::System.ArgumentNullException(nameof(experiment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUploadResult" /> class.
        /// </summary>
        public ExperimentResultsUploadResult()
        {
        }
    }
}