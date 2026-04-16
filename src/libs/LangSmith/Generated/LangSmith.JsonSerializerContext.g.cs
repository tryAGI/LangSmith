
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::LangSmith.JsonConverters.AccessScopeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AccessScopeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2JsonConverter),

            typeof(global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuditLogOperationJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuditLogOperationNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthProviderJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthProviderNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportCompressionNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportFormatJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportFormatNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportFormatVersionJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportFormatVersionNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportRunStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportUpdatableStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.BulkExportUpdatableStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ChangePaymentPlanReqJsonConverter),

            typeof(global::LangSmith.JsonConverters.ChangePaymentPlanReqNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.CodeEvaluatorLanguageJsonConverter),

            typeof(global::LangSmith.JsonConverters.CodeEvaluatorLanguageNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ConfiguredByJsonConverter),

            typeof(global::LangSmith.JsonConverters.ConfiguredByNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelJsonConverter),

            typeof(global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.CustomChartMetricJsonConverter),

            typeof(global::LangSmith.JsonConverters.CustomChartMetricNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.CustomChartTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.CustomChartTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.DataTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.DataTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.DatasetTransformationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptWebhookTriggerJsonConverter),

            typeof(global::LangSmith.JsonConverters.EPromptWebhookTriggerNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ExampleListOrderJsonConverter),

            typeof(global::LangSmith.JsonConverters.ExampleListOrderNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ExampleSelectJsonConverter),

            typeof(global::LangSmith.JsonConverters.ExampleSelectNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackLevelJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackLevelNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FilterViewTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.FilterViewTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelJsonConverter),

            typeof(global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetDatasetsSelectJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetDatasetsSelectNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GranularUsageGroupByJsonConverter),

            typeof(global::LangSmith.JsonConverters.GranularUsageGroupByNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GroupExampleRunsByFieldJsonConverter),

            typeof(global::LangSmith.JsonConverters.GroupExampleRunsByFieldNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.HostProjectChartMetricJsonConverter),

            typeof(global::LangSmith.JsonConverters.HostProjectChartMetricNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.MemberSortFieldJsonConverter),

            typeof(global::LangSmith.JsonConverters.MemberSortFieldNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.OCSFCategoryNameJsonConverter),

            typeof(global::LangSmith.JsonConverters.OCSFCategoryNameNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.OCSFClassNameJsonConverter),

            typeof(global::LangSmith.JsonConverters.OCSFClassNameNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeJsonConverter),

            typeof(global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.OrganizationDashboardTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.OrganizationDashboardTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter),

            typeof(global::LangSmith.JsonConverters.PagerdutySeverityNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter),

            typeof(global::LangSmith.JsonConverters.PaymentPlanTierNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2JsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2JsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ProvisioningMethodJsonConverter),

            typeof(global::LangSmith.JsonConverters.ProvisioningMethodNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ProxyRequestMethodJsonConverter),

            typeof(global::LangSmith.JsonConverters.ProxyRequestMethodNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionJsonConverter),

            typeof(global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ResourceTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.ResourceTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RuleLogActionOutcomeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RuleLogActionOutcomeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunDateOrderJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunDateOrderNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunGroupByJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunGroupByNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunRulesAlertTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunSelectJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunSelectNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupByAttributeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2JsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsSelectJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunStatsSelectNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunTypeEnumJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunnerContextEnumJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunnerContextEnumNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelJsonConverter),

            typeof(global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SessionSortableColumnsJsonConverter),

            typeof(global::LangSmith.JsonConverters.SessionSortableColumnsNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortByComparativeExperimentColumnJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortByDatasetColumnJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortByDatasetColumnNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter),

            typeof(global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SourceTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.SourceTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.TenantUsageLimitTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ThreadMessagesFormatTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.ThreadMessagesFormatTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ToolMessageStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.ToolMessageStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ToolMessageChunkStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.ToolMessageChunkStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.TraceTierJsonConverter),

            typeof(global::LangSmith.JsonConverters.TraceTierNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.TrueFalseLiteralJsonConverter),

            typeof(global::LangSmith.JsonConverters.TrueFalseLiteralNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.UsageLimitTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertActionTargetJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertActionTargetNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAggregationJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAggregationNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAttributeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleAttributeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleOperatorJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleOperatorNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalAbacOperatorJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalAbacOperatorNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalPermissionJsonConverter),

            typeof(global::LangSmith.JsonConverters.AuthzInternalPermissionNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.IntegrationsIntegrationTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.IntegrationsIntegrationTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusJsonConverter),

            typeof(global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsRunRunTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.RunsRunRunTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.SandboxesHeaderTypeJsonConverter),

            typeof(global::LangSmith.JsonConverters.SandboxesHeaderTypeNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2JsonConverter),

            typeof(global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2JsonConverter),

            typeof(global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2JsonConverter),

            typeof(global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2JsonConverter),

            typeof(global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceJsonConverter),

            typeof(global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceNullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2JsonConverter),

            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2NullableJsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackSourceVariant1JsonConverter),

            typeof(global::LangSmith.JsonConverters.FeedbackSourceVariant12JsonConverter),

            typeof(global::LangSmith.JsonConverters.EntitiesItemJsonConverter),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),

            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<object>, object, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>),

            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsResponse3>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsBatchResponse3>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchRunsResponse3>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreatePlatformAlertsTestResponse3>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.DeletePlatformAlertsResponse3>),

            typeof(global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchPlatformAlertsResponse3>),

            typeof(global::LangSmith.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, object>), TypeInfoPropertyName = "AnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InvalidToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AIMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope), TypeInfoPropertyName = "AccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRepoOwnerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRunToQueueByKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllowedLoginMethodsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueBulkDeleteRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRubricItemSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunAddSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AssignedReviewerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AssignedReviewerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaWithRubricQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaWithSizeQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSizeSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfInt32MissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Missing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ArtifactContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ArtifactContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AttachmentsOperations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogEnrichments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogOperation), TypeInfoPropertyName = "AuditLogOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider), TypeInfoPropertyName = "AuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AutoEvalFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthMemberCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthUserPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BatchIngestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyParamsForRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsFilterDataSourceTypeEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSelect), TypeInfoPropertyName = "RunSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunDateOrder), TypeInfoPropertyName = "RunDateOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyParamsForRunsQuerySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.DateTime?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyExecuteApiV1AceExecutePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataType), TypeInfoPropertyName = "DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormat), TypeInfoPropertyName = "BulkExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormatVersion), TypeInfoPropertyName = "BulkExportFormatVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCompression), TypeInfoPropertyName = "BulkExportCompression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportStatus), TypeInfoPropertyName = "BulkExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationType), TypeInfoPropertyName = "BulkExportDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationS3Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationS3Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunStatus), TypeInfoPropertyName = "BulkExportRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdatableStatus), TypeInfoPropertyName = "BulkExportUpdatableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanReq), TypeInfoPropertyName = "ChangePaymentPlanReq2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChatMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SavedRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorLanguage), TypeInfoPropertyName = "CodeEvaluatorLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitManifestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoExampleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SimpleExperimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ConfiguredBy), TypeInfoPropertyName = "ConfiguredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateCommentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateFeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestRepoType), TypeInfoPropertyName = "CreateRepoRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobRequestModel), TypeInfoPropertyName = "CreateRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartType), TypeInfoPropertyName = "CustomChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesFilters2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreatePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetric), TypeInfoPropertyName = "CustomChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HostProjectChartMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfStringMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfInt32Missing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfCustomChartTypeMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfIListCustomChartSeriesUpdateMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfGuidMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfCustomChartSeriesFilters2MissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, double?, object, object>), TypeInfoPropertyName = "AnyOfInt32DoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TimedeltaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartSubSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionsCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomerVisiblePlanInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PaymentPlanTier), TypeInfoPropertyName = "PaymentPlanTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetDiffInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetPublicSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetSchemaForUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformationType), TypeInfoPropertyName = "DatasetTransformationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfIListDatasetTransformationMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfGuidMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeleteClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeleteRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DemoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationAlgorithm), TypeInfoPropertyName = "EPromptOptimizationAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobLogType), TypeInfoPropertyName = "EPromptOptimizationJobLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobStatus), TypeInfoPropertyName = "EPromptOptimizationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptWebhookTrigger), TypeInfoPropertyName = "EPromptWebhookTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluateExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorStructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Example))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleGroupWithSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?, double?>), TypeInfoPropertyName = "AnyOfStringInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedRunsSessionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleWithRunsCH))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleListOrder), TypeInfoPropertyName = "ExampleListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleSelect), TypeInfoPropertyName = "ExampleSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>), TypeInfoPropertyName = "AnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleUpdateWithID))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUploadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExportAnnotationQueueRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType), TypeInfoPropertyName = "FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType), TypeInfoPropertyName = "FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateWithTokenExtendedSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormula))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaAggregationType), TypeInfoPropertyName = "FeedbackFormulaAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaWeightedVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaCreateAggregationType), TypeInfoPropertyName = "FeedbackFormulaCreateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType), TypeInfoPropertyName = "FeedbackFormulaUpdateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackIngestTokenCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackIngestTokenSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackLevel), TypeInfoPropertyName = "FeedbackLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FetchClusteringJobRunsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewType), TypeInfoPropertyName = "FilterViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewRename))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForkRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FunctionMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel), TypeInfoPropertyName = "GenerateClusteringJobConfigRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateSyntheticExamplesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetClusteringJobConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetDatasetsSelect), TypeInfoPropertyName = "GetDatasetsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunCluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunCluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InsightsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusteringJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunClusteringJobPydantic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageGroupBy), TypeInfoPropertyName = "GranularUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageStride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupExampleRunsByField), TypeInfoPropertyName = "GroupExampleRunsByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedExamplesWithRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedExperimentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HealthInfoGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Highlight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HighlightedRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HumanMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HumanMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InfoGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InternalSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InvokePromptPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.LikeRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.LikeRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListAuditLogsOCSFResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFApiActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListCommentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPublicDatasetRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunPublicDatasetSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPublicRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunPublicSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoOwnersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsForResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProviderUserSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField), TypeInfoPropertyName = "MemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelPriceMapCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelPriceMapUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFClassName), TypeInfoPropertyName = "OCSFClassName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFCategoryName), TypeInfoPropertyName = "OCSFCategoryName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFHttpRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFHttpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFResourceDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUnmapped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>), TypeInfoPropertyName = "AnyOfPromptimConfigDemoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptimConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgMemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgPendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentMethodInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlusPlanTransitionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardColorScheme), TypeInfoPropertyName = "OrganizationDashboardColorScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardType), TypeInfoPropertyName = "OrganizationDashboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationPGSchemaSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PagerdutySeverity), TypeInfoPropertyName = "PagerdutySeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_12fc55ec359bbf41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>), TypeInfoPropertyName = "ToolMessageChunk_f97dfaaf21890332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SystemMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat), TypeInfoPropertyName = "PlaygroundPromptCanvasPayloadTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundRunOverDatasetBatchRequestSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunnableConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunnerContextEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundRunOverDatasetRequestSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSavedOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType), TypeInfoPropertyName = "PlaygroundSettingsResponseSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PopulateAnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobLogCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobWithLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProxyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProxyRequestMethod), TypeInfoPropertyName = "ProxyRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PublicComparativeExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PublicExampleWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PutDatasetVersionsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryExampleSchemaWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryExampleSchemaWithRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryFeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryFeedbackDeltaBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryGroupedExamplesWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryParamsForPublicRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueueInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RemoveRepoOwnerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>), TypeInfoPropertyName = "AnyOfBooleanIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoUpdateTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsRepoType), TypeInfoPropertyName = "RepoWithLookupsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RequestBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys), TypeInfoPropertyName = "RunsGenerateQueryFeedbackKeys2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection), TypeInfoPropertyName = "ResolvedAnnotationQueueRunSchemaSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Resource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResponseBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionOutcome), TypeInfoPropertyName = "RuleLogActionOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupBy), TypeInfoPropertyName = "RunGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesAlertType), TypeInfoPropertyName = "RunRulesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesPagerdutyAlertSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesWebhookSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesValidateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaWithAnnotationQueueInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute), TypeInfoPropertyName = "RunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute), TypeInfoPropertyName = "RunStatsGroupBySeriesResponseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsSelect), TypeInfoPropertyName = "RunStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<object>, object, object>), TypeInfoPropertyName = "AnyOfIListObjectObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOConfirmEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationSendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOProviderSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SavedRunClusteringJobRequestModel), TypeInfoPropertyName = "SavedRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretUpsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountWorkspaceAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SessionFeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SessionSortableColumns), TypeInfoPropertyName = "SessionSortableColumns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SetTenantHandleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByComparativeExperimentColumn), TypeInfoPropertyName = "SortByComparativeExperimentColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByDatasetColumn), TypeInfoPropertyName = "SortByDatasetColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder), TypeInfoPropertyName = "SortParamsForRunsComparisonViewSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeAccountLinksCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeTaxId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCheckoutSessionsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeSetupIntentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StudioRunOverDatasetRequestSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TTLSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValuesAndTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueWithTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Tagging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsByResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantBulkUnshareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantForUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareDatasetToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareRunToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EntitiesItem), TypeInfoPropertyName = "EntitiesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType), TypeInfoPropertyName = "TenantShareTokensResponseEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadMessagesFormatType), TypeInfoPropertyName = "ThreadMessagesFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageStatus), TypeInfoPropertyName = "ToolMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageChunkStatus), TypeInfoPropertyName = "ToolMessageChunkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionWithoutVirtualFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TriggerRulesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TrueFalseLiteral), TypeInfoPropertyName = "TrueFalseLiteral2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateFeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpsertTTLSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpsertUsageLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimitType), TypeInfoPropertyName = "UsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UserOnboardingStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UserWithPassword))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspaceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspacePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppHubCrudTenantsTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppSchemasTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AbacErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentBuilderWebhooksWebhookTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionTarget), TypeInfoPropertyName = "AlertsAlertActionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBaseTarget), TypeInfoPropertyName = "AlertsAlertActionBaseTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAggregation), TypeInfoPropertyName = "AlertsAlertRuleAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAttribute), TypeInfoPropertyName = "AlertsAlertRuleAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleOperator), TypeInfoPropertyName = "AlertsAlertRuleOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleType), TypeInfoPropertyName = "AlertsAlertRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAggregation), TypeInfoPropertyName = "AlertsAlertRuleBaseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAttribute), TypeInfoPropertyName = "AlertsAlertRuleBaseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseOperator), TypeInfoPropertyName = "AlertsAlertRuleBaseOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseType), TypeInfoPropertyName = "AlertsAlertRuleBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsCreateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsUpdateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthnOrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthnPublicAuthInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacAttributeName), TypeInfoPropertyName = "AuthzInternalAbacAttributeName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacOperator), TypeInfoPropertyName = "AuthzInternalAbacOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAccessPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalConditionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAccessPolicyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAttachAccessPoliciesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalPermission), TypeInfoPropertyName = "AuthzInternalPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalCreateAccessPolicyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalListAccessPoliciesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BackfillsRestartBackfillRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BeaconSubmitUsageSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsExampleRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCommitWithLookups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCreateCommitReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCreateCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsListCommitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ErrutilInternalError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ErrutilUserError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCodeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorType), TypeInfoPropertyName = "EvaluatorsEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsLLMEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorRunRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsListEvaluatorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesDeleteExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesDeletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesUpdatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesColumnOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesDisableModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesFeatureConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesUpsertDefaultModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsCreateForgeConfigurationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsForgeConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsForgePR))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsForgePRUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForgeConfigurationsUpdateForgeConfigurationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsEnvironmentEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsHubEnvironmentsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationCatalogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationOverrideUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsAuthInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationType), TypeInfoPropertyName = "IntegrationsIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountResponseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsGetMcpVendorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpVendorStatus), TypeInfoPropertyName = "McpVendorsMcpVendorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListMcpGatewaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGateway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListMcpVendorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpVendor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListVendorToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsVendorTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGatewayBinding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGatewayToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McptoolsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McptoolsListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McptoolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McptoolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.NpsSubmitResponseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsLinkedLoginMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrgMemberEnriched))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsSCIMGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsWorkspaceMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrganizationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRunRunType), TypeInfoPropertyName = "RunsRunRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesAccessControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesActivityReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesActivityResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchActivityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchActivityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesActivityResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteSkipped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCaptureSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesClaimListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesClaimResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesClaimResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesClaimStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateClaimPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreatePoolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesHeaderType), TypeInfoPropertyName = "SandboxesHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesPoolListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesPoolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesPoolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesResourceSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesTemplateListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesVolumeMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateClaimPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdatePoolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimCreateScimTokenPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimScimTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimScimTokenSensitiveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimUpdateScimTokenPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsTagTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsTagTransitionHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsQueryThreadsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsCreateToolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsUpdateToolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionsAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TtlSettingsTTLSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TtlSettingsUpdateTTLSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageAgentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageAgentUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsageAgentUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageToolUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageToolUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsageToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageUserUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageUserUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsageUserUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateExampleApiV1ExamplesPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>), TypeInfoPropertyName = "AnyOfFeedbackIngestTokenCreateSchemaIListFeedbackIngestTokenCreateSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>), TypeInfoPropertyName = "AnyOfIListGuidIListAnnotationQueueRunAddSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsMultipartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreatePlatformDatasetsExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchPlatformDatasetsExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>), TypeInfoPropertyName = "AnyOfIListDataTypeDataTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>), TypeInfoPropertyName = "AnyOfIListGuidGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService), TypeInfoPropertyName = "GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSortField2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, string, object>), TypeInfoPropertyName = "AnyOfStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FilterView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>), TypeInfoPropertyName = "AnyOfRunStatsDictionaryStringRunStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>), TypeInfoPropertyName = "AnyOfFeedbackIngestTokenSchemaIListFeedbackIngestTokenSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>), TypeInfoPropertyName = "AnyOfIListPublicExampleWithRunsIListExampleWithRunsCH2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsBatchResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>), TypeInfoPropertyName = "AllOfStringPatchRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>), TypeInfoPropertyName = "AllOfStringCreatePlatformAlertsTestResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreatePlatformAlertsTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringDeletePlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringPatchPlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchPlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ForgeConfigurationsForgeConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ForgeConfigurationsForgePR>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.InvalidToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AssignedReviewerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ArtifactContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SimpleExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeries>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GroupedRunsSessionStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackFormulaWeightedVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ClusteringJobConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunCluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunClusteringJobPydantic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleGroupWithSessions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.HighlightedRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OCSFApiActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunPublicDatasetSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunPublicSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OCSFResourceDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_212e443f6115a54a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<object>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalAccessPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CommitsExampleRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CommitsCommitWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsAuthInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McptoolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesActivityReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesActivityResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesClaimResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesPoolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesTemplateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsageAgentUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsageToolUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsageUserUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TracerSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FilterView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PublicExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ForgeConfigurationsForgeConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ForgeConfigurationsForgePR>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}