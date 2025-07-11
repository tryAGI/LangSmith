#nullable enable

namespace LangSmith
{
    public partial interface IExperimentViewOverridesClient
    {
        /// <summary>
        /// Get experiment view override configuration by specific ID<br/>
        /// Retrieves a specific experiment view override configuration using both dataset ID and override ID.<br/>
        /// This endpoint provides more precise access to experiment view overrides when you have<br/>
        /// the specific override ID, useful for direct links or cached references.<br/>
        /// The response includes the same column override information as the dataset-level endpoint:<br/>
        /// - Column identifiers with validation prefixes<br/>
        /// - Color gradient settings for numeric data visualization<br/>
        /// - Numeric precision configurations<br/>
        /// - Column visibility controls<br/>
        /// Both the dataset and override must exist and be accessible by the authenticated user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExperimentViewOverridesExperimentViewOverride> GetExperimentViewOverrideConfigurationBySpecificIDAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}