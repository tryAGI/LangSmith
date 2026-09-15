#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesSandboxAWSMountAuthConfig : global::System.IEquatable<SandboxesSandboxAWSMountAuthConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Role { get; init; }
#else
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Role { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Role))]
#endif
        public bool IsRole => Role != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRole(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? value)
        {
            value = Role;
            return IsRole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig PickRole() => IsRole
            ? Role!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Role' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Static { get; init; }
#else
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Static { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStatic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig PickStatic() => IsStatic
            ? Static!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxAWSMountAuthConfig(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig value) => new SandboxesSandboxAWSMountAuthConfig((global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig?(SandboxesSandboxAWSMountAuthConfig @this) => @this.Role;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAWSMountAuthConfig(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? value)
        {
            Role = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxAWSMountAuthConfig FromRole(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? value) => new SandboxesSandboxAWSMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesSandboxAWSMountAuthConfig(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig value) => new SandboxesSandboxAWSMountAuthConfig((global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig?(SandboxesSandboxAWSMountAuthConfig @this) => @this.Static;

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAWSMountAuthConfig(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? value)
        {
            Static = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesSandboxAWSMountAuthConfig FromStatic(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? value) => new SandboxesSandboxAWSMountAuthConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesSandboxAWSMountAuthConfig(
            global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? role,
            global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? @static
            )
        {
            Role = role;
            Static = @static;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Static as object ??
            Role as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Role?.ToString() ??
            Static?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRole && !IsStatic || !IsRole && IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig, TResult>? role = null,
            global::System.Func<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRole && role != null)
            {
                return role(Role!);
            }
            else if (IsStatic && @static != null)
            {
                return @static(Static!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig>? role = null,

            global::System.Action<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRole)
            {
                role?.Invoke(Role!);
            }
            else if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig>? role = null,
            global::System.Action<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRole)
            {
                role?.Invoke(Role!);
            }
            else if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Role,
                typeof(global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig),
                Static,
                typeof(global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig),
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
        public bool Equals(SandboxesSandboxAWSMountAuthConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig?>.Default.Equals(Role, other.Role) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig?>.Default.Equals(Static, other.Static)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesSandboxAWSMountAuthConfig obj1, SandboxesSandboxAWSMountAuthConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesSandboxAWSMountAuthConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesSandboxAWSMountAuthConfig obj1, SandboxesSandboxAWSMountAuthConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesSandboxAWSMountAuthConfig o && Equals(o);
        }
    }
}
