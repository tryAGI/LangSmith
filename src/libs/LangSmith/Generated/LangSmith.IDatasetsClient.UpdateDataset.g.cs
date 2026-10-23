#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Update Dataset<br/>
        /// Update a dataset.<br/>
        /// Only the fields in the request change; omitted fields keep their value.<br/>
        /// Setting a schema or transformations checks every existing example against<br/>
        /// the result. Returns 400, leaving the dataset unchanged, if an example does<br/>
        /// not match, the dataset is not a key-value dataset, or a transformation<br/>
        /// points into inputs or outputs that have no schema. The<br/>
        /// X-Updated-Examples-Count response header holds the number of examples<br/>
        /// changed through patch_examples. Returns 404 if the dataset does not exist<br/>
        /// and 409 if the new name is already used.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DatasetSchemaForUpdate> UpdateDatasetAsync(
            global::System.Guid datasetId,

            global::LangSmith.DatasetUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset<br/>
        /// Update a dataset.<br/>
        /// Only the fields in the request change; omitted fields keep their value.<br/>
        /// Setting a schema or transformations checks every existing example against<br/>
        /// the result. Returns 400, leaving the dataset unchanged, if an example does<br/>
        /// not match, the dataset is not a key-value dataset, or a transformation<br/>
        /// points into inputs or outputs that have no schema. The<br/>
        /// X-Updated-Examples-Count response header holds the number of examples<br/>
        /// changed through patch_examples. Returns 404 if the dataset does not exist<br/>
        /// and 409 if the new name is already used.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DatasetSchemaForUpdate>> UpdateDatasetAsResponseAsync(
            global::System.Guid datasetId,

            global::LangSmith.DatasetUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dataset<br/>
        /// Update a dataset.<br/>
        /// Only the fields in the request change; omitted fields keep their value.<br/>
        /// Setting a schema or transformations checks every existing example against<br/>
        /// the result. Returns 400, leaving the dataset unchanged, if an example does<br/>
        /// not match, the dataset is not a key-value dataset, or a transformation<br/>
        /// points into inputs or outputs that have no schema. The<br/>
        /// X-Updated-Examples-Count response header holds the number of examples<br/>
        /// changed through patch_examples. Returns 404 if the dataset does not exist<br/>
        /// and 409 if the new name is already used.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name">
        /// New dataset name. Must be unique in the workspace; a name already used by another dataset returns 409. Null returns 400. Omit to keep the current name.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// New dataset description. Null clears it. Omit to keep the current description.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="inputsSchemaDefinition">
        /// JSON Schema that example inputs must match. Replaces the current inputs schema as a whole; null removes it, which returns 400 while transformations still point into inputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="outputsSchemaDefinition">
        /// JSON Schema that example outputs must match. Replaces the current outputs schema as a whole; null removes it, which returns 400 while transformations still point into outputs. Only key-value datasets support schemas. Every existing example must match the new schema, otherwise the request returns 400 with the IDs of the examples that do not, and nothing is changed. Omit to keep the current schema.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="patchExamples">
        /// Example updates keyed by example ID, applied in the same transaction so existing examples can be fixed to match a new schema. Only used when the request also sets inputs_schema_definition, outputs_schema_definition, or transformations and the dataset ends up with at least one schema; otherwise it is ignored. Each update replaces the inputs, outputs, metadata, or split it sets and keeps the rest; attachment operations are ignored. An ID that is not an example in this dataset returns 404.
        /// </param>
        /// <param name="transformations">
        /// Transformations applied to new examples, each a path into inputs or outputs and a transformation type. Replaces the whole current list; null or an empty list removes all of them. Existing examples are not transformed. Requires a schema on the inputs or outputs the path points into, otherwise returns 400. Omit to keep the current list.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Dataset metadata as a JSON object. Replaces the current metadata as a whole; keys are not merged. Send an empty object to clear it. Omit to keep the current metadata.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="baselineExperimentId">
        /// ID of the experiment used as the baseline when comparing experiments on this dataset. Must be an experiment run on this dataset, otherwise returns 400. Null clears it. Omit to keep the current baseline.<br/>
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}