#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// Update a forge configuration<br/>
        /// Updates an existing Forge configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ForgeConfigurationsForgeConfiguration> UpdateAForgeConfigurationAsync(

            global::LangSmith.ForgeConfigurationsUpdateForgeConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a forge configuration<br/>
        /// Updates an existing Forge configuration.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="gitCommitMetadataKey"></param>
        /// <param name="githubRepo"></param>
        /// <param name="scheduleCron"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ForgeConfigurationsForgeConfiguration> UpdateAForgeConfigurationAsync(
            bool? enabled = default,
            string? gitCommitMetadataKey = default,
            string? githubRepo = default,
            string? scheduleCron = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}