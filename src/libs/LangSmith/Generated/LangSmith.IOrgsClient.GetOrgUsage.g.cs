#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Org Usage
        /// </summary>
        /// <param name="startingOn"></param>
        /// <param name="endingBefore"></param>
        /// <param name="onCurrentPlan">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>> GetOrgUsageAsync(
            global::System.DateTime startingOn,
            global::System.DateTime endingBefore,
            bool? onCurrentPlan = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}