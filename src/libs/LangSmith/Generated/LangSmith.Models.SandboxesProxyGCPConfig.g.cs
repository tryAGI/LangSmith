#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesProxyGCPConfig : global::System.IEquatable<SandboxesProxyGCPConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? WorkloadIdentity { get; init; }
#else
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? WorkloadIdentity { get; }
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
            out global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? value)
        {
            value = WorkloadIdentity;
            return IsWorkloadIdentity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig PickWorkloadIdentity() => WorkloadIdentity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkloadIdentity' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? ServiceAccount { get; init; }
#else
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? ServiceAccount { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceAccount))]
#endif
        public bool IsServiceAccount => ServiceAccount != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServiceAccount(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesProxyGCPServiceAccountConfig? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig PickServiceAccount() => ServiceAccount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyGCPConfig(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig value) => new SandboxesProxyGCPConfig((global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig?(SandboxesProxyGCPConfig @this) => @this.WorkloadIdentity;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyGCPConfig(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? value)
        {
            WorkloadIdentity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyGCPConfig FromWorkloadIdentity(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? value) => new SandboxesProxyGCPConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyGCPConfig(global::LangSmith.SandboxesProxyGCPServiceAccountConfig value) => new SandboxesProxyGCPConfig((global::LangSmith.SandboxesProxyGCPServiceAccountConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyGCPServiceAccountConfig?(SandboxesProxyGCPConfig @this) => @this.ServiceAccount;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyGCPConfig(global::LangSmith.SandboxesProxyGCPServiceAccountConfig? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyGCPConfig FromServiceAccount(global::LangSmith.SandboxesProxyGCPServiceAccountConfig? value) => new SandboxesProxyGCPConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyGCPConfig(
            global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? workloadIdentity,
            global::LangSmith.SandboxesProxyGCPServiceAccountConfig? serviceAccount
            )
        {
            WorkloadIdentity = workloadIdentity;
            ServiceAccount = serviceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServiceAccount as object ??
            WorkloadIdentity as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkloadIdentity?.ToString() ??
            ServiceAccount?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkloadIdentity && !IsServiceAccount || !IsWorkloadIdentity && IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig, TResult>? workloadIdentity = null,
            global::System.Func<global::LangSmith.SandboxesProxyGCPServiceAccountConfig, TResult>? serviceAccount = null,
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
            else if (ServiceAccount is { } __value1 && serviceAccount != null)
            {
                return serviceAccount(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig>? workloadIdentity = null,

            global::System.Action<global::LangSmith.SandboxesProxyGCPServiceAccountConfig>? serviceAccount = null,
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
            else if (ServiceAccount is { } __value1)
            {
                serviceAccount?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig>? workloadIdentity = null,
            global::System.Action<global::LangSmith.SandboxesProxyGCPServiceAccountConfig>? serviceAccount = null,
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
            else if (ServiceAccount is { } __value1)
            {
                serviceAccount?.Invoke(__value1);
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
                typeof(global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig),
                ServiceAccount,
                typeof(global::LangSmith.SandboxesProxyGCPServiceAccountConfig),
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
        public bool Equals(SandboxesProxyGCPConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig?>.Default.Equals(WorkloadIdentity, other.WorkloadIdentity) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyGCPServiceAccountConfig?>.Default.Equals(ServiceAccount, other.ServiceAccount)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesProxyGCPConfig obj1, SandboxesProxyGCPConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesProxyGCPConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesProxyGCPConfig obj1, SandboxesProxyGCPConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesProxyGCPConfig o && Equals(o);
        }
    }
}
