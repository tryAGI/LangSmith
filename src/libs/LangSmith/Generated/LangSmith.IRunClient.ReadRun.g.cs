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
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="excludeSerialized">
        /// Default Value: false
        /// </param>
        /// <param name="excludeChildRunIds">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunSchema> ReadRunAsync(
            global::System.Guid runId,
            global::System.Guid? sessionId = default,
            global::System.DateTime? startTime = default,
            bool? excludeS3StoredAttributes = default,
            bool? excludeSerialized = default,
            bool? excludeChildRunIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}