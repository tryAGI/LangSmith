#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::LangSmith.PlaygroundSettingsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Playground Settings<br/>
        /// Update playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> UpdatePlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::LangSmith.AnyOf<string, object>? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}