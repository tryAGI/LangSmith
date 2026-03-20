#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV or JSONL file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(

            global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV or JSONL file.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="inputKeys"></param>
        /// <param name="name"></param>
        /// <param name="dataType">
        /// Enum for dataset data types.<br/>
        /// Default Value: kv
        /// </param>
        /// <param name="outputKeys">
        /// Default Value: []
        /// </param>
        /// <param name="metadataKeys">
        /// Default Value: []
        /// </param>
        /// <param name="description"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="transformations"></param>
        /// <param name="inputKeyMappings"></param>
        /// <param name="outputKeyMappings"></param>
        /// <param name="metadataKeyMappings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> UploadCsvDatasetAsync(
            byte[] file,
            string filename,
            global::System.Collections.Generic.IList<string> inputKeys,
            string? name = default,
            global::LangSmith.DataType? dataType = default,
            global::System.Collections.Generic.IList<string>? outputKeys = default,
            global::System.Collections.Generic.IList<string>? metadataKeys = default,
            string? description = default,
            string? inputsSchemaDefinition = default,
            string? outputsSchemaDefinition = default,
            string? transformations = default,
            string? inputKeyMappings = default,
            string? outputKeyMappings = default,
            string? metadataKeyMappings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}