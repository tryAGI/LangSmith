#nullable enable

namespace LangSmith
{
    public partial interface IMeClient
    {

        /// <summary>
        /// Create Onboarding State<br/>
        /// Initialize onboarding state for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserOnboardingStateResponse> CreateOnboardingStateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}