
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesDownloadURLPayloadCspSourceBundle
    {
        /// <summary>
        ///
        /// </summary>
        Cdnjs,
        /// <summary>
        ///
        /// </summary>
        GoogleFonts,
        /// <summary>
        ///
        /// </summary>
        Jsdelivr,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Unpkg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesDownloadURLPayloadCspSourceBundleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesDownloadURLPayloadCspSourceBundle value)
        {
            return value switch
            {
                SandboxesDownloadURLPayloadCspSourceBundle.Cdnjs => "cdnjs",
                SandboxesDownloadURLPayloadCspSourceBundle.GoogleFonts => "google-fonts",
                SandboxesDownloadURLPayloadCspSourceBundle.Jsdelivr => "jsdelivr",
                SandboxesDownloadURLPayloadCspSourceBundle.None => "none",
                SandboxesDownloadURLPayloadCspSourceBundle.Unpkg => "unpkg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesDownloadURLPayloadCspSourceBundle? ToEnum(string value)
        {
            return value switch
            {
                "cdnjs" => SandboxesDownloadURLPayloadCspSourceBundle.Cdnjs,
                "google-fonts" => SandboxesDownloadURLPayloadCspSourceBundle.GoogleFonts,
                "jsdelivr" => SandboxesDownloadURLPayloadCspSourceBundle.Jsdelivr,
                "none" => SandboxesDownloadURLPayloadCspSourceBundle.None,
                "unpkg" => SandboxesDownloadURLPayloadCspSourceBundle.Unpkg,
                _ => null,
            };
        }
    }
}