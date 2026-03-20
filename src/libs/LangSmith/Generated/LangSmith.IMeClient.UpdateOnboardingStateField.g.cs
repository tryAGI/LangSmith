#nullable enable

namespace LangSmith
{
    public partial interface IMeClient
    {

        /// <summary>
        /// Update Onboarding State Field<br/>
        /// Update a specific onboarding completion field for the current user.<br/>
        /// Valid fields:<br/>
        /// - tracing_completed_at<br/>
        /// - lgstudio_completed_at<br/>
        /// - playground_completed_at<br/>
        /// - evaluation_completed_at<br/>
        /// - success_viewed_at
        /// </summary>
        /// <param name="field"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UserOnboardingStateResponse> UpdateOnboardingStateFieldAsync(
            string field,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}