#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationPGSchemaSlim> CreateOrganizationAsync(
            global::LangSmith.OrganizationCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Organization
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationPGSchemaSlim> CreateOrganizationAsync(
            string displayName,
            bool isPersonal,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}