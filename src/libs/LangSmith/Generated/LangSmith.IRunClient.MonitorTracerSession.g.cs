#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.MonitorResponse> MonitorTracerSessionAsync(
            global::LangSmith.MonitorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="interval">
        /// Timedelta input.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.MonitorResponse> MonitorTracerSessionAsync(
            global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec> groups,
            string? timezone = "UTC",
            global::LangSmith.TimedeltaInput? stride = default,
            global::LangSmith.TimedeltaInput? interval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}