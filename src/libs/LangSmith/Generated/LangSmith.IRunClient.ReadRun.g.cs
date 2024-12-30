#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Read Run<br/>
        /// Get a specific run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="excludeSerialized">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunSchema> ReadRunAsync(
            global::System.Guid runId,
            bool? excludeS3StoredAttributes = default,
            bool? excludeSerialized = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}