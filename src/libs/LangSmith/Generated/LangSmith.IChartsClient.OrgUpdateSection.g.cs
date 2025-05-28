#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> OrgUpdateSectionAsync(
            global::System.Guid sectionId,
            global::LangSmith.CustomChartsSectionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> OrgUpdateSectionAsync(
            global::System.Guid sectionId,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing> index,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}