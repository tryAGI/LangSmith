#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Create Insights Job<br/>
        /// Create an insights job.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRunClusteringJobResponse> [Beta]CreateInsightsJobAsync(
            global::System.Guid sessionId,

            global::LangSmith.CreateRunClusteringJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// [Beta] Create Insights Job<br/>
        /// Create an insights job.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="configId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="lastNHours"></param>
        /// <param name="hierarchy"></param>
        /// <param name="partitions"></param>
        /// <param name="sample"></param>
        /// <param name="summaryPrompt"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="attributeSchemas"></param>
        /// <param name="userContext"></param>
        /// <param name="model">
        /// Default Value: openai
        /// </param>
        /// <param name="clusterModel"></param>
        /// <param name="summaryModel"></param>
        /// <param name="validateModelSecrets">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRunClusteringJobResponse> [Beta]CreateInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid? configId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? lastNHours = default,
            global::System.Collections.Generic.IList<int>? hierarchy = default,
            global::System.Collections.Generic.Dictionary<string, string>? partitions = default,
            global::LangSmith.AnyOf<double?, int?, object>? sample = default,
            string? summaryPrompt = default,
            string? filter = default,
            string? name = default,
            object? attributeSchemas = default,
            global::System.Collections.Generic.Dictionary<string, string>? userContext = default,
            global::LangSmith.CreateRunClusteringJobRequestModel? model = default,
            string? clusterModel = default,
            string? summaryModel = default,
            bool? validateModelSecrets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}