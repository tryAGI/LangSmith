#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesSandboxGCPMountAuthConfig : global::System.IEquatable<SandboxesSandboxGCPMountAuthConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? WorkloadIdentity { get; init; }
#else
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? WorkloadIdentity { get; }
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
            out global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? value)
        {
            value = WorkloadIdentity;
            return IsWorkloadIdentity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig PickWorkloadIdentity() => WorkloadIdentity is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkloadIdentity' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? ServiceAccount { get; init; }
#else
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? ServiceAccount { get; }
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
            out global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? value)
        {
            value = ServiceAccount;
            return IsServiceAccount;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig PickServiceAccount() => ServiceAccount is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccount' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxGCPMountAuthConfig(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig value) => new SandboxesSandboxGCPMountAuthConfig((global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig?(SandboxesSandboxGCPMountAuthConfig @this) => @this.WorkloadIdentity;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxGCPMountAuthConfig(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? value)
        {
            WorkloadIdentity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxGCPMountAuthConfig FromWorkloadIdentity(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? value) => new SandboxesSandboxGCPMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxGCPMountAuthConfig(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig value) => new SandboxesSandboxGCPMountAuthConfig((global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig?(SandboxesSandboxGCPMountAuthConfig @this) => @this.ServiceAccount;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxGCPMountAuthConfig(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? value)
        {
            ServiceAccount = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxGCPMountAuthConfig FromServiceAccount(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? value) => new SandboxesSandboxGCPMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxGCPMountAuthConfig(
            global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? workloadIdentity,
            global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? serviceAccount
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
            global::System.Func<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig, TResult>? workloadIdentity = null,
            global::System.Func<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig, TResult>? serviceAccount = null,
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
            global::System.Action<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig>? workloadIdentity = null,

            global::System.Action<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig>? serviceAccount = null,
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
            global::System.Action<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig>? workloadIdentity = null,
            global::System.Action<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig>? serviceAccount = null,
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
                typeof(global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig),
                ServiceAccount,
                typeof(global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig),
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
        public bool Equals(SandboxesSandboxGCPMountAuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig?>.Default.Equals(WorkloadIdentity, other.WorkloadIdentity) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig?>.Default.Equals(ServiceAccount, other.ServiceAccount)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesSandboxGCPMountAuthConfig obj1, SandboxesSandboxGCPMountAuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesSandboxGCPMountAuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesSandboxGCPMountAuthConfig obj1, SandboxesSandboxGCPMountAuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesSandboxGCPMountAuthConfig o && Equals(o);
        }
    }
}
