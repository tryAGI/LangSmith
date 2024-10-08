#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Count Shared Examples<br/>
        /// Count all examples by query params
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<int> CountSharedExamplesAsync(
            global::System.Guid shareToken,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::LangSmith.AnyOf<string, object>? metadata = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}