#nullable enable

namespace LangSmith
{
    public partial interface ITtlSettingsClient
    {
        /// <summary>
        /// Upsert Ttl Settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TTLSettings> UpsertTtlSettingsAsync(
            global::LangSmith.UpsertTTLSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert Ttl Settings
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="defaultTraceTier"></param>
        /// <param name="applyToAllProjects">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TTLSettings> UpsertTtlSettingsAsync(
            global::LangSmith.TraceTier defaultTraceTier,
            global::System.Guid? tenantId = default,
            bool? applyToAllProjects = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}