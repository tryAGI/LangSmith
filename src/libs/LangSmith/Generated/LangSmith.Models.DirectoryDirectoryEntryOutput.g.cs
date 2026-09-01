#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DirectoryDirectoryEntryOutput : global::System.IEquatable<DirectoryDirectoryEntryOutput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectoryFileEntry? File { get; init; }
#else
        public global::LangSmith.DirectoryFileEntry? File { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DirectoryFileEntry? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntry PickFile() => IsFile
            ? File!
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectoryAgentEntryOutput? Agent { get; init; }
#else
        public global::LangSmith.DirectoryAgentEntryOutput? Agent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DirectoryAgentEntryOutput? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutput PickAgent() => IsAgent
            ? Agent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectorySkillEntryOutput? Skill { get; init; }
#else
        public global::LangSmith.DirectorySkillEntryOutput? Skill { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Skill))]
#endif
        public bool IsSkill => Skill != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSkill(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DirectorySkillEntryOutput? value)
        {
            value = Skill;
            return IsSkill;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutput PickSkill() => IsSkill
            ? Skill!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Skill' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryOutput(global::LangSmith.DirectoryFileEntry value) => new DirectoryDirectoryEntryOutput((global::LangSmith.DirectoryFileEntry?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryFileEntry?(DirectoryDirectoryEntryOutput @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryOutput(global::LangSmith.DirectoryFileEntry? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryOutput FromFile(global::LangSmith.DirectoryFileEntry? value) => new DirectoryDirectoryEntryOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryOutput(global::LangSmith.DirectoryAgentEntryOutput value) => new DirectoryDirectoryEntryOutput((global::LangSmith.DirectoryAgentEntryOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryAgentEntryOutput?(DirectoryDirectoryEntryOutput @this) => @this.Agent;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryOutput(global::LangSmith.DirectoryAgentEntryOutput? value)
        {
            Agent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryOutput FromAgent(global::LangSmith.DirectoryAgentEntryOutput? value) => new DirectoryDirectoryEntryOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryOutput(global::LangSmith.DirectorySkillEntryOutput value) => new DirectoryDirectoryEntryOutput((global::LangSmith.DirectorySkillEntryOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectorySkillEntryOutput?(DirectoryDirectoryEntryOutput @this) => @this.Skill;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryOutput(global::LangSmith.DirectorySkillEntryOutput? value)
        {
            Skill = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryOutput FromSkill(global::LangSmith.DirectorySkillEntryOutput? value) => new DirectoryDirectoryEntryOutput(value);

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryOutput(
            global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? type,
            global::LangSmith.DirectoryFileEntry? file,
            global::LangSmith.DirectoryAgentEntryOutput? agent,
            global::LangSmith.DirectorySkillEntryOutput? skill
            )
        {
            Type = type;

            File = file;
            Agent = agent;
            Skill = skill;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Skill as object ??
            Agent as object ??
            File as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            Agent?.ToString() ??
            Skill?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsAgent && !IsSkill || !IsFile && IsAgent && !IsSkill || !IsFile && !IsAgent && IsSkill;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.DirectoryFileEntry, TResult>? file = null,
            global::System.Func<global::LangSmith.DirectoryAgentEntryOutput, TResult>? agent = null,
            global::System.Func<global::LangSmith.DirectorySkillEntryOutput, TResult>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsSkill && skill != null)
            {
                return skill(Skill!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.DirectoryFileEntry>? file = null,

            global::System.Action<global::LangSmith.DirectoryAgentEntryOutput>? agent = null,

            global::System.Action<global::LangSmith.DirectorySkillEntryOutput>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsSkill)
            {
                skill?.Invoke(Skill!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.DirectoryFileEntry>? file = null,
            global::System.Action<global::LangSmith.DirectoryAgentEntryOutput>? agent = null,
            global::System.Action<global::LangSmith.DirectorySkillEntryOutput>? skill = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsSkill)
            {
                skill?.Invoke(Skill!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::LangSmith.DirectoryFileEntry),
                Agent,
                typeof(global::LangSmith.DirectoryAgentEntryOutput),
                Skill,
                typeof(global::LangSmith.DirectorySkillEntryOutput),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DirectoryDirectoryEntryOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryFileEntry?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryAgentEntryOutput?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectorySkillEntryOutput?>.Default.Equals(Skill, other.Skill)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DirectoryDirectoryEntryOutput obj1, DirectoryDirectoryEntryOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DirectoryDirectoryEntryOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DirectoryDirectoryEntryOutput obj1, DirectoryDirectoryEntryOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DirectoryDirectoryEntryOutput o && Equals(o);
        }
    }
}
