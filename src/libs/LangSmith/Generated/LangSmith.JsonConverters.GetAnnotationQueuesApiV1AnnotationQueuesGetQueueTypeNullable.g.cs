#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType?>
    {
        /// <inheritdoc />
        public override global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? Read(
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
                        return global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
