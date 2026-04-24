#nullable enable

namespace LangSmith
{
    public partial interface IExperimentViewOverridesClient
    {
        /// <summary>
        /// Delete experiment view override configuration<br/>
        /// Permanently deletes an experiment view override configuration for a dataset.<br/>
        /// This operation removes all column override settings including color gradients,<br/>
        /// precision configurations, and visibility settings.<br/>
        /// After deletion, the experiment view will revert to default column display settings.<br/>
        /// This action cannot be undone - you will need to recreate the override configuration<br/>
        /// if you want to restore custom column settings.<br/>
        /// Both the dataset and override must exist and be accessible by the authenticated user.<br/>
        /// The operation will fail if the override doesn't exist or if the user doesn't have<br/>
        /// appropriate permissions for the dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentViewOverrideConfigurationAsync(
            global::System.Guid datasetId,
            global::System.Guid id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}