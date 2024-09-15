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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>> ListRulesAsync(
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::LangSmith.AnyOf<global::LangSmith.ListRulesApiV1RunsRulesGetType2?, object>? type = default,
            global::LangSmith.AnyOf<string, object>? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}