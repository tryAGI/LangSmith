#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EntitiesItem : global::System.IEquatable<EntitiesItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.TenantShareRunToken? Run { get; init; }
#else
        public global::LangSmith.TenantShareRunToken? Run { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Run))]
#endif
        public bool IsRun => Run != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRun(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.TenantShareRunToken? value)
        {
            value = Run;
            return IsRun;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareRunToken PickRun() => IsRun
            ? Run!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Run' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.TenantShareDatasetToken? Dataset { get; init; }
#else
        public global::LangSmith.TenantShareDatasetToken? Dataset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dataset))]
#endif
        public bool IsDataset => Dataset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDataset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.TenantShareDatasetToken? value)
        {
            value = Dataset;
            return IsDataset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken PickDataset() => IsDataset
            ? Dataset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dataset' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.TenantShareThreadToken? Thread { get; init; }
#else
        public global::LangSmith.TenantShareThreadToken? Thread { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thread))]
#endif
        public bool IsThread => Thread != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickThread(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.TenantShareThreadToken? value)
        {
            value = Thread;
            return IsThread;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareThreadToken PickThread() => IsThread
            ? Thread!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thread' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EntitiesItem(global::LangSmith.TenantShareRunToken value) => new EntitiesItem((global::LangSmith.TenantShareRunToken?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.TenantShareRunToken?(EntitiesItem @this) => @this.Run;

        /// <summary>
        ///
        /// </summary>
        public EntitiesItem(global::LangSmith.TenantShareRunToken? value)
        {
            Run = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EntitiesItem FromRun(global::LangSmith.TenantShareRunToken? value) => new EntitiesItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EntitiesItem(global::LangSmith.TenantShareDatasetToken value) => new EntitiesItem((global::LangSmith.TenantShareDatasetToken?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.TenantShareDatasetToken?(EntitiesItem @this) => @this.Dataset;

        /// <summary>
        ///
        /// </summary>
        public EntitiesItem(global::LangSmith.TenantShareDatasetToken? value)
        {
            Dataset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EntitiesItem FromDataset(global::LangSmith.TenantShareDatasetToken? value) => new EntitiesItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EntitiesItem(global::LangSmith.TenantShareThreadToken value) => new EntitiesItem((global::LangSmith.TenantShareThreadToken?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.TenantShareThreadToken?(EntitiesItem @this) => @this.Thread;

        /// <summary>
        ///
        /// </summary>
        public EntitiesItem(global::LangSmith.TenantShareThreadToken? value)
        {
            Thread = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EntitiesItem FromThread(global::LangSmith.TenantShareThreadToken? value) => new EntitiesItem(value);

        /// <summary>
        ///
        /// </summary>
        public EntitiesItem(
            global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? type,
            global::LangSmith.TenantShareRunToken? run,
            global::LangSmith.TenantShareDatasetToken? dataset,
            global::LangSmith.TenantShareThreadToken? thread
            )
        {
            Type = type;

            Run = run;
            Dataset = dataset;
            Thread = thread;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Thread as object ??
            Dataset as object ??
            Run as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Run?.ToString() ??
            Dataset?.ToString() ??
            Thread?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRun && !IsDataset && !IsThread || !IsRun && IsDataset && !IsThread || !IsRun && !IsDataset && IsThread;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.TenantShareRunToken, TResult>? run = null,
            global::System.Func<global::LangSmith.TenantShareDatasetToken, TResult>? dataset = null,
            global::System.Func<global::LangSmith.TenantShareThreadToken, TResult>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRun && run != null)
            {
                return run(Run!);
            }
            else if (IsDataset && dataset != null)
            {
                return dataset(Dataset!);
            }
            else if (IsThread && thread != null)
            {
                return thread(Thread!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.TenantShareRunToken>? run = null,

            global::System.Action<global::LangSmith.TenantShareDatasetToken>? dataset = null,

            global::System.Action<global::LangSmith.TenantShareThreadToken>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.TenantShareRunToken>? run = null,
            global::System.Action<global::LangSmith.TenantShareDatasetToken>? dataset = null,
            global::System.Action<global::LangSmith.TenantShareThreadToken>? thread = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRun)
            {
                run?.Invoke(Run!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsThread)
            {
                thread?.Invoke(Thread!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Run,
                typeof(global::LangSmith.TenantShareRunToken),
                Dataset,
                typeof(global::LangSmith.TenantShareDatasetToken),
                Thread,
                typeof(global::LangSmith.TenantShareThreadToken),
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
        public bool Equals(EntitiesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.TenantShareRunToken?>.Default.Equals(Run, other.Run) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.TenantShareDatasetToken?>.Default.Equals(Dataset, other.Dataset) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.TenantShareThreadToken?>.Default.Equals(Thread, other.Thread)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EntitiesItem obj1, EntitiesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EntitiesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EntitiesItem obj1, EntitiesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EntitiesItem o && Equals(o);
        }
    }
}
