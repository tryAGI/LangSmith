#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class CreateChartApiV1ChartsCreatePostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.CreateChartApiV1ChartsCreatePostRequest>
    {
        /// <inheritdoc />
        public override global::LangSmith.CreateChartApiV1ChartsCreatePostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.CustomChartCreate? line = default;
            if (discriminator?.ChartType == global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomChartCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomChartCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomChartCreate)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.CustomTextBlockCreate? text = default;
            if (discriminator?.ChartType == global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomTextBlockCreate)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.CreateChartApiV1ChartsCreatePostRequest(
                discriminator?.ChartType,
                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.CreateChartApiV1ChartsCreatePostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomChartCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomChartCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomChartCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlockCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}