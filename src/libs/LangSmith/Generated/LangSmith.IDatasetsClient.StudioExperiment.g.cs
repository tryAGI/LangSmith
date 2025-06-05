#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Studio Experiment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StudioExperimentAsync(
            global::LangSmith.StudioRunOverDatasetRequestSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Studio Experiment
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="evaluatorRules"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StudioExperimentAsync(
            string projectName,
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid>? evaluatorRules = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}