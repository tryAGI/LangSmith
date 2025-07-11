#nullable enable

namespace LangSmith
{
    public partial interface IExperimentViewOverridesClient
    {
        /// <summary>
        /// Get experiment view override configuration for a dataset<br/>
        /// Retrieves the experiment view override configuration for a specific dataset.<br/>
        /// This endpoint returns column display overrides including color gradients,<br/>
        /// precision settings, and column visibility configurations that customize how<br/>
        /// experiment results are displayed in the UI.<br/>
        /// The response includes all column overrides with their display settings:<br/>
        /// - Column identifiers (must start with inputs, outputs, reference_outputs, feedback, metrics, attachments, or metadata)<br/>
        /// - Color gradients for numeric data visualization<br/>
        /// - Precision settings for numeric columns (1-6 decimal places)<br/>
        /// - Hide flags to control column visibility
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> GetExperimentViewOverrideConfigurationForADatasetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}