#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class GatewayPoliciesRateLimitWindowNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.GatewayPoliciesRateLimitWindow?>
    {
        /// <inheritdoc />
        public override global::LangSmith.GatewayPoliciesRateLimitWindow? Read(
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
                        return global::LangSmith.GatewayPoliciesRateLimitWindowExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.GatewayPoliciesRateLimitWindow)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.GatewayPoliciesRateLimitWindow?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.GatewayPoliciesRateLimitWindow? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.GatewayPoliciesRateLimitWindowExtensions.ToValueString(value.Value));
            }
        }
    }
}
