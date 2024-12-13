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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>> ListRulesAsync(
            global::System.Guid? datasetId = default,
            global::System.Guid? sessionId = default,
            global::LangSmith.ListRulesApiV1RunsRulesGetType? type = default,
            string? nameContains = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}