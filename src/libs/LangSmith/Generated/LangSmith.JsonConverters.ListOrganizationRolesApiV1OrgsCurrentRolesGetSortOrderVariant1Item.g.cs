#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>
    {
        /// <inheritdoc />
        public override global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item Read(
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
                        return global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1ItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1ItemExtensions.ToValueString(value));
        }
    }
}
