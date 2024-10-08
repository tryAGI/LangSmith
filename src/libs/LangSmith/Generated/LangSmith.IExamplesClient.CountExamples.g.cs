#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Count Examples<br/>
        /// Count all examples by query params
        /// </summary>
        /// <param name="id"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="fullTextContains"></param>
        /// <param name="splits"></param>
        /// <param name="dataset"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<int> CountExamplesAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<global::System.DateTime?, string>? asOf = default,
            global::LangSmith.AnyOf<string, object>? metadata = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? fullTextContains = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? splits = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? dataset = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}