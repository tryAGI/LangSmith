#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class DirectoryDirectorySelectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DirectoryDirectorySelector>
    {
        /// <inheritdoc />
        public override global::LangSmith.DirectoryDirectorySelector Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryDirectorySelectorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryDirectorySelectorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryDirectorySelectorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.DirectoryLatestSelector? latest = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectorySelectorDiscriminatorType.Latest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryLatestSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryLatestSelector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryLatestSelector)}");
                latest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.DirectoryCommitSelector? commit = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectorySelectorDiscriminatorType.Commit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryCommitSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryCommitSelector> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryCommitSelector)}");
                commit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.DirectoryDirectorySelector(
                discriminator?.Type,
                latest,

                commit
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DirectoryDirectorySelector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLatest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryLatestSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryLatestSelector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectoryLatestSelector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Latest!, typeInfo);
            }
            else if (value.IsCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryCommitSelector), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryCommitSelector?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectoryCommitSelector).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Commit!, typeInfo);
            }
        }
    }
}