#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType Read(
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
                        return global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
