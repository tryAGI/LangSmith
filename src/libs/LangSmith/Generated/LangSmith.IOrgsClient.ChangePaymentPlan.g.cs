#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Change Payment Plan
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChangePaymentPlanAsync(
            global::LangSmith.ChangePaymentPlanSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change Payment Plan
        /// </summary>
        /// <param name="tier">
        /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChangePaymentPlanAsync(
            global::LangSmith.ChangePaymentPlanReq tier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}