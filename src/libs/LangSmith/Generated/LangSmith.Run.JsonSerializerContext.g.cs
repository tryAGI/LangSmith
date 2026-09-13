
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier), TypeInfoPropertyName = "TraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum), TypeInfoPropertyName = "RunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsFilterDataSourceTypeEnum), TypeInfoPropertyName = "RunsFilterDataSourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSelect), TypeInfoPropertyName = "RunSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunDateOrder), TypeInfoPropertyName = "RunDateOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyParamsForRunsQuerySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorLanguage), TypeInfoPropertyName = "CodeEvaluatorLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorStructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PagerdutySeverity), TypeInfoPropertyName = "PagerdutySeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RequestBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys), TypeInfoPropertyName = "RunsGenerateQueryFeedbackKeys2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResponseBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionOutcome), TypeInfoPropertyName = "RuleLogActionOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupBy), TypeInfoPropertyName = "RunGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitSchemaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitWindow), TypeInfoPropertyName = "RunRuleSpendLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitSchemaOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesAlertType), TypeInfoPropertyName = "RunRulesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesPagerdutyAlertSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesWebhookSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesCreateSchemaGroupBy), TypeInfoPropertyName = "RunRulesCreateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesSchemaGroupBy), TypeInfoPropertyName = "RunRulesSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy), TypeInfoPropertyName = "RunRulesUpdateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesValidateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesValidateSchemaGroupBy), TypeInfoPropertyName = "RunRulesValidateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute), TypeInfoPropertyName = "RunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsSelect), TypeInfoPropertyName = "RunStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadMessagesFormatType), TypeInfoPropertyName = "ThreadMessagesFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TriggerRulesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType), TypeInfoPropertyName = "ListRulesApiV1RunsRulesGetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>), TypeInfoPropertyName = "AnyOfRunStatsDictionaryStringRunStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier?), TypeInfoPropertyName = "NullableTraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum?), TypeInfoPropertyName = "NullableRunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?), TypeInfoPropertyName = "NullableRunsFilterDataSourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSelect?), TypeInfoPropertyName = "NullableRunSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunDateOrder?), TypeInfoPropertyName = "NullableRunDateOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorLanguage?), TypeInfoPropertyName = "NullableCodeEvaluatorLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PagerdutySeverity?), TypeInfoPropertyName = "NullablePagerdutySeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?), TypeInfoPropertyName = "NullableRunsGenerateQueryFeedbackKeys2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionOutcome?), TypeInfoPropertyName = "NullableRuleLogActionOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupBy?), TypeInfoPropertyName = "NullableRunGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitWindow?), TypeInfoPropertyName = "NullableRunRuleSpendLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesAlertType?), TypeInfoPropertyName = "NullableRunRulesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesCreateSchemaGroupBy?), TypeInfoPropertyName = "NullableRunRulesCreateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesSchemaGroupBy?), TypeInfoPropertyName = "NullableRunRulesSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy?), TypeInfoPropertyName = "NullableRunRulesUpdateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesValidateSchemaGroupBy?), TypeInfoPropertyName = "NullableRunRulesValidateSchemaGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute?), TypeInfoPropertyName = "NullableRunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsSelect?), TypeInfoPropertyName = "NullableRunStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadMessagesFormatType?), TypeInfoPropertyName = "NullableThreadMessagesFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType?), TypeInfoPropertyName = "NullableListRulesApiV1RunsRulesGetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>?), TypeInfoPropertyName = "NullableAnyOfRunStatsDictionaryStringRunStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>))]
    internal sealed partial class RunSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RunSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RunSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage)

                    || typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage?)

                    || typeToConvert == typeof(global::LangSmith.PagerdutySeverity)

                    || typeToConvert == typeof(global::LangSmith.PagerdutySeverity?)

                    || typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome)

                    || typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome?)

                    || typeToConvert == typeof(global::LangSmith.RunDateOrder)

                    || typeToConvert == typeof(global::LangSmith.RunDateOrder?)

                    || typeToConvert == typeof(global::LangSmith.RunGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow)

                    || typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesAlertType)

                    || typeToConvert == typeof(global::LangSmith.RunRulesAlertType?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesCreateSchemaGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunRulesCreateSchemaGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesSchemaGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunRulesSchemaGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesValidateSchemaGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunRulesValidateSchemaGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunSelect)

                    || typeToConvert == typeof(global::LangSmith.RunSelect?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsSelect)

                    || typeToConvert == typeof(global::LangSmith.RunStatsSelect?)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys)

                    || typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?)

                    || typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType)

                    || typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType?)

                    || typeToConvert == typeof(global::LangSmith.TraceTier)

                    || typeToConvert == typeof(global::LangSmith.TraceTier?)

                    || typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType)

                    || typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage))
                {
                    return new global::LangSmith.JsonConverters.CodeEvaluatorLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage?))
                {
                    return new global::LangSmith.JsonConverters.CodeEvaluatorLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PagerdutySeverity))
                {
                    return new global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PagerdutySeverity?))
                {
                    return new global::LangSmith.JsonConverters.PagerdutySeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome))
                {
                    return new global::LangSmith.JsonConverters.RuleLogActionOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome?))
                {
                    return new global::LangSmith.JsonConverters.RuleLogActionOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunDateOrder))
                {
                    return new global::LangSmith.JsonConverters.RunDateOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunDateOrder?))
                {
                    return new global::LangSmith.JsonConverters.RunDateOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow))
                {
                    return new global::LangSmith.JsonConverters.RunRuleSpendLimitWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow?))
                {
                    return new global::LangSmith.JsonConverters.RunRuleSpendLimitWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesAlertType))
                {
                    return new global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesAlertType?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesCreateSchemaGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunRulesCreateSchemaGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesCreateSchemaGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesCreateSchemaGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesSchemaGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunRulesSchemaGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesSchemaGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesSchemaGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunRulesUpdateSchemaGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesUpdateSchemaGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesUpdateSchemaGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesValidateSchemaGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunRulesValidateSchemaGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesValidateSchemaGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesValidateSchemaGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunSelect))
                {
                    return new global::LangSmith.JsonConverters.RunSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunSelect?))
                {
                    return new global::LangSmith.JsonConverters.RunSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsSelect))
                {
                    return new global::LangSmith.JsonConverters.RunStatsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsSelect?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys))
                {
                    return new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?))
                {
                    return new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType))
                {
                    return new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType?))
                {
                    return new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier))
                {
                    return new global::LangSmith.JsonConverters.TraceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier?))
                {
                    return new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType))
                {
                    return new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType?))
                {
                    return new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RunSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}