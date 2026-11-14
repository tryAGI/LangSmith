#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserGroupsUserGroupAccessPolicyEffectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.UserGroupsUserGroupAccessPolicyEffect?>
    {
        /// <inheritdoc />
        public override global::LangSmith.UserGroupsUserGroupAccessPolicyEffect? Read(
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
                        return global::LangSmith.UserGroupsUserGroupAccessPolicyEffectExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.UserGroupsUserGroupAccessPolicyEffect)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.UserGroupsUserGroupAccessPolicyEffect?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.UserGroupsUserGroupAccessPolicyEffect? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.UserGroupsUserGroupAccessPolicyEffectExtensions.ToValueString(value.Value));
            }
        }
    }
}
