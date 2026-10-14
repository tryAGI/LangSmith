#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesProxyAzureConfig : global::System.IEquatable<SandboxesProxyAzureConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? WorkloadIdentity { get; init; }
#else
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? WorkloadIdentity { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkloadIdentity))]
#endif
        public bool IsWorkloadIdentity => WorkloadIdentity != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkloadIdentity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? value)
        {
            value = WorkloadIdentity;
            return IsWorkloadIdentity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig PickWorkloadIdentity() => WorkloadIdentity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkloadIdentity' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? AccountKey { get; init; }
#else
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? AccountKey { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AccountKey))]
#endif
        public bool IsAccountKey => AccountKey != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAccountKey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesProxyAzureAccountKeyConfig? value)
        {
            value = AccountKey;
            return IsAccountKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig PickAccountKey() => AccountKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccountKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyAzureSASConfig? Sa { get; init; }
#else
        public global::LangSmith.SandboxesProxyAzureSASConfig? Sa { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sa))]
#endif
        public bool IsSa => Sa != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSa(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesProxyAzureSASConfig? value)
        {
            value = Sa;
            return IsSa;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureSASConfig PickSa() => Sa is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sa' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig value) => new SandboxesProxyAzureConfig((global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig?(SandboxesProxyAzureConfig @this) => @this.WorkloadIdentity;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? value)
        {
            WorkloadIdentity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyAzureConfig FromWorkloadIdentity(global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? value) => new SandboxesProxyAzureConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureAccountKeyConfig value) => new SandboxesProxyAzureConfig((global::LangSmith.SandboxesProxyAzureAccountKeyConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyAzureAccountKeyConfig?(SandboxesProxyAzureConfig @this) => @this.AccountKey;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureAccountKeyConfig? value)
        {
            AccountKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyAzureConfig FromAccountKey(global::LangSmith.SandboxesProxyAzureAccountKeyConfig? value) => new SandboxesProxyAzureConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureSASConfig value) => new SandboxesProxyAzureConfig((global::LangSmith.SandboxesProxyAzureSASConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyAzureSASConfig?(SandboxesProxyAzureConfig @this) => @this.Sa;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAzureConfig(global::LangSmith.SandboxesProxyAzureSASConfig? value)
        {
            Sa = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyAzureConfig FromSa(global::LangSmith.SandboxesProxyAzureSASConfig? value) => new SandboxesProxyAzureConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAzureConfig(
            global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? workloadIdentity,
            global::LangSmith.SandboxesProxyAzureAccountKeyConfig? accountKey,
            global::LangSmith.SandboxesProxyAzureSASConfig? sa
            )
        {
            WorkloadIdentity = workloadIdentity;
            AccountKey = accountKey;
            Sa = sa;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sa as object ??
            AccountKey as object ??
            WorkloadIdentity as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkloadIdentity?.ToString() ??
            AccountKey?.ToString() ??
            Sa?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkloadIdentity && !IsAccountKey && !IsSa || !IsWorkloadIdentity && IsAccountKey && !IsSa || !IsWorkloadIdentity && !IsAccountKey && IsSa;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig, TResult>? workloadIdentity = null,
            global::System.Func<global::LangSmith.SandboxesProxyAzureAccountKeyConfig, TResult>? accountKey = null,
            global::System.Func<global::LangSmith.SandboxesProxyAzureSASConfig, TResult>? sa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkloadIdentity is { } __value0 && workloadIdentity != null)
            {
                return workloadIdentity(__value0);
            }
            else if (AccountKey is { } __value1 && accountKey != null)
            {
                return accountKey(__value1);
            }
            else if (Sa is { } __value2 && sa != null)
            {
                return sa(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig>? workloadIdentity = null,

            global::System.Action<global::LangSmith.SandboxesProxyAzureAccountKeyConfig>? accountKey = null,

            global::System.Action<global::LangSmith.SandboxesProxyAzureSASConfig>? sa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkloadIdentity is { } __value0)
            {
                workloadIdentity?.Invoke(__value0);
            }
            else if (AccountKey is { } __value1)
            {
                accountKey?.Invoke(__value1);
            }
            else if (Sa is { } __value2)
            {
                sa?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig>? workloadIdentity = null,
            global::System.Action<global::LangSmith.SandboxesProxyAzureAccountKeyConfig>? accountKey = null,
            global::System.Action<global::LangSmith.SandboxesProxyAzureSASConfig>? sa = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkloadIdentity is { } __value0)
            {
                workloadIdentity?.Invoke(__value0);
            }
            else if (AccountKey is { } __value1)
            {
                accountKey?.Invoke(__value1);
            }
            else if (Sa is { } __value2)
            {
                sa?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkloadIdentity,
                typeof(global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig),
                AccountKey,
                typeof(global::LangSmith.SandboxesProxyAzureAccountKeyConfig),
                Sa,
                typeof(global::LangSmith.SandboxesProxyAzureSASConfig),
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
        public bool Equals(SandboxesProxyAzureConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig?>.Default.Equals(WorkloadIdentity, other.WorkloadIdentity) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyAzureAccountKeyConfig?>.Default.Equals(AccountKey, other.AccountKey) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyAzureSASConfig?>.Default.Equals(Sa, other.Sa)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesProxyAzureConfig obj1, SandboxesProxyAzureConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesProxyAzureConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesProxyAzureConfig obj1, SandboxesProxyAzureConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesProxyAzureConfig o && Equals(o);
        }
    }
}
