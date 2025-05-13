#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateRunRequestRunTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.CreateRunRequestRunType>
    {
        /// <inheritdoc />
        public override global::LangSmith.CreateRunRequestRunType Read(
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
                        return global::LangSmith.CreateRunRequestRunTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.CreateRunRequestRunType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.CreateRunRequestRunType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.CreateRunRequestRunType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.CreateRunRequestRunTypeExtensions.ToValueString(value));
        }
    }
}
