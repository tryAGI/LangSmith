#nullable enable

namespace LangSmith
{
    public partial interface ILangSmithApi
    {
        /// <summary>
        /// Ok
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OkApiV1OkGetResponse> OkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}