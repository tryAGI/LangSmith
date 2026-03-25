#nullable enable

namespace LangSmith
{
    public partial interface IForgeConfigurationsClient
    {
        /// <summary>
        /// Trigger a forge configuration run<br/>
        /// Enqueues an immediate forge agent run for the given configuration.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task TriggerAForgeConfigurationRunAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}