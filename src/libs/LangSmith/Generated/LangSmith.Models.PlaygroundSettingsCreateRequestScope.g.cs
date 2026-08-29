
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: workspace
    /// </summary>
    public enum PlaygroundSettingsCreateRequestScope
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundSettingsCreateRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundSettingsCreateRequestScope value)
        {
            return value switch
            {
                PlaygroundSettingsCreateRequestScope.Organization => "organization",
                PlaygroundSettingsCreateRequestScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundSettingsCreateRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => PlaygroundSettingsCreateRequestScope.Organization,
                "workspace" => PlaygroundSettingsCreateRequestScope.Workspace,
                _ => null,
            };
        }
    }
}