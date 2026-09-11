
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxesDownloadURLPayloadCspSandboxFlag
    {
        /// <summary>
        ///
        /// </summary>
        AllowDownloads,
        /// <summary>
        ///
        /// </summary>
        AllowForms,
        /// <summary>
        ///
        /// </summary>
        AllowModals,
        /// <summary>
        ///
        /// </summary>
        AllowOrientationLock,
        /// <summary>
        ///
        /// </summary>
        AllowPointerLock,
        /// <summary>
        ///
        /// </summary>
        AllowPopups,
        /// <summary>
        ///
        /// </summary>
        AllowPresentation,
        /// <summary>
        ///
        /// </summary>
        AllowScripts,
        /// <summary>
        ///
        /// </summary>
        AllowTopNavigationByUserActivation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesDownloadURLPayloadCspSandboxFlagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesDownloadURLPayloadCspSandboxFlag value)
        {
            return value switch
            {
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowDownloads => "allow-downloads",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowForms => "allow-forms",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowModals => "allow-modals",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowOrientationLock => "allow-orientation-lock",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowPointerLock => "allow-pointer-lock",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowPopups => "allow-popups",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowPresentation => "allow-presentation",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowScripts => "allow-scripts",
                SandboxesDownloadURLPayloadCspSandboxFlag.AllowTopNavigationByUserActivation => "allow-top-navigation-by-user-activation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesDownloadURLPayloadCspSandboxFlag? ToEnum(string value)
        {
            return value switch
            {
                "allow-downloads" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowDownloads,
                "allow-forms" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowForms,
                "allow-modals" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowModals,
                "allow-orientation-lock" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowOrientationLock,
                "allow-pointer-lock" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowPointerLock,
                "allow-popups" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowPopups,
                "allow-presentation" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowPresentation,
                "allow-scripts" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowScripts,
                "allow-top-navigation-by-user-activation" => SandboxesDownloadURLPayloadCspSandboxFlag.AllowTopNavigationByUserActivation,
                _ => null,
            };
        }
    }
}