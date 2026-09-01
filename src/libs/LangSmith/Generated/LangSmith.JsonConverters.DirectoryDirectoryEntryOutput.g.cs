#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class DirectoryDirectoryEntryOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DirectoryDirectoryEntryOutput>
    {
        /// <inheritdoc />
        public override global::LangSmith.DirectoryDirectoryEntryOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.DirectoryFileEntry? file = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryFileEntry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryFileEntry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryFileEntry)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.DirectoryAgentEntryOutput? agent = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryAgentEntryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryAgentEntryOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryAgentEntryOutput)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.DirectorySkillEntryOutput? skill = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType.Skill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectorySkillEntryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectorySkillEntryOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectorySkillEntryOutput)}");
                skill = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.DirectoryDirectoryEntryOutput(
                discriminator?.Type,
                file,

                agent,

                skill
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LangSmith.DirectoryDirectoryEntryOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryFileEntry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryFileEntry?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectoryFileEntry).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File!, typeInfo);
            }
            else if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryAgentEntryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryAgentEntryOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectoryAgentEntryOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
            else if (value.IsSkill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectorySkillEntryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectorySkillEntryOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectorySkillEntryOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Skill!, typeInfo);
            }
        }
    }
}