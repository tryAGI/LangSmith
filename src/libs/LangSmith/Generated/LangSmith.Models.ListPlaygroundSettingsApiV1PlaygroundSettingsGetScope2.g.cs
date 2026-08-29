
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2
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
    public static class ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2 value)
        {
            return value switch
            {
                ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2.Organization => "organization",
                ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2? ToEnum(string value)
        {
            return value switch
            {
                "organization" => ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2.Organization,
                "workspace" => ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2.Workspace,
                _ => null,
            };
        }
    }
}