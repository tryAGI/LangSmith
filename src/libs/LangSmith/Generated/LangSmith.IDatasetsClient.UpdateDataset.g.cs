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
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::LangSmith.DatasetUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Dataset<br/>
        /// Update a specific dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples"></param>
        /// <param name="transformations">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="baselineExperimentId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? name = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? inputsSchemaDefinition = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? outputsSchemaDefinition = default,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? patchExamples = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? transformations = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata = default,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? baselineExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}