#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesSandboxAzureMountAuthConfig : global::System.IEquatable<SandboxesSandboxAzureMountAuthConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? WorkloadIdentity { get; init; }
#else
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? WorkloadIdentity { get; }
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
            out global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? value)
        {
            value = WorkloadIdentity;
            return IsWorkloadIdentity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig PickWorkloadIdentity() => WorkloadIdentity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkloadIdentity' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? AccountKey { get; init; }
#else
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? AccountKey { get; }
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
            out global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? value)
        {
            value = AccountKey;
            return IsAccountKey;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig PickAccountKey() => AccountKey is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AccountKey' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Sa { get; init; }
#else
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Sa { get; }
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
            out global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? value)
        {
            value = Sa;
            return IsSa;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig PickSa() => Sa is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sa' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig value) => new SandboxesSandboxAzureMountAuthConfig((global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig?(SandboxesSandboxAzureMountAuthConfig @this) => @this.WorkloadIdentity;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? value)
        {
            WorkloadIdentity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxAzureMountAuthConfig FromWorkloadIdentity(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? value) => new SandboxesSandboxAzureMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig value) => new SandboxesSandboxAzureMountAuthConfig((global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig?(SandboxesSandboxAzureMountAuthConfig @this) => @this.AccountKey;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? value)
        {
            AccountKey = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxAzureMountAuthConfig FromAccountKey(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? value) => new SandboxesSandboxAzureMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig value) => new SandboxesSandboxAzureMountAuthConfig((global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig?(SandboxesSandboxAzureMountAuthConfig @this) => @this.Sa;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAzureMountAuthConfig(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? value)
        {
            Sa = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxAzureMountAuthConfig FromSa(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? value) => new SandboxesSandboxAzureMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAzureMountAuthConfig(
            global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? workloadIdentity,
            global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? accountKey,
            global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? sa
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
            global::System.Func<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig, TResult>? workloadIdentity = null,
            global::System.Func<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig, TResult>? accountKey = null,
            global::System.Func<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig, TResult>? sa = null,
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
            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig>? workloadIdentity = null,

            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig>? accountKey = null,

            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig>? sa = null,
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
            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig>? workloadIdentity = null,
            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig>? accountKey = null,
            global::System.Action<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig>? sa = null,
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
                typeof(global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig),
                AccountKey,
                typeof(global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig),
                Sa,
                typeof(global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig),
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
        public bool Equals(SandboxesSandboxAzureMountAuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig?>.Default.Equals(WorkloadIdentity, other.WorkloadIdentity) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig?>.Default.Equals(AccountKey, other.AccountKey) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig?>.Default.Equals(Sa, other.Sa)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesSandboxAzureMountAuthConfig obj1, SandboxesSandboxAzureMountAuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesSandboxAzureMountAuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesSandboxAzureMountAuthConfig obj1, SandboxesSandboxAzureMountAuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesSandboxAzureMountAuthConfig o && Equals(o);
        }
    }
}
