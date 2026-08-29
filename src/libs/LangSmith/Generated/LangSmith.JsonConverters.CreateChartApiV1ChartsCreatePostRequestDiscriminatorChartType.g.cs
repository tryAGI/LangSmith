#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType>
    {
        /// <inheritdoc />
        public override global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType Read(
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
                        return global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeExtensions.ToValueString(value));
        }
    }
}
