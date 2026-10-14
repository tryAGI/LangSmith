#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class SandboxesSandboxGCPMountAuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.SandboxesSandboxGCPMountAuthConfig>
    {
        /// <inheritdoc />
        public override global::LangSmith.SandboxesSandboxGCPMountAuthConfig Read(
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
            if (__jsonProps.Contains("service_account_email")) __score0++;
            if (__jsonProps.Contains("subject_scope")) __score0++;
            if (__jsonProps.Contains("workload_identity_provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("service_account_json")) __score1++;
            if (__jsonProps.Contains("service_account_json.is_set")) __score1++;
            if (__jsonProps.Contains("service_account_json.type")) __score1++;
            if (__jsonProps.Contains("service_account_json.value")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? workloadIdentity = default;
            global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? serviceAccount = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig).Name}");
                        workloadIdentity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig).Name}");
                        serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workloadIdentity == null && serviceAccount == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig).Name}");
                    workloadIdentity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workloadIdentity == null && serviceAccount == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig).Name}");
                    serviceAccount = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LangSmith.SandboxesSandboxGCPMountAuthConfig(
                workloadIdentity,

                serviceAccount
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.SandboxesSandboxGCPMountAuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkloadIdentity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkloadIdentity(), typeInfo);
            }
            else if (value.IsServiceAccount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickServiceAccount(), typeInfo);
            }
        }
    }
}