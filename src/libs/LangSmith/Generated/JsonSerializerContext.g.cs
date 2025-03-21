
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
            typeof(global::LangSmith.JsonConverters.AIMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.AIMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolCallTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolCallTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.InvalidToolCallTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.InvalidToolCallTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.AIMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.AIMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolCallChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolCallChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.AccessScopeJsonConverter),
            typeof(global::LangSmith.JsonConverters.AccessScopeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.AuthProviderJsonConverter),
            typeof(global::LangSmith.JsonConverters.AuthProviderNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunTypeEnumJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunSelectJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunSelectNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunDateOrderJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunDateOrderNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.DataTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.DataTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportFormatJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportFormatNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportCompressionNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportRunStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportUpdateStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.BulkExportUpdateStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChangePaymentPlanReqJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChangePaymentPlanReqNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChatMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChatMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChatMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ChatMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ConfiguredByJsonConverter),
            typeof(global::LangSmith.JsonConverters.ConfiguredByNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.CreateEventRequestEventTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.CreateEventRequestEventTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.FeedbackTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.FeedbackTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.CustomChartTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.CustomChartTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.CustomChartMetricJsonConverter),
            typeof(global::LangSmith.JsonConverters.CustomChartMetricNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.MissingMissing1JsonConverter),
            typeof(global::LangSmith.JsonConverters.MissingMissing1NullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter),
            typeof(global::LangSmith.JsonConverters.PaymentPlanTierNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.DatasetTransformationTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.EPromptOptimizationJobStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ExampleListOrderJsonConverter),
            typeof(global::LangSmith.JsonConverters.ExampleListOrderNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ExampleSelectJsonConverter),
            typeof(global::LangSmith.JsonConverters.ExampleSelectNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.TraceTierJsonConverter),
            typeof(global::LangSmith.JsonConverters.TraceTierNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.FeedbackLevelJsonConverter),
            typeof(global::LangSmith.JsonConverters.FeedbackLevelNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.FilterViewTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.FilterViewTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.FunctionMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.FunctionMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.FunctionMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.FunctionMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.GroupExampleRunsByFieldJsonConverter),
            typeof(global::LangSmith.JsonConverters.GroupExampleRunsByFieldNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.HumanMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.HumanMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.HumanMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.HumanMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ResourceTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ResourceTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.OAuthProviderJsonConverter),
            typeof(global::LangSmith.JsonConverters.OAuthProviderNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeJsonConverter),
            typeof(global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.OrganizationDashboardTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.OrganizationDashboardTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter),
            typeof(global::LangSmith.JsonConverters.PagerdutySeverityNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SystemMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.SystemMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SystemMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.SystemMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageChunkTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageChunkTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageChunkStatusJsonConverter),
            typeof(global::LangSmith.JsonConverters.ToolMessageChunkStatusNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLengthJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLengthNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevelJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevelNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter),
            typeof(global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.QueryExampleSchemaWithRunsFormatJsonConverter),
            typeof(global::LangSmith.JsonConverters.QueryExampleSchemaWithRunsFormatNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RuleLogActionOutcomeJsonConverter),
            typeof(global::LangSmith.JsonConverters.RuleLogActionOutcomeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunGroupByJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunGroupByNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.RunRulesAlertTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SessionSortableColumnsJsonConverter),
            typeof(global::LangSmith.JsonConverters.SessionSortableColumnsNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortByComparativeExperimentColumnJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortByDatasetColumnJsonConverter),
            typeof(global::LangSmith.JsonConverters.SortByDatasetColumnNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.SourceTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.SourceTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareDatasetTokenTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareDatasetTokenTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareRunTokenTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareRunTokenTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.TenantUsageLimitTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.UsageLimitTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.CreateRunRequestRunTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.CreateRunRequestRunTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.BatchIngestRunsRequestPostItemRunTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetTypeJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetTypeNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchivedJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchivedNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsPublicJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsPublicNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1JsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1NullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2JsonConverter),
            typeof(global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublicJsonConverter),
            typeof(global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublicNullableJsonConverter),
            typeof(global::LangSmith.JsonConverters.EntitiesItemJsonConverter),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<object>, object>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.OneOfJsonConverter<string, double?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>),
            typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>),
            typeof(global::LangSmith.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}