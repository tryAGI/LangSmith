#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Create Decision Model Rule<br/>
        /// Create a decision-model evaluator (Jev, SemIf or OpenAI Decisions) from<br/>
        /// its prompt and questions, and attach it to a project or dataset. Each<br/>
        /// question's key becomes a feedback key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> CreateDecisionModelRuleAsync(

            global::LangSmith.DecisionModelRuleCreateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Decision Model Rule<br/>
        /// Create a decision-model evaluator (Jev, SemIf or OpenAI Decisions) from<br/>
        /// its prompt and questions, and attach it to a project or dataset. Each<br/>
        /// question's key becomes a feedback key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.RunRulesSchema>> CreateDecisionModelRuleAsResponseAsync(

            global::LangSmith.DecisionModelRuleCreateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Decision Model Rule<br/>
        /// Create a decision-model evaluator (Jev, SemIf or OpenAI Decisions) from<br/>
        /// its prompt and questions, and attach it to a project or dataset. Each<br/>
        /// question's key becomes a feedback key.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="sessionId">
        /// The tracing project to evaluate.
        /// </param>
        /// <param name="datasetId">
        /// The dataset whose experiments to evaluate.
        /// </param>
        /// <param name="prompt">
        /// The prompt the model reads, as (role, template) pairs.
        /// </param>
        /// <param name="templateFormat">
        /// Default Value: mustache
        /// </param>
        /// <param name="variableMapping">
        /// Maps the prompt's variables to run fields.
        /// </param>
        /// <param name="questions">
        /// The questions, keyed by feedback key, in the order to ask them.
        /// </param>
        /// <param name="provider">
        /// typesafe for Jev and SemIf, typesafe_compatible for a TypeSafe-compatible endpoint, or openai_decisions.<br/>
        /// Default Value: typesafe
        /// </param>
        /// <param name="model">
        /// Defaults to jev-latest for typesafe and gpt-6-luna for openai_decisions. Use semif-qwen3.5-4b for SemIf.
        /// </param>
        /// <param name="baseUrl">
        /// Call this endpoint directly instead of through the LangSmith gateway, with the workspace's TYPESAFE_API_KEY or OPENAI_API_KEY secret. Required for typesafe_compatible.
        /// </param>
        /// <param name="modelHeaders">
        /// Headers sent with each model call. They are saved in the evaluator's prompt as given, so do not put API keys here.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Seconds to wait for each model call. openai_decisions only.
        /// </param>
        /// <param name="maxRetries">
        /// How many times to retry a failed model call. openai_decisions only.
        /// </param>
        /// <param name="playgroundSettingsId">
        /// A saved model configuration to start from: its model, endpoint, key and settings apply unless set here.
        /// </param>
        /// <param name="samplingRate">
        /// The fraction of runs to evaluate.<br/>
        /// Default Value: 1F
        /// </param>
        /// <param name="filter">
        /// Only evaluate runs that match this filter.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> CreateDecisionModelRuleAsync(
            string displayName,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> prompt,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion> questions,
            global::System.Guid? sessionId = default,
            global::System.Guid? datasetId = default,
            global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? templateFormat = default,
            global::System.Collections.Generic.Dictionary<string, string>? variableMapping = default,
            global::LangSmith.DecisionModelRuleCreateSchemaProvider? provider = default,
            string? model = default,
            string? baseUrl = default,
            global::System.Collections.Generic.Dictionary<string, string>? modelHeaders = default,
            int? timeoutSeconds = default,
            int? maxRetries = default,
            global::System.Guid? playgroundSettingsId = default,
            double? samplingRate = default,
            string? filter = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}