
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitManifestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoExampleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestRepoType), TypeInfoPropertyName = "CreateRepoRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestSource), TypeInfoPropertyName = "CreateRepoRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DemoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationAlgorithm), TypeInfoPropertyName = "EPromptOptimizationAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForkRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>), TypeInfoPropertyName = "AnyOfPromptimConfigDemoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptimConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsRepoType), TypeInfoPropertyName = "RepoWithLookupsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsSource), TypeInfoPropertyName = "RepoWithLookupsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TrueFalseLiteral), TypeInfoPropertyName = "TrueFalseLiteral2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived), TypeInfoPropertyName = "ListReposApiV1ReposGetIsArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoType), TypeInfoPropertyName = "ListReposApiV1ReposGetRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item), TypeInfoPropertyName = "ListReposApiV1ReposGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSource), TypeInfoPropertyName = "ListReposApiV1ReposGetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSortField), TypeInfoPropertyName = "ListReposApiV1ReposGetSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, string, object>), TypeInfoPropertyName = "AnyOfStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetIsArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestRepoType?), TypeInfoPropertyName = "NullableCreateRepoRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestSource?), TypeInfoPropertyName = "NullableCreateRepoRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationAlgorithm?), TypeInfoPropertyName = "NullableEPromptOptimizationAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>?), TypeInfoPropertyName = "NullableAnyOfPromptimConfigDemoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsRepoType?), TypeInfoPropertyName = "NullableRepoWithLookupsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsSource?), TypeInfoPropertyName = "NullableRepoWithLookupsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TrueFalseLiteral?), TypeInfoPropertyName = "NullableTrueFalseLiteral2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetIsArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoType?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSource?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSortField?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, string, object>?), TypeInfoPropertyName = "NullableAnyOfStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetIsArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>))]
    internal sealed partial class ReposSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReposSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReposSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReposSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
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
                    typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType?)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource?)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm?)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType?)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource?)

                    || typeToConvert == typeof(global::LangSmith.TrueFalseLiteral)

                    || typeToConvert == typeof(global::LangSmith.TrueFalseLiteral?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType?))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource?))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm?))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType?))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource?))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TrueFalseLiteral))
                {
                    return new global::LangSmith.JsonConverters.TrueFalseLiteralJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TrueFalseLiteral?))
                {
                    return new global::LangSmith.JsonConverters.TrueFalseLiteralNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchivedJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchivedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetSourceNullableJsonConverter();
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
                    0 => new ReposSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}