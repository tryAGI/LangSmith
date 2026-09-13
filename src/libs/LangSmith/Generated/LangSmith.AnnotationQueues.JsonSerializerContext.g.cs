
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRunToQueueByKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRunToQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueBulkDeleteRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRubricItemSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Missing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunAddSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier), TypeInfoPropertyName = "TraceTier2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode), TypeInfoPropertyName = "AnnotationQueueUpdateSchemaReviewerAccessMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum), TypeInfoPropertyName = "RunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExportAnnotationQueueRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PopulateAnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection), TypeInfoPropertyName = "ResolvedAnnotationQueueRunSchemaSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaWithAnnotationQueueInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>), TypeInfoPropertyName = "AnyOfIListGuidIListAddRunToQueueRequestIListAnnotationQueueRunAddSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType), TypeInfoPropertyName = "GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus), TypeInfoPropertyName = "GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus), TypeInfoPropertyName = "GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier?), TypeInfoPropertyName = "NullableTraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaWithRubricQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaWithSizeQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfInt32MissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode?), TypeInfoPropertyName = "NullableAnnotationQueueUpdateSchemaReviewerAccessMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum?), TypeInfoPropertyName = "NullableRunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?), TypeInfoPropertyName = "NullableResolvedAnnotationQueueRunSchemaSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>?), TypeInfoPropertyName = "NullableAnyOfIListGuidIListAddRunToQueueRequestIListAnnotationQueueRunAddSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType?), TypeInfoPropertyName = "NullableGetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus?), TypeInfoPropertyName = "NullableGetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus?), TypeInfoPropertyName = "NullableGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AssignedReviewerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>))]
    internal sealed partial class AnnotationQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationQueuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>());
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
                    typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode?)

                    || typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection)

                    || typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.TraceTier)

                    || typeToConvert == typeof(global::LangSmith.TraceTier?)

                    || typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType)

                    || typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType?)

                    || typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus)

                    || typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus)

                    || typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessModeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection))
                {
                    return new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?))
                {
                    return new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier))
                {
                    return new global::LangSmith.JsonConverters.TraceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier?))
                {
                    return new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType))
                {
                    return new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType?))
                {
                    return new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus))
                {
                    return new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus))
                {
                    return new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatusNullableJsonConverter();
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
                    0 => new AnnotationQueuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}