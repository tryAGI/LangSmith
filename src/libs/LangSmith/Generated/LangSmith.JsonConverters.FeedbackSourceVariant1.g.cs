#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class FeedbackSourceVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.FeedbackSourceVariant1>
    {
        /// <inheritdoc />
        public override global::LangSmith.FeedbackSourceVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator>(ref readerCopy, options);

            global::LangSmith.AppFeedbackSource? app = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.App)
            {
                app = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.AppFeedbackSource>(ref reader, options);
            }
            global::LangSmith.APIFeedbackSource? api = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Api)
            {
                api = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.APIFeedbackSource>(ref reader, options);
            }
            global::LangSmith.ModelFeedbackSource? model = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.Model)
            {
                model = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.ModelFeedbackSource>(ref reader, options);
            }
            global::LangSmith.AutoEvalFeedbackSource? autoEval = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType.AutoEval)
            {
                autoEval = global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.AutoEvalFeedbackSource>(ref reader, options);
            }

            var __value = new global::LangSmith.FeedbackSourceVariant1(
                discriminator?.Type,
                app,

                api,

                model,

                autoEval
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.FeedbackSourceVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.App, typeof(global::LangSmith.AppFeedbackSource), options);
            }
            else if (value.IsApi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Api, typeof(global::LangSmith.APIFeedbackSource), options);
            }
            else if (value.IsModel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Model, typeof(global::LangSmith.ModelFeedbackSource), options);
            }
            else if (value.IsAutoEval)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoEval, typeof(global::LangSmith.AutoEvalFeedbackSource), options);
            }
        }
    }
}