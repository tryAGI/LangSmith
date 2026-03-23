#nullable enable

namespace LangSmith
{
    public partial interface IFeaturesClient
    {
        /// <summary>
        /// Disable a model for a feature<br/>
        /// Adds a model to the disabled list for a feature in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DisableAModelForAFeatureAsync(

            global::LangSmith.FeaturesDisableModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disable a model for a feature<br/>
        /// Adds a model to the disabled list for a feature in the workspace.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DisableAModelForAFeatureAsync(
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}