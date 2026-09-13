
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueItemListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedParseErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass), TypeInfoPropertyName = "SharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueItemListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass?), TypeInfoPropertyName = "NullableSharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>))]
    internal sealed partial class AnnotationQueues2SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueues2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationQueues2SourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationQueues2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueReviewStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueReviewStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsDirectionNullableJsonConverter();
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
                    0 => new AnnotationQueues2SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}