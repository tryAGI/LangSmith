#nullable enable

namespace LangSmith
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// [Beta] List issues<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Returns issues for the authenticated tenant, optionally filtered<br/>
        /// by session, status, severity, tag, linked trace, or last modified time.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="status"></param>
        /// <param name="severity"></param>
        /// <param name="severityExact"></param>
        /// <param name="activity"></param>
        /// <param name="tag"></param>
        /// <param name="traceId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sortBy"></param>
        /// <param name="statusFirst"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>> ListIssuesAsync(
            string? sessionId = default,
            string? sessionName = default,
            global::LangSmith.GetPlatformIssuesStatus? status = default,
            int? severity = default,
            global::System.Collections.Generic.IList<int>? severityExact = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? activity = default,
            string? tag = default,
            global::System.Guid? traceId = default,
            string? updatedAt = default,
            global::LangSmith.GetPlatformIssuesSortBy? sortBy = default,
            bool? statusFirst = default,
            int? limit = default,
            int? offset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [Beta] List issues<br/>
        /// **Beta:** This endpoint is in active development and may change without notice.<br/>
        /// Returns issues for the authenticated tenant, optionally filtered<br/>
        /// by session, status, severity, tag, linked trace, or last modified time.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="status"></param>
        /// <param name="severity"></param>
        /// <param name="severityExact"></param>
        /// <param name="activity"></param>
        /// <param name="tag"></param>
        /// <param name="traceId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sortBy"></param>
        /// <param name="statusFirst"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>>> ListIssuesAsResponseAsync(
            string? sessionId = default,
            string? sessionName = default,
            global::LangSmith.GetPlatformIssuesStatus? status = default,
            int? severity = default,
            global::System.Collections.Generic.IList<int>? severityExact = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? activity = default,
            string? tag = default,
            global::System.Guid? traceId = default,
            string? updatedAt = default,
            global::LangSmith.GetPlatformIssuesSortBy? sortBy = default,
            bool? statusFirst = default,
            int? limit = default,
            int? offset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}