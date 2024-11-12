#nullable enable

namespace LangSmith
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Get Sub Comments
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListCommentsResponse> GetSubCommentsAsync(
            string owner,
            string repo,
            global::System.Guid parentCommentId,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}