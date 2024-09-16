#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Generate<br/>
        /// Generate synthetic examples for a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GenerateApiV1DatasetsDatasetIdGeneratePostResponse> GenerateAsync(
            global::System.Guid datasetId,
            global::LangSmith.GenerateSyntheticExamplesBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate<br/>
        /// Generate synthetic examples for a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="exampleIds"></param>
        /// <param name="numExamples"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GenerateApiV1DatasetsDatasetIdGeneratePostResponse> GenerateAsync(
            global::System.Guid datasetId,
            int numExamples,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? exampleIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}