
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Missing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier), TypeInfoPropertyName = "TraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AttachmentsOperations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AutoEvalFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum), TypeInfoPropertyName = "RunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.DateTime?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataType), TypeInfoPropertyName = "DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetDiffInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetSchemaForUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformationType), TypeInfoPropertyName = "DatasetTransformationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfIListDatasetTransformationMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfGuidMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleWithRunsCH))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>), TypeInfoPropertyName = "AnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUploadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType), TypeInfoPropertyName = "FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateSyntheticExamplesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetDatasetsSelect), TypeInfoPropertyName = "GetDatasetsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PutDatasetVersionsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryExampleSchemaWithRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByDatasetColumn), TypeInfoPropertyName = "SortByDatasetColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder), TypeInfoPropertyName = "SortParamsForRunsComparisonViewSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StudioRunOverDatasetRequestSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField), TypeInfoPropertyName = "QueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2ExampleWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType), TypeInfoPropertyName = "QueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunCompletionCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunCompletionTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunFeedbackStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunPromptCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunPromptTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunStatus), TypeInfoPropertyName = "QueryRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedParseErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass), TypeInfoPropertyName = "SharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>), TypeInfoPropertyName = "AnyOfIListDataTypeDataTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier?), TypeInfoPropertyName = "NullableTraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum?), TypeInfoPropertyName = "NullableRunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataType?), TypeInfoPropertyName = "NullableDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformationType?), TypeInfoPropertyName = "NullableDatasetTransformationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfIListDatasetTransformationMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfGuidMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?), TypeInfoPropertyName = "NullableAnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackType?), TypeInfoPropertyName = "NullableFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32BooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32BooleanStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetDatasetsSelect?), TypeInfoPropertyName = "NullableGetDatasetsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByDatasetColumn?), TypeInfoPropertyName = "NullableSortByDatasetColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?), TypeInfoPropertyName = "NullableSortParamsForRunsComparisonViewSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField?), TypeInfoPropertyName = "NullableQueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType?), TypeInfoPropertyName = "NullableQueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunStatus?), TypeInfoPropertyName = "NullableQueryRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass?), TypeInfoPropertyName = "NullableSharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>?), TypeInfoPropertyName = "NullableAnyOfIListDataTypeDataTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetsV2ExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.FeedbackSourceVariant1JsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.FeedbackSourceVariant12JsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>());
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
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>());
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
                    typeToConvert == typeof(global::LangSmith.DataType)

                    || typeToConvert == typeof(global::LangSmith.DataType?)

                    || typeToConvert == typeof(global::LangSmith.DatasetTransformationType)

                    || typeToConvert == typeof(global::LangSmith.DatasetTransformationType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackType?)

                    || typeToConvert == typeof(global::LangSmith.GetDatasetsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetDatasetsSelect?)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.SortByDatasetColumn)

                    || typeToConvert == typeof(global::LangSmith.SortByDatasetColumn?)

                    || typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder)

                    || typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?)

                    || typeToConvert == typeof(global::LangSmith.TraceTier)

                    || typeToConvert == typeof(global::LangSmith.TraceTier?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType?)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.DataType))
                {
                    return new global::LangSmith.JsonConverters.DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DataType?))
                {
                    return new global::LangSmith.JsonConverters.DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DatasetTransformationType))
                {
                    return new global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DatasetTransformationType?))
                {
                    return new global::LangSmith.JsonConverters.DatasetTransformationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetDatasetsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetDatasetsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetDatasetsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetDatasetsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByDatasetColumn))
                {
                    return new global::LangSmith.JsonConverters.SortByDatasetColumnJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByDatasetColumn?))
                {
                    return new global::LangSmith.JsonConverters.SortByDatasetColumnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder))
                {
                    return new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?))
                {
                    return new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier))
                {
                    return new global::LangSmith.JsonConverters.TraceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier?))
                {
                    return new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunSelectField))
                {
                    return new global::LangSmith.JsonConverters.QueryRunSelectFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunSelectField?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunSelectFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunStatus))
                {
                    return new global::LangSmith.JsonConverters.QueryRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunStatus?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunType))
                {
                    return new global::LangSmith.JsonConverters.QueryRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunType?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassNullableJsonConverter();
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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}