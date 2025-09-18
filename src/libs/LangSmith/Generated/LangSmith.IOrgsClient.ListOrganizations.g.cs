#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Organizations<br/>
        /// Get all orgs visible to this auth
        /// </summary>
        /// <param name="skipCreate">
        /// Default Value: false
        /// </param>
        /// <param name="includeTier">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>> ListOrganizationsAsync(
            bool? skipCreate = default,
            bool? includeTier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}