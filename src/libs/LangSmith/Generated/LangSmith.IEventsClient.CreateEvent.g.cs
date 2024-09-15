#nullable enable

namespace LangSmith
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Create Event
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateEventApiV1EventsPostResponse> CreateEventAsync(
            global::LangSmith.CreateEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Event
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateEventApiV1EventsPostResponse> CreateEventAsync(
            global::LangSmith.CreateEventRequestEventType eventType,
            string owner,
            string repo,
            global::LangSmith.AnyOf<string, object>? commit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}