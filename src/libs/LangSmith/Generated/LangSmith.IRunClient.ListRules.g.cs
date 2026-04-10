#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// List Rules<br/>
        /// List all run rules.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="type"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="includeBackfillProgress">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>> ListRulesAsync(
            global::System.Guid? datasetId = default,
            global::System.Guid? sessionId = default,
            global::LangSmith.ListRulesApiV1RunsRulesGetType2? type = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Guid? evaluatorId = default,
            bool? includeBackfillProgress = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}