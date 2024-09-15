#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> CreateExamplesAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ExampleBulkCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}