
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The LangSmith API is used to programmatically create and manage LangSmith resources.<br/>
    /// ## Host<br/>
    /// https://api.smith.langchain.com<br/>
    /// ## Authentication<br/>
    /// To authenticate with the LangSmith API, set the `X-Api-Key` header<br/>
    /// to a valid [LangSmith API key](https://docs.langchain.com/langsmith/create-account-api-key#create-an-api-key).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LangSmithClient : global::LangSmith.ILangSmithClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.smith.langchain.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::LangSmith.JsonConverters.AccessScopeJsonConverter(),
                    new global::LangSmith.JsonConverters.AccessScopeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2JsonConverter(),
                    new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AuditLogOperationJsonConverter(),
                    new global::LangSmith.JsonConverters.AuditLogOperationNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthProviderJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthProviderNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportCompressionNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportDestinationTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportFormatJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportFormatNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportFormatVersionJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportFormatVersionNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportRunStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportUpdatableStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.BulkExportUpdatableStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ChangePaymentPlanReqJsonConverter(),
                    new global::LangSmith.JsonConverters.ChangePaymentPlanReqNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.CodeEvaluatorLanguageJsonConverter(),
                    new global::LangSmith.JsonConverters.CodeEvaluatorLanguageNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ConfiguredByJsonConverter(),
                    new global::LangSmith.JsonConverters.ConfiguredByNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelJsonConverter(),
                    new global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.CustomChartMetricJsonConverter(),
                    new global::LangSmith.JsonConverters.CustomChartMetricNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.CustomChartTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.CustomChartTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.DataTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.DataTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.DatasetTransformationTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationJobStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptOptimizationJobStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptWebhookTriggerJsonConverter(),
                    new global::LangSmith.JsonConverters.EPromptWebhookTriggerNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ExampleListOrderJsonConverter(),
                    new global::LangSmith.JsonConverters.ExampleListOrderNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ExampleSelectJsonConverter(),
                    new global::LangSmith.JsonConverters.ExampleSelectNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackLevelJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackLevelNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FilterViewTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.FilterViewTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelJsonConverter(),
                    new global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GetDatasetsSelectJsonConverter(),
                    new global::LangSmith.JsonConverters.GetDatasetsSelectNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GranularUsageGroupByJsonConverter(),
                    new global::LangSmith.JsonConverters.GranularUsageGroupByNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GroupExampleRunsByFieldJsonConverter(),
                    new global::LangSmith.JsonConverters.GroupExampleRunsByFieldNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.HostProjectChartMetricJsonConverter(),
                    new global::LangSmith.JsonConverters.HostProjectChartMetricNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.MemberSortFieldJsonConverter(),
                    new global::LangSmith.JsonConverters.MemberSortFieldNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.OCSFCategoryNameJsonConverter(),
                    new global::LangSmith.JsonConverters.OCSFCategoryNameNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.OCSFClassNameJsonConverter(),
                    new global::LangSmith.JsonConverters.OCSFClassNameNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeJsonConverter(),
                    new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.OrganizationDashboardTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.OrganizationDashboardTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter(),
                    new global::LangSmith.JsonConverters.PagerdutySeverityNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter(),
                    new global::LangSmith.JsonConverters.PaymentPlanTierNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2JsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2JsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ProvisioningMethodJsonConverter(),
                    new global::LangSmith.JsonConverters.ProvisioningMethodNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ProxyRequestMethodJsonConverter(),
                    new global::LangSmith.JsonConverters.ProxyRequestMethodNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionJsonConverter(),
                    new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ResourceTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.ResourceTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RuleLogActionOutcomeJsonConverter(),
                    new global::LangSmith.JsonConverters.RuleLogActionOutcomeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunDateOrderJsonConverter(),
                    new global::LangSmith.JsonConverters.RunDateOrderNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunGroupByJsonConverter(),
                    new global::LangSmith.JsonConverters.RunGroupByNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.RunRulesAlertTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunSelectJsonConverter(),
                    new global::LangSmith.JsonConverters.RunSelectNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupByAttributeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2JsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsSelectJsonConverter(),
                    new global::LangSmith.JsonConverters.RunStatsSelectNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunTypeEnumJsonConverter(),
                    new global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunnerContextEnumJsonConverter(),
                    new global::LangSmith.JsonConverters.RunnerContextEnumNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelJsonConverter(),
                    new global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SessionSortableColumnsJsonConverter(),
                    new global::LangSmith.JsonConverters.SessionSortableColumnsNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SortByComparativeExperimentColumnJsonConverter(),
                    new global::LangSmith.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SortByDatasetColumnJsonConverter(),
                    new global::LangSmith.JsonConverters.SortByDatasetColumnNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter(),
                    new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SourceTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.SourceTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.TenantUsageLimitTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ToolMessageStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.ToolMessageStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ToolMessageChunkStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.ToolMessageChunkStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.TraceTierJsonConverter(),
                    new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.TrueFalseLiteralJsonConverter(),
                    new global::LangSmith.JsonConverters.TrueFalseLiteralNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.UsageLimitTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertActionTargetJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertActionTargetNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalAbacOperatorJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalAbacOperatorNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalPermissionJsonConverter(),
                    new global::LangSmith.JsonConverters.AuthzInternalPermissionNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusJsonConverter(),
                    new global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsRunRunTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.RunsRunRunTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.SandboxesHeaderTypeJsonConverter(),
                    new global::LangSmith.JsonConverters.SandboxesHeaderTypeNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2JsonConverter(),
                    new global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2JsonConverter(),
                    new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2JsonConverter(),
                    new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2JsonConverter(),
                    new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceJsonConverter(),
                    new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceNullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2JsonConverter(),
                    new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2NullableJsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackSourceVariant1JsonConverter(),
                    new global::LangSmith.JsonConverters.FeedbackSourceVariant12JsonConverter(),
                    new global::LangSmith.JsonConverters.EntitiesItemJsonConverter(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>(),
                    new global::LangSmith.JsonConverters.OneOfJsonConverter<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<object>, object, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>(),
                    new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsResponse3>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsBatchResponse3>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchRunsResponse3>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreatePlatformAlertsTestResponse3>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.DeletePlatformAlertsResponse3>(),
                    new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchPlatformAlertsResponse3>(),
                    new global::LangSmith.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AccessPoliciesClient AccessPolicies => new AccessPoliciesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AceClient Ace => new AceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AlertRulesClient AlertRules => new AlertRulesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueues2Client AnnotationQueues2 => new AnnotationQueues2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BeaconClient Beacon => new BeaconClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BulkExportsClient BulkExports => new BulkExportsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorsClient Evaluators => new EvaluatorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentViewOverridesClient ExperimentViewOverrides => new ExperimentViewOverridesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeaturesClient Features => new FeaturesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ForgeConfigurationsClient ForgeConfigurations => new ForgeConfigurationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HubEnvironmentsClient HubEnvironments => new HubEnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpClient Mcp => new McpClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpVendorsClient McpVendors => new McpVendorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MeClient Me => new MeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OptimizationJobsClient OptimizationJobs => new OptimizationJobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OwnershipsClient Ownerships => new OwnershipsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptWebhooksClient PromptWebhooks => new PromptWebhooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run => new RunClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SandboxesClient Sandboxes => new SandboxesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScimTokensClient ScimTokens => new ScimTokensClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions => new SessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagTransitionsClient TagTransitions => new TagTransitionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags => new TagsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ThreadsClient Threads => new ThreadsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtlSettings2Client TtlSettings2 => new TtlSettings2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the LangSmithClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LangSmithClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}