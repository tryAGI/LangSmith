#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetAsync(
            global::LangSmith.DatasetCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Dataset<br/>
        /// Create a new dataset.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="inputsSchemaDefinition"></param>
        /// <param name="outputsSchemaDefinition"></param>
        /// <param name="externallyManaged">
        /// Default Value: false
        /// </param>
        /// <param name="id"></param>
        /// <param name="extra"></param>
        /// <param name="dataType">
        /// Enum for dataset data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Dataset> CreateDatasetAsync(
            string name,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.DateTime? createdAt = default,
            global::LangSmith.AnyOf<object, object>? inputsSchemaDefinition = default,
            global::LangSmith.AnyOf<object, object>? outputsSchemaDefinition = default,
            global::LangSmith.AnyOf<bool?, object>? externallyManaged = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? id = default,
            global::LangSmith.AnyOf<object, object>? extra = default,
            global::LangSmith.DataType? dataType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}