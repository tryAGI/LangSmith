#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class DataPlanesCreateDataPlaneRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DataPlanesCreateDataPlaneRequest>
    {
        /// <inheritdoc />
        public override global::LangSmith.DataPlanesCreateDataPlaneRequest Read(
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
            if (__jsonProps.Contains("additional_tags")) __score0++;
            if (__jsonProps.Contains("byoiam_enabled")) __score0++;
            if (__jsonProps.Contains("byovpc")) __score0++;
            if (__jsonProps.Contains("byovpc.private_app_subnet_ids")) __score0++;
            if (__jsonProps.Contains("byovpc.private_db_subnet_ids")) __score0++;
            if (__jsonProps.Contains("byovpc.public_subnet_ids")) __score0++;
            if (__jsonProps.Contains("byovpc.vpc_id")) __score0++;
            if (__jsonProps.Contains("eks_api_privatelink_disabled")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("public_load_balancer")) __score0++;
            if (__jsonProps.Contains("region")) __score0++;
            if (__jsonProps.Contains("role_arn")) __score0++;
            if (__jsonProps.Contains("vpc_cidr")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("azure_entra_tenant_id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("public_load_balancer")) __score1++;
            if (__jsonProps.Contains("region")) __score1++;
            if (__jsonProps.Contains("resource_group_id")) __score1++;
            if (__jsonProps.Contains("vpc_cidr")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LangSmith.DataPlanesCreateDataPlaneRequestAws? aws = default;
            global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? azure = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAws> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws).Name}");
                        aws = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure).Name}");
                        azure = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (aws == null && azure == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAws> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws).Name}");
                    aws = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aws == null && azure == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure).Name}");
                    azure = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LangSmith.DataPlanesCreateDataPlaneRequest(
                aws,

                azure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DataPlanesCreateDataPlaneRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAws)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAws?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAws(), typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DataPlanesCreateDataPlaneRequestAzure?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAzure).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAzure(), typeInfo);
            }
        }
    }
}