#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Sessions<br/>
        /// Get all sessions.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy">
        /// Default Value: start_time
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TracerSession>> ReadTracerSessionsAsync(
            global::LangSmith.AnyOf<bool?, object>? referenceFree = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceDataset = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::LangSmith.AnyOf<string, object>? nameContains = default,
            global::LangSmith.AnyOf<string, object>? datasetVersion = default,
            global::LangSmith.AllOf<global::LangSmith.SessionSortableColumns?>? sortBy = default,
            bool sortByDesc = true,
            global::LangSmith.AnyOf<string, object>? metadata = default,
            global::LangSmith.AnyOf<string, object>? sortByFeedbackKey = default,
            int offset = 0,
            int limit = 100,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            bool facets = false,
            global::LangSmith.AnyOf<string, object>? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}