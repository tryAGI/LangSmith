#nullable enable

namespace LangSmith
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Create Sub Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Comment> CreateSubCommentAsync(
            string owner,
            string repo,
            global::System.Guid parentCommentId,
            global::LangSmith.CreateCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Sub Comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="parentCommentId"></param>
        /// <param name="content"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Comment> CreateSubCommentAsync(
            string owner,
            string repo,
            global::System.Guid parentCommentId,
            string content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}