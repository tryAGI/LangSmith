#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Organization Roles
        /// </summary>
        /// <param name="sortBy">
        /// Fields to sort by, applied in the order supplied within existing scope and built-in role priorities. Repeat this parameter for multiple fields. Omit to preserve the default ordering.
        /// </param>
        /// <param name="sortOrder">
        /// Sort directions corresponding positionally to sort_by fields. Supply one direction for all fields, or repeat this parameter once per field. Omit to sort all requested fields ascending. Ignored when sort_by is omitted. Scope and built-in role priorities are unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.Role>> ListOrganizationRolesAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? sortBy = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Organization Roles
        /// </summary>
        /// <param name="sortBy">
        /// Fields to sort by, applied in the order supplied within existing scope and built-in role priorities. Repeat this parameter for multiple fields. Omit to preserve the default ordering.
        /// </param>
        /// <param name="sortOrder">
        /// Sort directions corresponding positionally to sort_by fields. Supply one direction for all fields, or repeat this parameter once per field. Omit to sort all requested fields ascending. Ignored when sort_by is omitted. Scope and built-in role priorities are unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.Role>>> ListOrganizationRolesAsResponseAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? sortBy = default,
            global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? sortOrder = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}