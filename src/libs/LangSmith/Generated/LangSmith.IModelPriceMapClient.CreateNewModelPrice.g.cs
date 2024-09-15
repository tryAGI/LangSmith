#nullable enable

namespace LangSmith
{
    public partial interface IModelPriceMapClient
    {
        /// <summary>
        /// Create New Model Price
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateNewModelPriceApiV1ModelPriceMapPostResponse> CreateNewModelPriceAsync(
            global::LangSmith.ModelPriceMapCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create New Model Price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startTime"></param>
        /// <param name="matchPath">
        /// Default Value: [model, model_name, model_id, model_path, endpoint_name]
        /// </param>
        /// <param name="matchPattern"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateNewModelPriceApiV1ModelPriceMapPostResponse> CreateNewModelPriceAsync(
            string name,
            string matchPattern,
            global::LangSmith.AnyOf<double?, string> promptCost,
            global::LangSmith.AnyOf<double?, string> completionCost,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::System.Collections.Generic.IList<string>? matchPath = default,
            global::LangSmith.AnyOf<string, object>? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}