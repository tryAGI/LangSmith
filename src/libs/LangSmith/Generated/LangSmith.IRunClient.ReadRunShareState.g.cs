#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Read Run Share State<br/>
        /// Get the state of sharing of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AnyOf<global::LangSmith.RunShareSchema, object>> ReadRunShareStateAsync(
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}