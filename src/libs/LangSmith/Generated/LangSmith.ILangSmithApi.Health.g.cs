#nullable enable

namespace LangSmith
{
    public partial interface ILangSmithApi
    {
        /// <summary>
        /// Health
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> HealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}