#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class CreateChartApiV1ChartsCreatePostResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.CreateChartApiV1ChartsCreatePostResponse>
    {
        /// <inheritdoc />
        public override global::LangSmith.CreateChartApiV1ChartsCreatePostResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.CustomChartResponse? line = default;
            if (discriminator?.ChartType == global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomChartResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomChartResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomChartResponse)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.CustomTextBlockResponse? text = default;
            if (discriminator?.ChartType == global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomTextBlockResponse)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.CreateChartApiV1ChartsCreatePostResponse(
                discriminator?.ChartType,
                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.CreateChartApiV1ChartsCreatePostResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomChartResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomChartResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomChartResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlockResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}