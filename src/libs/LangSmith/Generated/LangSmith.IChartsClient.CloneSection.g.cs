#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Clone Section<br/>
        /// Clone a dashboard.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CloneSectionAsync(
            global::LangSmith.CustomChartsSectionsCloneRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone Section<br/>
        /// Clone a dashboard.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> CloneSectionAsync(
            global::System.Guid? sectionId = default,
            global::System.Guid? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}