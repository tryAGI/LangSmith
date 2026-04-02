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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.TenantShareTokensResponseEntitieDiscriminator>(ref readerCopy, options);

            global::LangSmith.TenantShareRunToken? run = default;
            if (discriminator?.Type == global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType.Run)
            {
                run = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.TenantShareRunToken>(ref reader, options);
            }
            global::LangSmith.TenantShareDatasetToken? dataset = default;
            if (discriminator?.Type == global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType.Dataset)
            {
                dataset = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.TenantShareDatasetToken>(ref reader, options);
            }

            var __value = new global::LangSmith.EntitiesItem(
                discriminator?.Type,
                run,

                dataset
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.EntitiesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsRun)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Run, typeof(global::LangSmith.TenantShareRunToken), options);
            }
            else if (value.IsDataset)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dataset, typeof(global::LangSmith.TenantShareDatasetToken), options);
            }
        }
    }
}