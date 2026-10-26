#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class ReadSingleChartApiV1ChartsChartIdPostResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse>
    {
        /// <inheritdoc />
        public override global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.SingleCustomChartResponseSerialized? line = default;
            if (discriminator?.ChartType == global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.SingleCustomChartResponseSerialized)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.CustomTextBlockResponse? text = default;
            if (discriminator?.ChartType == global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomTextBlockResponse)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse(
                discriminator?.ChartType,
                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SingleCustomChartResponseSerialized).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLine(), typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlockResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlockResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlockResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
        }
    }
}