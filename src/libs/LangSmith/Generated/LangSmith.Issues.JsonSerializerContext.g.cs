
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueFixVerification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesStatus), TypeInfoPropertyName = "IssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueFixVerificationStatus), TypeInfoPropertyName = "IssuesIssueFixVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueValidationResultOutcome), TypeInfoPropertyName = "IssuesIssueValidationResultOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSyncState), TypeInfoPropertyName = "IssuesLinearSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesListViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesViewedIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesStatus), TypeInfoPropertyName = "GetPlatformIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesActivityItem), TypeInfoPropertyName = "GetPlatformIssuesActivityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesSortBy), TypeInfoPropertyName = "GetPlatformIssuesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesStatus?), TypeInfoPropertyName = "NullableIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueFixVerificationStatus?), TypeInfoPropertyName = "NullableIssuesIssueFixVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssueValidationResultOutcome?), TypeInfoPropertyName = "NullableIssuesIssueValidationResultOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSyncState?), TypeInfoPropertyName = "NullableIssuesLinearSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesStatus?), TypeInfoPropertyName = "NullableGetPlatformIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesActivityItem?), TypeInfoPropertyName = "NullableGetPlatformIssuesActivityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesSortBy?), TypeInfoPropertyName = "NullableGetPlatformIssuesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>))]
    internal sealed partial class IssuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static IssuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private IssuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LangSmith.IssuesIssueFixVerificationStatus)

                    || typeToConvert == typeof(global::LangSmith.IssuesIssueFixVerificationStatus?)

                    || typeToConvert == typeof(global::LangSmith.IssuesIssueValidationResultOutcome)

                    || typeToConvert == typeof(global::LangSmith.IssuesIssueValidationResultOutcome?)

                    || typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState)

                    || typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState?)

                    || typeToConvert == typeof(global::LangSmith.IssuesStatus)

                    || typeToConvert == typeof(global::LangSmith.IssuesStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.IssuesIssueFixVerificationStatus))
                {
                    return new global::LangSmith.JsonConverters.IssuesIssueFixVerificationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesIssueFixVerificationStatus?))
                {
                    return new global::LangSmith.JsonConverters.IssuesIssueFixVerificationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesIssueValidationResultOutcome))
                {
                    return new global::LangSmith.JsonConverters.IssuesIssueValidationResultOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesIssueValidationResultOutcome?))
                {
                    return new global::LangSmith.JsonConverters.IssuesIssueValidationResultOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState))
                {
                    return new global::LangSmith.JsonConverters.IssuesLinearSyncStateJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState?))
                {
                    return new global::LangSmith.JsonConverters.IssuesLinearSyncStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesStatus))
                {
                    return new global::LangSmith.JsonConverters.IssuesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesStatus?))
                {
                    return new global::LangSmith.JsonConverters.IssuesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesActivityItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesActivityItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesSortByNullableJsonConverter();
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
                    0 => new IssuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}