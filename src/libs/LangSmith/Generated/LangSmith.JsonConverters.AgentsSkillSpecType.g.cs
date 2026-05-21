#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsSkillSpecTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.AgentsSkillSpecType>
    {
        /// <inheritdoc />
        public override global::LangSmith.AgentsSkillSpecType Read(
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
                        return global::LangSmith.AgentsSkillSpecTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.AgentsSkillSpecType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.AgentsSkillSpecType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.AgentsSkillSpecType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.AgentsSkillSpecTypeExtensions.ToValueString(value));
        }
    }
}
