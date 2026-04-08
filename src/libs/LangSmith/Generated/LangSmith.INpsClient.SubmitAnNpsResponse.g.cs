#nullable enable

namespace LangSmith
{
    public partial interface INpsClient
    {
        /// <summary>
        /// Submit an NPS response<br/>
        /// Records the authenticated user's NPS score and optional comment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitAnNpsResponseAsync(

            global::LangSmith.NpsSubmitResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an NPS response<br/>
        /// Records the authenticated user's NPS score and optional comment.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="score"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitAnNpsResponseAsync(
            string? comment = default,
            int? score = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}