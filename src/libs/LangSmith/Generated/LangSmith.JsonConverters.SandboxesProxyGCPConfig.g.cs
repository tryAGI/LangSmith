#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class SandboxesProxyGCPConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.SandboxesProxyGCPConfig>
    {
        /// <inheritdoc />
        public override global::LangSmith.SandboxesProxyGCPConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("scopes")) __score0++;
            if (__jsonProps.Contains("service_account_email")) __score0++;
            if (__jsonProps.Contains("subject_scope")) __score0++;
            if (__jsonProps.Contains("workload_identity_provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("scopes")) __score1++;
            if (__jsonProps.Contains("service_account_json")) __score1++;
            if (__jsonProps.Contains("service_account_json.is_set")) __score1++;
            if (__jsonProps.Contains("service_account_json.type")) __score1++;
            if (__jsonProps.Contains("service_account_json.value")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? workloadIdentity = default;
            global::LangSmith.SandboxesProxyGCPServiceAccountConfig? serviceAccount = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig).Name}");
                        workloadIdentity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPServiceAccountConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig).Name}");
                        serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (workloadIdentity == null && serviceAccount == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig).Name}");
                    workloadIdentity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (workloadIdentity == null && serviceAccount == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPServiceAccountConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig).Name}");
                    serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::LangSmith.SandboxesProxyGCPConfig(
                workloadIdentity,

                serviceAccount
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.SandboxesProxyGCPConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkloadIdentity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkloadIdentity(), typeInfo);
            }
            else if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesProxyGCPServiceAccountConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickServiceAccount(), typeInfo);
            }
        }
    }
}