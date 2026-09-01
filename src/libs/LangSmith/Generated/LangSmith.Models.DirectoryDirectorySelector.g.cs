#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DirectoryDirectorySelector : global::System.IEquatable<DirectoryDirectorySelector>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectoryLatestSelector? Latest { get; init; }
#else
        public global::LangSmith.DirectoryLatestSelector? Latest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Latest))]
#endif
        public bool IsLatest => Latest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLatest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DirectoryLatestSelector? value)
        {
            value = Latest;
            return IsLatest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelector PickLatest() => IsLatest
            ? Latest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Latest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.DirectoryCommitSelector? Commit { get; init; }
#else
        public global::LangSmith.DirectoryCommitSelector? Commit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Commit))]
#endif
        public bool IsCommit => Commit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.DirectoryCommitSelector? value)
        {
            value = Commit;
            return IsCommit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelector PickCommit() => IsCommit
            ? Commit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Commit' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectorySelector(global::LangSmith.DirectoryLatestSelector value) => new DirectoryDirectorySelector((global::LangSmith.DirectoryLatestSelector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryLatestSelector?(DirectoryDirectorySelector @this) => @this.Latest;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectorySelector(global::LangSmith.DirectoryLatestSelector? value)
        {
            Latest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectorySelector FromLatest(global::LangSmith.DirectoryLatestSelector? value) => new DirectoryDirectorySelector(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DirectoryDirectorySelector(global::LangSmith.DirectoryCommitSelector value) => new DirectoryDirectorySelector((global::LangSmith.DirectoryCommitSelector?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.DirectoryCommitSelector?(DirectoryDirectorySelector @this) => @this.Commit;

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectorySelector(global::LangSmith.DirectoryCommitSelector? value)
        {
            Commit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DirectoryDirectorySelector FromCommit(global::LangSmith.DirectoryCommitSelector? value) => new DirectoryDirectorySelector(value);

        /// <summary>
        ///
        /// </summary>
        public DirectoryDirectorySelector(
            global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? type,
            global::LangSmith.DirectoryLatestSelector? latest,
            global::LangSmith.DirectoryCommitSelector? commit
            )
        {
            Type = type;

            Latest = latest;
            Commit = commit;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Commit as object ??
            Latest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Latest?.ToString() ??
            Commit?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLatest && !IsCommit || !IsLatest && IsCommit;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.DirectoryLatestSelector, TResult>? latest = null,
            global::System.Func<global::LangSmith.DirectoryCommitSelector, TResult>? commit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLatest && latest != null)
            {
                return latest(Latest!);
            }
            else if (IsCommit && commit != null)
            {
                return commit(Commit!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.DirectoryLatestSelector>? latest = null,

            global::System.Action<global::LangSmith.DirectoryCommitSelector>? commit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLatest)
            {
                latest?.Invoke(Latest!);
            }
            else if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.DirectoryLatestSelector>? latest = null,
            global::System.Action<global::LangSmith.DirectoryCommitSelector>? commit = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLatest)
            {
                latest?.Invoke(Latest!);
            }
            else if (IsCommit)
            {
                commit?.Invoke(Commit!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Latest,
                typeof(global::LangSmith.DirectoryLatestSelector),
                Commit,
                typeof(global::LangSmith.DirectoryCommitSelector),
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
        public bool Equals(DirectoryDirectorySelector other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryLatestSelector?>.Default.Equals(Latest, other.Latest) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.DirectoryCommitSelector?>.Default.Equals(Commit, other.Commit)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DirectoryDirectorySelector obj1, DirectoryDirectorySelector obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DirectoryDirectorySelector>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DirectoryDirectorySelector obj1, DirectoryDirectorySelector obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DirectoryDirectorySelector o && Equals(o);
        }
    }
}
