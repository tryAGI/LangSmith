#nullable enable

namespace LangSmith
{
    public partial interface IAuditLogsClient
    {

        /// <summary>
        /// Get Audit Logs<br/>
        /// Retrieve audit log records for the authenticated user's organization in OCSF format.<br/>
        /// Requires both start_time and end_time parameters to filter logs within a date range.<br/>
        /// Supports cursor-based pagination.<br/>
        /// Returns results in OCSF API Activity (Class UID: 6003) format,<br/>
        /// which is compatible with security monitoring and SIEM tools.<br/>
        /// Reference: https://schema.ocsf.io/1.7.0/classes/api_activity
        /// </summary>
        /// <param name="limit">
        /// Number of items to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded JSON string)
        /// </param>
        /// <param name="workspaceId">
        /// Filter by workspace ID
        /// </param>
        /// <param name="startTime">
        /// Start datetime (inclusive) in ISO 8601 format
        /// </param>
        /// <param name="endTime">
        /// End datetime (inclusive) in ISO 8601 format
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListAuditLogsOCSFResponse> GetAuditLogsAsync(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int? limit = default,
            string? cursor = default,
            global::System.Guid? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}