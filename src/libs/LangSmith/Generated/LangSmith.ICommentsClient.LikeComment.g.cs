#nullable enable

namespace LangSmith
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Like Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.LikeCommentApiV1CommentsOwnerRepoParentCommentIdLikePostResponse> LikeCommentAsync(
            string owner,
            string repo,
            global::System.Guid parentCommentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}