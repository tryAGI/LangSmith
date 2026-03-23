#nullable enable

namespace LangSmith
{
    public partial interface IFeaturesClient
    {
        /// <summary>
        /// List feature configurations<br/>
        /// Returns a consolidated view of default models and disabled models per feature for the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>> ListFeatureConfigurationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}