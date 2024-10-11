#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentResultsUploadResult> UploadExperimentAsync(
            global::LangSmith.ExperimentResultsUpload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentDescription"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetDescription"></param>
        /// <param name="summaryExperimentScores"></param>
        /// <param name="results"></param>
        /// <param name="experimentStartTime"></param>
        /// <param name="experimentEndTime"></param>
        /// <param name="experimentMetadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentResultsUploadResult> UploadExperimentAsync(
            string experimentName,
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow> results,
            global::System.DateTime experimentStartTime,
            global::System.DateTime experimentEndTime,
            global::LangSmith.AnyOf<string, object>? experimentDescription = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::LangSmith.AnyOf<string, object>? datasetName = default,
            global::LangSmith.AnyOf<string, object>? datasetDescription = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>, object>? summaryExperimentScores = default,
            global::LangSmith.AnyOf<object, object>? experimentMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}