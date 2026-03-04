#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat?>
    {
        /// <inheritdoc />
        public override global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
