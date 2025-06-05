#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class EntitiesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.EntitiesItem>
    {
        /// <inheritdoc />
        public override global::LangSmith.EntitiesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.TenantShareTokensResponseEntitieDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.TenantShareRunToken? run = default;
            if (discriminator?.Type == global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType.Run)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.TenantShareRunToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.TenantShareRunToken> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.TenantShareRunToken)}");
                run = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.TenantShareDatasetToken? dataset = default;
            if (discriminator?.Type == global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType.Dataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.TenantShareDatasetToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.TenantShareDatasetToken> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.TenantShareDatasetToken)}");
                dataset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::LangSmith.EntitiesItem(
                discriminator?.Type,
                run,
                dataset
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.EntitiesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRun)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.TenantShareRunToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.TenantShareRunToken?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.TenantShareRunToken).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeInfo);
            }
            else if (value.IsDataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.TenantShareDatasetToken), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.TenantShareDatasetToken?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.TenantShareDatasetToken).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dataset, typeInfo);
            }
        }
    }
}