#nullable enable

namespace LangSmith
{
    public partial interface IFeaturesClient
    {
        /// <summary>
        /// Set default model for a feature<br/>
        /// Sets or replaces the default model for a feature in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task SetDefaultModelForAFeatureAsync(

            global::LangSmith.FeaturesUpsertDefaultModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set default model for a feature<br/>
        /// Sets or replaces the default model for a feature in the workspace.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetDefaultModelForAFeatureAsync(
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}