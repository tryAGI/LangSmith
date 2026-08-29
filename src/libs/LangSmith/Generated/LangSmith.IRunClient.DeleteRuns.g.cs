#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Delete Runs<br/>
        /// DELETE with body payload — removes the runs identified by the request payload.<br/>
        /// Delete runs by trace ID, or every run in a time range.<br/>
        /// Supply `session_id` and `trace_ids` to delete a known list of traces, or<br/>
        /// `metadata` with `start_time` to delete matching traces from that time<br/>
        /// onward. Add `end_time` to bound the range; with both bounds set `metadata`<br/>
        /// is optional, and omitting it deletes every trace that started in the range.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(

            global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Runs<br/>
        /// DELETE with body payload — removes the runs identified by the request payload.<br/>
        /// Delete runs by trace ID, or every run in a time range.<br/>
        /// Supply `session_id` and `trace_ids` to delete a known list of traces, or<br/>
        /// `metadata` with `start_time` to delete matching traces from that time<br/>
        /// onward. Add `end_time` to bound the range; with both bounds set `metadata`<br/>
        /// is optional, and omitting it deletes every trace that started in the range.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> DeleteRunsAsResponseAsync(

            global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Runs<br/>
        /// DELETE with body payload — removes the runs identified by the request payload.<br/>
        /// Delete runs by trace ID, or every run in a time range.<br/>
        /// Supply `session_id` and `trace_ids` to delete a known list of traces, or<br/>
        /// `metadata` with `start_time` to delete matching traces from that time<br/>
        /// onward. Add `end_time` to bound the range; with both bounds set `metadata`<br/>
        /// is optional, and omitting it deletes every trace that started in the range.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        /// <param name="metadata"></param>
        /// <param name="deleteExamples">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(
            global::System.Guid? sessionId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? traceIds = default,
            object? metadata = default,
            bool? deleteExamples = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}