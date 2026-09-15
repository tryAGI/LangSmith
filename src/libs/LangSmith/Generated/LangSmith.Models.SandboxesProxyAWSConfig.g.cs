#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SandboxesProxyAWSConfig : global::System.IEquatable<SandboxesProxyAWSConfig>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Role { get; init; }
#else
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Role { get; }
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
            out global::LangSmith.SandboxesProxyAWSRoleConfig? value)
        {
            value = Role;
            return IsRole;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSRoleConfig PickRole() => IsRole
            ? Role!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Role' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Static { get; init; }
#else
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Static { get; }
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
            out global::LangSmith.SandboxesProxyAWSStaticConfig? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfig PickStatic() => IsStatic
            ? Static!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyAWSConfig(global::LangSmith.SandboxesProxyAWSRoleConfig value) => new SandboxesProxyAWSConfig((global::LangSmith.SandboxesProxyAWSRoleConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyAWSRoleConfig?(SandboxesProxyAWSConfig @this) => @this.Role;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAWSConfig(global::LangSmith.SandboxesProxyAWSRoleConfig? value)
        {
            Role = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyAWSConfig FromRole(global::LangSmith.SandboxesProxyAWSRoleConfig? value) => new SandboxesProxyAWSConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SandboxesProxyAWSConfig(global::LangSmith.SandboxesProxyAWSStaticConfig value) => new SandboxesProxyAWSConfig((global::LangSmith.SandboxesProxyAWSStaticConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SandboxesProxyAWSStaticConfig?(SandboxesProxyAWSConfig @this) => @this.Static;

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAWSConfig(global::LangSmith.SandboxesProxyAWSStaticConfig? value)
        {
            Static = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SandboxesProxyAWSConfig FromStatic(global::LangSmith.SandboxesProxyAWSStaticConfig? value) => new SandboxesProxyAWSConfig(value);

        /// <summary>
        ///
        /// </summary>
        public SandboxesProxyAWSConfig(
            global::LangSmith.SandboxesProxyAWSRoleConfig? role,
            global::LangSmith.SandboxesProxyAWSStaticConfig? @static
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
            global::System.Func<global::LangSmith.SandboxesProxyAWSRoleConfig, TResult>? role = null,
            global::System.Func<global::LangSmith.SandboxesProxyAWSStaticConfig, TResult>? @static = null,
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
            global::System.Action<global::LangSmith.SandboxesProxyAWSRoleConfig>? role = null,

            global::System.Action<global::LangSmith.SandboxesProxyAWSStaticConfig>? @static = null,
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
            global::System.Action<global::LangSmith.SandboxesProxyAWSRoleConfig>? role = null,
            global::System.Action<global::LangSmith.SandboxesProxyAWSStaticConfig>? @static = null,
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
                typeof(global::LangSmith.SandboxesProxyAWSRoleConfig),
                Static,
                typeof(global::LangSmith.SandboxesProxyAWSStaticConfig),
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
        public bool Equals(SandboxesProxyAWSConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyAWSRoleConfig?>.Default.Equals(Role, other.Role) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SandboxesProxyAWSStaticConfig?>.Default.Equals(Static, other.Static)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SandboxesProxyAWSConfig obj1, SandboxesProxyAWSConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SandboxesProxyAWSConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SandboxesProxyAWSConfig obj1, SandboxesProxyAWSConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SandboxesProxyAWSConfig o && Equals(o);
        }
    }
}
