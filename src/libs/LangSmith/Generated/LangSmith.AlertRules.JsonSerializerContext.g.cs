
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionTarget), TypeInfoPropertyName = "AlertsAlertActionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBaseTarget), TypeInfoPropertyName = "AlertsAlertActionBaseTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAggregation), TypeInfoPropertyName = "AlertsAlertRuleAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAttribute), TypeInfoPropertyName = "AlertsAlertRuleAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleOperator), TypeInfoPropertyName = "AlertsAlertRuleOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleType), TypeInfoPropertyName = "AlertsAlertRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAggregation), TypeInfoPropertyName = "AlertsAlertRuleBaseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAttribute), TypeInfoPropertyName = "AlertsAlertRuleBaseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseOperator), TypeInfoPropertyName = "AlertsAlertRuleBaseOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseType), TypeInfoPropertyName = "AlertsAlertRuleBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsCreateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsUpdateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>), TypeInfoPropertyName = "AllOfStringCreatePlatformAlertsTestResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreatePlatformAlertsTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringDeletePlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringPatchPlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchPlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionTarget?), TypeInfoPropertyName = "NullableAlertsAlertActionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBaseTarget?), TypeInfoPropertyName = "NullableAlertsAlertActionBaseTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAggregation?), TypeInfoPropertyName = "NullableAlertsAlertRuleAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAttribute?), TypeInfoPropertyName = "NullableAlertsAlertRuleAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleOperator?), TypeInfoPropertyName = "NullableAlertsAlertRuleOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleType?), TypeInfoPropertyName = "NullableAlertsAlertRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseOperator?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseType?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreatePlatformAlertsTestResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringDeletePlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringPatchPlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>))]
    internal sealed partial class AlertRulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertRulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AlertRulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AlertRulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreatePlatformAlertsTestResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.DeletePlatformAlertsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchPlatformAlertsResponse3>());
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
                    typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeNullableJsonConverter();
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
                    0 => new AlertRulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}