#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class SandboxesSandboxAzureMountAuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.SandboxesSandboxAzureMountAuthConfig>
    {
        /// <inheritdoc />
        public override global::LangSmith.SandboxesSandboxAzureMountAuthConfig Read(
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
            if (__jsonProps.Contains("client_id")) __score0++;
            if (__jsonProps.Contains("subject_scope")) __score0++;
            if (__jsonProps.Contains("tenant_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("account_key")) __score1++;
            if (__jsonProps.Contains("account_key.is_set")) __score1++;
            if (__jsonProps.Contains("account_key.type")) __score1++;
            if (__jsonProps.Contains("account_key.value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("sas_token")) __score2++;
            if (__jsonProps.Contains("sas_token.is_set")) __score2++;
            if (__jsonProps.Contains("sas_token.type")) __score2++;
            if (__jsonProps.Contains("sas_token.value")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? workloadIdentity = default;
            global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? accountKey = default;
            global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? sa = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig).Name}");
                        accountKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig).Name}");
                        sa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workloadIdentity == null && accountKey == null && sa == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig).Name}");
                    workloadIdentity = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workloadIdentity == null && accountKey == null && sa == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig).Name}");
                    accountKey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (workloadIdentity == null && accountKey == null && sa == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig).Name}");
                    sa = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LangSmith.SandboxesSandboxAzureMountAuthConfig(
                workloadIdentity,

                accountKey,

                sa
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.SandboxesSandboxAzureMountAuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkloadIdentity)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkloadIdentity(), typeInfo);
            }
            else if (value.IsAccountKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAccountKey(), typeInfo);
            }
            else if (value.IsSa)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSa(), typeInfo);
            }
        }
    }
}