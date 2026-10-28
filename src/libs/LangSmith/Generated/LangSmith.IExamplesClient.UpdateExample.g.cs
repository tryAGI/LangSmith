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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,

            global::LangSmith.ExampleUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> UpdateExampleAsResponseAsync(
            global::System.Guid exampleId,

            global::LangSmith.ExampleUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId">
        /// The example's current dataset. An example can't move to another dataset.
        /// </param>
        /// <param name="inputs">
        /// New inputs. Replaces the existing inputs; omit to keep them.
        /// </param>
        /// <param name="outputs">
        /// New outputs. Replaces the existing outputs; omit to keep them.
        /// </param>
        /// <param name="attachmentsOperations">
        /// Attachments to rename or keep.
        /// </param>
        /// <param name="metadata">
        /// New metadata. Replaces the existing metadata; omit to keep it.
        /// </param>
        /// <param name="split">
        /// Split or splits to put the example in. Replaces its current splits.
        /// </param>
        /// <param name="overwrite">
        /// Not used.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::System.Guid? datasetId = default,
            object? inputs = default,
            object? outputs = default,
            global::LangSmith.AttachmentsOperations? attachmentsOperations = default,
            object? metadata = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? split = default,
            bool? overwrite = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}