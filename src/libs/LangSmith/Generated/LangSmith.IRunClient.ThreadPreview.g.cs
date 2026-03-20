#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Thread Preview<br/>
        /// Get preview of a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="sessionId"></param>
        /// <param name="select"></param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadPreviewResponse> ThreadPreviewAsync(
            string threadId,
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>? select = default,
            global::System.Collections.Generic.IList<string>? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}