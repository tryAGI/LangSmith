#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Example> CreateExampleAsync(
            global::LangSmith.ExampleCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Example<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="datasetId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="metadata"></param>
        /// <param name="inputs"></param>
        /// <param name="split">
        /// Default Value: base
        /// </param>
        /// <param name="id"></param>
        /// <param name="useSourceRunIo">
        /// Default Value: false
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Example> CreateExampleAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<object, object>? outputs = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sourceRunId = default,
            global::LangSmith.AnyOf<object, object>? metadata = default,
            global::LangSmith.AnyOf<object, object>? inputs = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? id = default,
            bool? useSourceRunIo = false,
            global::System.DateTime? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}