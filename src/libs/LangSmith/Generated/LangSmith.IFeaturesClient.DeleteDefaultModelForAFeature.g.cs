#nullable enable

namespace LangSmith
{
    public partial interface IFeaturesClient
    {
        /// <summary>
        /// Delete default model for a feature<br/>
        /// Removes the default model for a feature in the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDefaultModelForAFeatureAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}