
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSavedOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType), TypeInfoPropertyName = "PlaygroundSettingsResponseSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod), TypeInfoPropertyName = "PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod), TypeInfoPropertyName = "PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope), TypeInfoPropertyName = "ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?), TypeInfoPropertyName = "NullablePlaygroundSettingsResponseSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod?), TypeInfoPropertyName = "NullablePlaygroundSettingsResponseOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod?), TypeInfoPropertyName = "NullablePlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope?), TypeInfoPropertyName = "NullableListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>))]
    internal sealed partial class PlaygroundSettingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaygroundSettingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PlaygroundSettingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PlaygroundSettingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope)

                    || typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseOauthTokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseOauthTokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope))
                {
                    return new global::LangSmith.JsonConverters.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope?))
                {
                    return new global::LangSmith.JsonConverters.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeNullableJsonConverter();
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
                    0 => new PlaygroundSettingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}