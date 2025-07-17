#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Update Rule<br/>
        /// Update a run rule.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> UpdateRuleAsync(
            global::System.Guid ruleId,
            global::LangSmith.RunRulesCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Rule<br/>
        /// Update a run rule.
        /// </summary>
        /// <param name="ruleId"></param>
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
        /// <param name="transient">
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
        /// <param name="evaluatorVersion"></param>
        /// <param name="createAlignmentQueue">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RunRulesSchema> UpdateRuleAsync(
            global::System.Guid ruleId,
            string displayName,
            double samplingRate,
            global::System.Guid? sessionId = default,
            bool? isEnabled = default,
            global::System.Guid? datasetId = default,
            string? filter = default,
            string? traceFilter = default,
            string? treeFilter = default,
            global::System.DateTime? backfillFrom = default,
            bool? useCorrectionsDataset = default,
            int? numFewShotExamples = default,
            bool? extendOnly = default,
            bool? transient = default,
            global::System.Guid? addToAnnotationQueueId = default,
            global::System.Guid? addToDatasetId = default,
            bool? addToDatasetPreferCorrection = default,
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? evaluators = default,
            global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? codeEvaluators = default,
            global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? alerts = default,
            global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? webhooks = default,
            int? evaluatorVersion = default,
            bool? createAlignmentQueue = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}