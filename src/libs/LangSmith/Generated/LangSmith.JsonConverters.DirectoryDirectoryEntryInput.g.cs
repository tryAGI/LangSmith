#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith.JsonConverters
{
    /// <inheritdoc />
    public class DirectoryDirectoryEntryInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LangSmith.DirectoryDirectoryEntryInput>
    {
        /// <inheritdoc />
        public override global::LangSmith.DirectoryDirectoryEntryInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryDirectoryEntryInputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryDirectoryEntryInputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LangSmith.DirectoryFileEntry? file = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryFileEntry), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryFileEntry> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryFileEntry)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.DirectoryAgentEntryInput? agent = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryAgentEntryInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryAgentEntryInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectoryAgentEntryInput)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LangSmith.DirectorySkillEntryInput? skill = default;
            if (discriminator?.Type == global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType.Skill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectorySkillEntryInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectorySkillEntryInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LangSmith.DirectorySkillEntryInput)}");
                skill = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LangSmith.DirectoryDirectoryEntryInput(
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
            global::LangSmith.DirectoryDirectoryEntryInput value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectoryAgentEntryInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectoryAgentEntryInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectoryAgentEntryInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
            else if (value.IsSkill)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LangSmith.DirectorySkillEntryInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LangSmith.DirectorySkillEntryInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LangSmith.DirectorySkillEntryInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Skill!, typeInfo);
            }
        }
    }
}