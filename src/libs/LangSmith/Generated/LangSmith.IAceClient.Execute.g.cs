#nullable enable

namespace LangSmith
{
    public partial interface IAceClient
    {
        /// <summary>
        /// Execute<br/>
        /// Execute some custom code for testing purposes.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteAsync(
            global::LangSmith.BodyExecuteApiV1AceExecutePost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Execute<br/>
        /// Execute some custom code for testing purposes.
        /// </summary>
        /// <param name="args"></param>
        /// <param name="code"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExecuteAsync(
            global::System.Collections.Generic.IList<object> args,
            string code,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}