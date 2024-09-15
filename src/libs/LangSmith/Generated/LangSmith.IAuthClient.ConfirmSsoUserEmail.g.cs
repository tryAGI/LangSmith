#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse> ConfirmSsoUserEmailAsync(
            global::LangSmith.SSOConfirmEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ConfirmSsoUserEmailApiV1SsoEmailVerificationConfirmPostResponse> ConfirmSsoUserEmailAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}