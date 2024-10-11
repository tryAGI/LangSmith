#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::LangSmith.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateExampleApiV1ExamplesExampleIdPatchResponse> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::LangSmith.AnyOf<object, object>? inputs = default,
            global::LangSmith.AnyOf<object, object>? outputs = default,
            global::LangSmith.AnyOf<object, object>? metadata = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}