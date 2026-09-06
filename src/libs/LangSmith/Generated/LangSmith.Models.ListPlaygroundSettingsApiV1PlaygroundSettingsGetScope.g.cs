
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope
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
    public static class ListPlaygroundSettingsApiV1PlaygroundSettingsGetScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope value)
        {
            return value switch
            {
                ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope.Organization => "organization",
                ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? ToEnum(string value)
        {
            return value switch
            {
                "organization" => ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope.Organization,
                "workspace" => ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope.Workspace,
                _ => null,
            };
        }
    }
}