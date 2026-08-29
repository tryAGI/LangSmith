#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class ChartsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ChartsItem>
    {
        /// <inheritdoc />
        public override global::LangSmith.ChartsItem Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("chart_type")) __score0++;
            if (__jsonProps.Contains("common_filters")) __score0++;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("series")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("chart_type")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("index")) __score1++;
            if (__jsonProps.Contains("markdown")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LangSmith.SingleCustomChartResponseSerialized? singleCustomChartResponseSerialized = default;
            global::LangSmith.CustomTextBlock? text = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SingleCustomChartResponseSerialized).Name}");
                        singleCustomChartResponseSerialized = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlock).Name}");
                        text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (singleCustomChartResponseSerialized == null && text == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SingleCustomChartResponseSerialized).Name}");
                    singleCustomChartResponseSerialized = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (singleCustomChartResponseSerialized == null && text == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlock).Name}");
                    text = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LangSmith.ChartsItem(
                singleCustomChartResponseSerialized,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ChartsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSingleCustomChartResponseSerialized)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SingleCustomChartResponseSerialized).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SingleCustomChartResponseSerialized!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}