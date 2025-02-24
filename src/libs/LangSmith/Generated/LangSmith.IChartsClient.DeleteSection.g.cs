#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Delete Section<br/>
        /// Delete a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSectionAsync(
            global::System.Guid sectionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}