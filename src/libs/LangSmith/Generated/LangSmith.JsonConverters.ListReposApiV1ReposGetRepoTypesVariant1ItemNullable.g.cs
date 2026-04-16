#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListReposApiV1ReposGetRepoTypesVariant1ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?>
    {
        /// <inheritdoc />
        public override global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? Read(
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
                        return global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1ItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
