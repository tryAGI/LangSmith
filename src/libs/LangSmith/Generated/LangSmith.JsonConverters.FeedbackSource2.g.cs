#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class FeedbackSource2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.FeedbackSource2>
    {
        /// <inheritdoc />
        public override global::LangSmith.FeedbackSource2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.AppFeedbackSource? app = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType.App)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AppFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AppFeedbackSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.AppFeedbackSource)}");
                app = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.APIFeedbackSource? api = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Api)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.APIFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.APIFeedbackSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.APIFeedbackSource)}");
                api = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.ModelFeedbackSource? model = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType.Model)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ModelFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ModelFeedbackSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.ModelFeedbackSource)}");
                model = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.AutoEvalFeedbackSource? autoEval = default;
            if (discriminator?.Type == global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType.AutoEval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AutoEvalFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AutoEvalFeedbackSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.AutoEvalFeedbackSource)}");
                autoEval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::LangSmith.FeedbackSource2(
                discriminator?.Type,
                app,
                api,
                model,
                autoEval
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.FeedbackSource2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AppFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AppFeedbackSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.AppFeedbackSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.App, typeInfo);
            }
            else if (value.IsApi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.APIFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.APIFeedbackSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.APIFeedbackSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Api, typeInfo);
            }
            else if (value.IsModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.ModelFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.ModelFeedbackSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.ModelFeedbackSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Model, typeInfo);
            }
            else if (value.IsAutoEval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.AutoEvalFeedbackSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.AutoEvalFeedbackSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.AutoEvalFeedbackSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoEval, typeInfo);
            }
        }
    }
}