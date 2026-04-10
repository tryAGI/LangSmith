#nullable enable

namespace LangSmith
{
    public partial interface IBackfillsClient
    {
        /// <summary>
        /// Restart a backfill job<br/>
        /// Deletes the backfill job record, causing the backfill to restart from the beginning on the next cron tick. Requires instance admin access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> RestartABackfillJobAsync(

            global::LangSmith.BackfillsRestartBackfillRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restart a backfill job<br/>
        /// Deletes the backfill job record, causing the backfill to restart from the beginning on the next cron tick. Requires instance admin access.
        /// </summary>
        /// <param name="backfillName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> RestartABackfillJobAsync(
            string? backfillName = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}