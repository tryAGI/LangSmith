#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class SandboxesSandboxAWSMountAuthConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.SandboxesSandboxAWSMountAuthConfig>
    {
        /// <inheritdoc />
        public override global::LangSmith.SandboxesSandboxAWSMountAuthConfig Read(
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
            if (__jsonProps.Contains("role_arn")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("access_key_id")) __score1++;
            if (__jsonProps.Contains("access_key_id.is_set")) __score1++;
            if (__jsonProps.Contains("access_key_id.type")) __score1++;
            if (__jsonProps.Contains("access_key_id.value")) __score1++;
            if (__jsonProps.Contains("role_arn")) __score1++;
            if (__jsonProps.Contains("secret_access_key")) __score1++;
            if (__jsonProps.Contains("secret_access_key.is_set")) __score1++;
            if (__jsonProps.Contains("secret_access_key.type")) __score1++;
            if (__jsonProps.Contains("secret_access_key.value")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? role = default;
            global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? @static = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig).Name}");
                        role = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig).Name}");
                        @static = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (role == null && @static == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig).Name}");
                    role = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (role == null && @static == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig).Name}");
                    @static = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LangSmith.SandboxesSandboxAWSMountAuthConfig(
                role,

                @static
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.SandboxesSandboxAWSMountAuthConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Role!, typeInfo);
            }
            else if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static!, typeInfo);
            }
        }
    }
}