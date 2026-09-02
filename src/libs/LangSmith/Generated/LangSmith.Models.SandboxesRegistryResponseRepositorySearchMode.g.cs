
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesRegistryResponseRepositorySearchMode
    {
        /// <summary>
        ///
        /// </summary>
        Global,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Scoped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesRegistryResponseRepositorySearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesRegistryResponseRepositorySearchMode value)
        {
            return value switch
            {
                SandboxesRegistryResponseRepositorySearchMode.Global => "GLOBAL",
                SandboxesRegistryResponseRepositorySearchMode.None => "NONE",
                SandboxesRegistryResponseRepositorySearchMode.Scoped => "SCOPED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesRegistryResponseRepositorySearchMode? ToEnum(string value)
        {
            return value switch
            {
                "GLOBAL" => SandboxesRegistryResponseRepositorySearchMode.Global,
                "NONE" => SandboxesRegistryResponseRepositorySearchMode.None,
                "SCOPED" => SandboxesRegistryResponseRepositorySearchMode.Scoped,
                _ => null,
            };
        }
    }
}