#nullable enable

namespace LangSmith
{
    public partial interface IFeaturesClient
    {
        /// <summary>
        /// Re-enable a disabled model for a feature<br/>
        /// Removes a model from the disabled list for a feature in the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task ReEnableADisabledModelForAFeatureAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}