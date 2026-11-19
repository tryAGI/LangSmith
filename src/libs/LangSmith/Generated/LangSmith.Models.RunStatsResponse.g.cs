#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Run statistics: one object for an ungrouped query, or an object keyed by<br/>
    /// group value or bucket start time when the query groups or buckets runs.
    /// </summary>
    public readonly partial struct RunStatsResponse : global::System.IEquatable<RunStatsResponse>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.RunStats? RunStats { get; init; }
#else
        public global::LangSmith.RunStats? RunStats { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStats))]
#endif
        public bool IsRunStats => RunStats != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunStats(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.RunStats? value)
        {
            value = RunStats;
            return IsRunStats;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStats PickRunStats() => RunStats is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStats' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? RunStatsResponseVariant2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? RunStatsResponseVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunStatsResponseVariant2))]
#endif
        public bool IsRunStatsResponseVariant2 => RunStatsResponseVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRunStatsResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? value)
        {
            value = RunStatsResponseVariant2;
            return IsRunStatsResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats> PickRunStatsResponseVariant2() => RunStatsResponseVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RunStatsResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RunStatsResponse(global::LangSmith.RunStats value) => new RunStatsResponse((global::LangSmith.RunStats?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.RunStats?(RunStatsResponse @this) => @this.RunStats;

        /// <summary>
        ///
        /// </summary>
        public RunStatsResponse(global::LangSmith.RunStats? value)
        {
            RunStats = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RunStatsResponse FromRunStats(global::LangSmith.RunStats? value) => new RunStatsResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RunStatsResponse(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats> value) => new RunStatsResponse((global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>?(RunStatsResponse @this) => @this.RunStatsResponseVariant2;

        /// <summary>
        ///
        /// </summary>
        public RunStatsResponse(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? value)
        {
            RunStatsResponseVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RunStatsResponse FromRunStatsResponseVariant2(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? value) => new RunStatsResponse(value);

        /// <summary>
        ///
        /// </summary>
        public RunStatsResponse(
            global::LangSmith.RunStats? runStats,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? runStatsResponseVariant2
            )
        {
            RunStats = runStats;
            RunStatsResponseVariant2 = runStatsResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RunStatsResponseVariant2 as object ??
            RunStats as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RunStats?.ToString() ??
            RunStatsResponseVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRunStats || IsRunStatsResponseVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.RunStats, TResult>? runStats = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>, TResult>? runStatsResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunStats is { } __value0 && runStats != null)
            {
                return runStats(__value0);
            }
            else if (RunStatsResponseVariant2 is { } __value1 && runStatsResponseVariant2 != null)
            {
                return runStatsResponseVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.RunStats>? runStats = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? runStatsResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunStats is { } __value0)
            {
                runStats?.Invoke(__value0);
            }
            else if (RunStatsResponseVariant2 is { } __value1)
            {
                runStatsResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.RunStats>? runStats = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? runStatsResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RunStats is { } __value0)
            {
                runStats?.Invoke(__value0);
            }
            else if (RunStatsResponseVariant2 is { } __value1)
            {
                runStatsResponseVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RunStats,
                typeof(global::LangSmith.RunStats),
                RunStatsResponseVariant2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>),
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
        public bool Equals(RunStatsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.RunStats?>.Default.Equals(RunStats, other.RunStats) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>?>.Default.Equals(RunStatsResponseVariant2, other.RunStatsResponseVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RunStatsResponse obj1, RunStatsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunStatsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RunStatsResponse obj1, RunStatsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunStatsResponse o && Equals(o);
        }
    }
}
