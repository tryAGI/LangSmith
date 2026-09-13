
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCreateDirectoryCommitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryGetDirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryOutput), TypeInfoPropertyName = "DirectoryDirectoryEntryOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryLatestSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryLatestSelectorType), TypeInfoPropertyName = "DirectoryLatestSelectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitSelectorType), TypeInfoPropertyName = "DirectoryCommitSelectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectorySelector), TypeInfoPropertyName = "DirectoryDirectorySelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType), TypeInfoPropertyName = "DirectoryDirectorySelectorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryInputType), TypeInfoPropertyName = "DirectoryAgentEntryInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryInputType), TypeInfoPropertyName = "DirectorySkillEntryInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryFileEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryFileEntryType), TypeInfoPropertyName = "DirectoryFileEntryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType), TypeInfoPropertyName = "DirectoryDirectoryEntryInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryOutputType), TypeInfoPropertyName = "DirectoryAgentEntryOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryOutputType), TypeInfoPropertyName = "DirectorySkillEntryOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType), TypeInfoPropertyName = "DirectoryDirectoryEntryOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType), TypeInfoPropertyName = "DeletePlatformHubReposDirectoriesRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryOutput?), TypeInfoPropertyName = "NullableDirectoryDirectoryEntryOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryLatestSelectorType?), TypeInfoPropertyName = "NullableDirectoryLatestSelectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitSelectorType?), TypeInfoPropertyName = "NullableDirectoryCommitSelectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectorySelector?), TypeInfoPropertyName = "NullableDirectoryDirectorySelector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType?), TypeInfoPropertyName = "NullableDirectoryDirectorySelectorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryInputType?), TypeInfoPropertyName = "NullableDirectoryAgentEntryInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryInputType?), TypeInfoPropertyName = "NullableDirectorySkillEntryInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryFileEntryType?), TypeInfoPropertyName = "NullableDirectoryFileEntryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType?), TypeInfoPropertyName = "NullableDirectoryDirectoryEntryInputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryAgentEntryOutputType?), TypeInfoPropertyName = "NullableDirectoryAgentEntryOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectorySkillEntryOutputType?), TypeInfoPropertyName = "NullableDirectorySkillEntryOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType?), TypeInfoPropertyName = "NullableDirectoryDirectoryEntryOutputDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?), TypeInfoPropertyName = "NullableDeletePlatformHubReposDirectoriesRepoType2")]
    internal sealed partial class DirectoriesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectoriesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DirectoriesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DirectoriesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.DirectoryDirectorySelectorJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.DirectoryDirectoryEntryInputJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.DirectoryDirectoryEntryOutputJsonConverter());
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
                    typeToConvert == typeof(global::LangSmith.DirectoryLatestSelectorType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryLatestSelectorType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryCommitSelectorType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryCommitSelectorType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryInputType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryInputType?)

                    || typeToConvert == typeof(global::LangSmith.DirectorySkillEntryInputType)

                    || typeToConvert == typeof(global::LangSmith.DirectorySkillEntryInputType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryFileEntryType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryFileEntryType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryOutputType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryOutputType?)

                    || typeToConvert == typeof(global::LangSmith.DirectorySkillEntryOutputType)

                    || typeToConvert == typeof(global::LangSmith.DirectorySkillEntryOutputType?)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType)

                    || typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.DirectoryLatestSelectorType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryLatestSelectorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryLatestSelectorType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryLatestSelectorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryCommitSelectorType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryCommitSelectorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryCommitSelectorType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryCommitSelectorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectorySelectorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectorySelectorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryInputType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryAgentEntryInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryInputType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryAgentEntryInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectorySkillEntryInputType))
                {
                    return new global::LangSmith.JsonConverters.DirectorySkillEntryInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectorySkillEntryInputType?))
                {
                    return new global::LangSmith.JsonConverters.DirectorySkillEntryInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryFileEntryType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryFileEntryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryFileEntryType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryFileEntryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectoryEntryInputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectoryEntryInputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryOutputType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryAgentEntryOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryAgentEntryOutputType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryAgentEntryOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectorySkillEntryOutputType))
                {
                    return new global::LangSmith.JsonConverters.DirectorySkillEntryOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectorySkillEntryOutputType?))
                {
                    return new global::LangSmith.JsonConverters.DirectorySkillEntryOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectoryEntryOutputDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.DirectoryDirectoryEntryOutputDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType))
                {
                    return new global::LangSmith.JsonConverters.DeletePlatformHubReposDirectoriesRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?))
                {
                    return new global::LangSmith.JsonConverters.DeletePlatformHubReposDirectoriesRepoTypeNullableJsonConverter();
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
                    0 => new DirectoriesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}