#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Upload Examples From Csv<br/>
        /// Upload examples from a CSV file.<br/>
        /// Note: For non-csv upload, please use<br/>
        /// the POST /v1/platform/datasets/{dataset_id}/examples endpoint which provides more efficient upload.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> UploadExamplesFromCsvAsync(
            global::System.Guid datasetId,
            global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Examples From Csv<br/>
        /// Upload examples from a CSV file.<br/>
        /// Note: For non-csv upload, please use<br/>
        /// the POST /v1/platform/datasets/{dataset_id}/examples endpoint which provides more efficient upload.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Example>> UploadExamplesFromCsvAsync(
            global::System.Guid datasetId,
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.Collections.Generic.IList<string>? outputKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}