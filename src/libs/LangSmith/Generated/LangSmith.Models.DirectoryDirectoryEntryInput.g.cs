#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DirectoryDirectoryEntryInput : global::System.IEquatable<DirectoryDirectoryEntryInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? Type { get; }

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
        public global::LangSmith.DirectoryAgentEntryInput? Agent { get; init; }
#else
        public global::LangSmith.DirectoryAgentEntryInput? Agent { get; }
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
            out global::LangSmith.DirectoryAgentEntryInput? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInput PickAgent() => IsAgent
            ? Agent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectorySkillEntryInput? Skill { get; init; }
#else
        public global::LangSmith.DirectorySkillEntryInput? Skill { get; }
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
            out global::LangSmith.DirectorySkillEntryInput? value)
        {
            value = Skill;
            return IsSkill;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInput PickSkill() => IsSkill
            ? Skill!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Skill' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryInput(global::LangSmith.DirectoryFileEntry value) => new DirectoryDirectoryEntryInput((global::LangSmith.DirectoryFileEntry?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryFileEntry?(DirectoryDirectoryEntryInput @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryInput(global::LangSmith.DirectoryFileEntry? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryInput FromFile(global::LangSmith.DirectoryFileEntry? value) => new DirectoryDirectoryEntryInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryInput(global::LangSmith.DirectoryAgentEntryInput value) => new DirectoryDirectoryEntryInput((global::LangSmith.DirectoryAgentEntryInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryAgentEntryInput?(DirectoryDirectoryEntryInput @this) => @this.Agent;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryInput(global::LangSmith.DirectoryAgentEntryInput? value)
        {
            Agent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryInput FromAgent(global::LangSmith.DirectoryAgentEntryInput? value) => new DirectoryDirectoryEntryInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectoryEntryInput(global::LangSmith.DirectorySkillEntryInput value) => new DirectoryDirectoryEntryInput((global::LangSmith.DirectorySkillEntryInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectorySkillEntryInput?(DirectoryDirectoryEntryInput @this) => @this.Skill;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryInput(global::LangSmith.DirectorySkillEntryInput? value)
        {
            Skill = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectoryEntryInput FromSkill(global::LangSmith.DirectorySkillEntryInput? value) => new DirectoryDirectoryEntryInput(value);

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectoryEntryInput(
            global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? type,
            global::LangSmith.DirectoryFileEntry? file,
            global::LangSmith.DirectoryAgentEntryInput? agent,
            global::LangSmith.DirectorySkillEntryInput? skill
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
            global::System.Func<global::LangSmith.DirectoryAgentEntryInput, TResult>? agent = null,
            global::System.Func<global::LangSmith.DirectorySkillEntryInput, TResult>? skill = null,
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

            global::System.Action<global::LangSmith.DirectoryAgentEntryInput>? agent = null,

            global::System.Action<global::LangSmith.DirectorySkillEntryInput>? skill = null,
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
            global::System.Action<global::LangSmith.DirectoryAgentEntryInput>? agent = null,
            global::System.Action<global::LangSmith.DirectorySkillEntryInput>? skill = null,
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
                typeof(global::LangSmith.DirectoryAgentEntryInput),
                Skill,
                typeof(global::LangSmith.DirectorySkillEntryInput),
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
        public bool Equals(DirectoryDirectoryEntryInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryFileEntry?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryAgentEntryInput?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectorySkillEntryInput?>.Default.Equals(Skill, other.Skill)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DirectoryDirectoryEntryInput obj1, DirectoryDirectoryEntryInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DirectoryDirectoryEntryInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DirectoryDirectoryEntryInput obj1, DirectoryDirectoryEntryInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DirectoryDirectoryEntryInput o && Equals(o);
        }
    }
}
