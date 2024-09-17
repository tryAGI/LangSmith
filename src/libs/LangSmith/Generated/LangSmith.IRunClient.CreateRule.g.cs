#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> CreateRuleAsync(
            global::LangSmith.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Rule<br/>
        /// Create a new run rule.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="sessionId"></param>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="samplingRate"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="useCorrectionsDataset">
        /// Default Value: false
        /// </param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="extendOnly">
        /// Default Value: false
        /// </param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetPreferCorrection">
        /// Default Value: false
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> CreateRuleAsync(
            string displayName,
            double samplingRate,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId = default,
            bool? isEnabled = true,
            global::LangSmith.AnyOf<global::System.Guid?, object>? datasetId = default,
            global::LangSmith.AnyOf<string, object>? filter = default,
            global::LangSmith.AnyOf<string, object>? traceFilter = default,
            global::LangSmith.AnyOf<string, object>? treeFilter = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? backfillFrom = default,
            bool? useCorrectionsDataset = false,
            global::LangSmith.AnyOf<int?, object>? numFewShotExamples = default,
            bool? extendOnly = false,
            global::LangSmith.AnyOf<global::System.Guid?, object>? addToAnnotationQueueId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? addToDatasetId = default,
            bool? addToDatasetPreferCorrection = false,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>, object>? evaluators = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>, object>? codeEvaluators = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>, object>? alerts = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>, object>? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}