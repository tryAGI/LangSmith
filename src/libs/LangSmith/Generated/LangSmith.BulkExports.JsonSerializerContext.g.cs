
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle), TypeInfoPropertyName = "BotocoreS3ConfigAddressingStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint), TypeInfoPropertyName = "BotocoreS3ConfigUsEast1RegionalEndpoint2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend), TypeInfoPropertyName = "BulkExportRunMetadataExecutionBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdatableStatus), TypeInfoPropertyName = "BulkExportUpdatableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle?), TypeInfoPropertyName = "NullableBotocoreS3ConfigAddressingStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint?), TypeInfoPropertyName = "NullableBotocoreS3ConfigUsEast1RegionalEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormat?), TypeInfoPropertyName = "NullableBulkExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormatVersion?), TypeInfoPropertyName = "NullableBulkExportFormatVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCompression?), TypeInfoPropertyName = "NullableBulkExportCompression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportStatus?), TypeInfoPropertyName = "NullableBulkExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationType?), TypeInfoPropertyName = "NullableBulkExportDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunStatus?), TypeInfoPropertyName = "NullableBulkExportRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend?), TypeInfoPropertyName = "NullableBulkExportRunMetadataExecutionBackend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdatableStatus?), TypeInfoPropertyName = "NullableBulkExportUpdatableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>))]
    internal sealed partial class BulkExportsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkExportsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BulkExportsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BulkExportsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle?)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportCompression)

                    || typeToConvert == typeof(global::LangSmith.BulkExportCompression?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportDestinationType)

                    || typeToConvert == typeof(global::LangSmith.BulkExportDestinationType?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormat)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormat?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunStatus?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportStatus?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigAddressingStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle?))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigAddressingStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigUsEast1RegionalEndpointJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint?))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigUsEast1RegionalEndpointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportCompression))
                {
                    return new global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportCompression?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportCompressionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportDestinationType))
                {
                    return new global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportDestinationType?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormat))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormat?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunMetadataExecutionBackendJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunMetadataExecutionBackendNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportUpdatableStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportUpdatableStatusNullableJsonConverter();
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
                    0 => new BulkExportsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}