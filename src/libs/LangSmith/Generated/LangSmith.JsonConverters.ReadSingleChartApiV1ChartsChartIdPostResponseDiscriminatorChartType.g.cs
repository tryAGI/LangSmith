#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType>
    {
        /// <inheritdoc />
        public override global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType Read(
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
                        return global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeExtensions.ToValueString(value));
        }
    }
}
