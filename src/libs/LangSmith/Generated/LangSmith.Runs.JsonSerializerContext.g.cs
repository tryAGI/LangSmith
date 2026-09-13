
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField), TypeInfoPropertyName = "QueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect), TypeInfoPropertyName = "QueryPublicSharedTraceRunsRequestBodySelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType), TypeInfoPropertyName = "QueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTraceResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTracesRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTracesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryTrace))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryTraceAggregates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRunRunType), TypeInfoPropertyName = "RunsRunRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareCreateShareTokenRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareCreateShareTokenResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareDeleteShareTokenRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedParseErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass), TypeInfoPropertyName = "SharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsMultipartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsSelect), TypeInfoPropertyName = "GetRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetTracesRunsSelect), TypeInfoPropertyName = "GetTracesRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>), TypeInfoPropertyName = "AllOfStringPatchRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsBatchResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField?), TypeInfoPropertyName = "NullableQueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?), TypeInfoPropertyName = "NullableQueryPublicSharedTraceRunsRequestBodySelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType?), TypeInfoPropertyName = "NullableQueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunStatus?), TypeInfoPropertyName = "NullableQueryRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRunRunType?), TypeInfoPropertyName = "NullableRunsRunRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass?), TypeInfoPropertyName = "NullableSharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsSelect?), TypeInfoPropertyName = "NullableGetRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetTracesRunsSelect?), TypeInfoPropertyName = "NullableGetTracesRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringPatchRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreateRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreateRunsBatchResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>))]
    internal sealed partial class RunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchRunsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsBatchResponse3>());
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
                    typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect)

                    || typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType?)

                    || typeToConvert == typeof(global::LangSmith.RunsRunRunType)

                    || typeToConvert == typeof(global::LangSmith.RunsRunRunType?)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?)

                    || typeToConvert == typeof(global::LangSmith.GetRunsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetRunsSelect?)

                    || typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect))
                {
                    return new global::LangSmith.JsonConverters.QueryPublicSharedTraceRunsRequestBodySelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?))
                {
                    return new global::LangSmith.JsonConverters.QueryPublicSharedTraceRunsRequestBodySelectNullableJsonConverter();
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

                if (typeToConvert == typeof(global::LangSmith.RunsRunRunType))
                {
                    return new global::LangSmith.JsonConverters.RunsRunRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsRunRunType?))
                {
                    return new global::LangSmith.JsonConverters.RunsRunRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetRunsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetRunsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetTracesRunsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetTracesRunsSelectNullableJsonConverter();
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
                    0 => new RunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}