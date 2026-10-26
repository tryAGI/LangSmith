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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomChartsSectionChartDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomChartsSectionChartDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomChartsSectionChartDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.SingleCustomChartResponseSerialized? bar = default;
            if (discriminator?.ChartType == global::LangSmith.CustomChartsSectionChartDiscriminatorChartType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.SingleCustomChartResponseSerialized)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.CustomTextBlock? text = default;
            if (discriminator?.ChartType == global::LangSmith.CustomChartsSectionChartDiscriminatorChartType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlock> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.CustomTextBlock)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.ChartsItem(
                discriminator?.ChartType,
                bar,

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

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.SingleCustomChartResponseSerialized), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.SingleCustomChartResponseSerialized?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.SingleCustomChartResponseSerialized).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBar(), typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.CustomTextBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.CustomTextBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.CustomTextBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
        }
    }
}