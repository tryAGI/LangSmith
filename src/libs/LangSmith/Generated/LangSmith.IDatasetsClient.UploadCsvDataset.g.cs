#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(
            global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="name"></param>
        /// <param name="dataType">
        /// Default Value: kv
        /// </param>
        /// <param name="outputKeys"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.DataType? dataType = global::LangSmith.DataType.Kv,
            global::System.Collections.Generic.IList<string>? outputKeys = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}