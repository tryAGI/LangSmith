#nullable enable

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public sealed class EPromptOptimizationJobStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.EPromptOptimizationJobStatus>
    {
        /// <inheritdoc />
        public override global::LangSmith.EPromptOptimizationJobStatus Read(
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
                        return global::LangSmith.EPromptOptimizationJobStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LangSmith.EPromptOptimizationJobStatus)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.EPromptOptimizationJobStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LangSmith.EPromptOptimizationJobStatusExtensions.ToValueString(value));
        }
    }
}
