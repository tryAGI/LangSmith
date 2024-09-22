#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> ReadSingleSectionAsync(
            global::System.Guid sectionId,
            global::LangSmith.CustomChartsRequestBase request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> ReadSingleSectionAsync(
            global::System.Guid sectionId,
            global::System.DateTime startTime,
            string? timezone = "UTC",
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.TimedeltaInput? stride = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}