#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::LangSmith.DatasetUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="patchExamples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? name = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description = default,
            global::LangSmith.AnyOf<global::LangSmith.DatasetUpdateInputsSchemaDefinition, global::LangSmith.Missing, object>? inputsSchemaDefinition = default,
            global::LangSmith.AnyOf<global::LangSmith.DatasetUpdateOutputsSchemaDefinition, global::LangSmith.Missing, object>? outputsSchemaDefinition = default,
            global::LangSmith.AnyOf<global::LangSmith.DatasetUpdatePatchExamples, object>? patchExamples = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}