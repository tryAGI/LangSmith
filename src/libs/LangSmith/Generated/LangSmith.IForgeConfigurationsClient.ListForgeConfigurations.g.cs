#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// List forge configurations<br/>
        /// Returns all Forge configurations for the current workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ForgeConfigurationsForgeConfiguration>> ListForgeConfigurationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}