#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// Delete a forge configuration<br/>
        /// Deletes a Forge configuration by ID.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAForgeConfigurationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}