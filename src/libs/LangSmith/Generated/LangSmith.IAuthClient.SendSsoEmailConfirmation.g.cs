#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Send Sso Email Confirmation<br/>
        /// Send an email to confirm the email address for an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> SendSsoEmailConfirmationAsync(
            global::LangSmith.SSOEmailVerificationSendRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Send Sso Email Confirmation<br/>
        /// Send an email to confirm the email address for an SSO user.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> SendSsoEmailConfirmationAsync(
            string email,
            global::System.Guid samlProviderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}