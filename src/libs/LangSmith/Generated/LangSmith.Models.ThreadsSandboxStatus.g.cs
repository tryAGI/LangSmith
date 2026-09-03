
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum ThreadsSandboxStatus
    {
        /// <summary>
        ///
        /// </summary>
        SandboxStatusDeleting,
        /// <summary>
        ///
        /// </summary>
        SandboxStatusFailed,
        /// <summary>
        ///
        /// </summary>
        SandboxStatusProvisioning,
        /// <summary>
        ///
        /// </summary>
        SandboxStatusReady,
        /// <summary>
        ///
        /// </summary>
        SandboxStatusStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsSandboxStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsSandboxStatus value)
        {
            return value switch
            {
                ThreadsSandboxStatus.SandboxStatusDeleting => "deleting",
                ThreadsSandboxStatus.SandboxStatusFailed => "failed",
                ThreadsSandboxStatus.SandboxStatusProvisioning => "provisioning",
                ThreadsSandboxStatus.SandboxStatusReady => "ready",
                ThreadsSandboxStatus.SandboxStatusStopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsSandboxStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleting" => ThreadsSandboxStatus.SandboxStatusDeleting,
                "failed" => ThreadsSandboxStatus.SandboxStatusFailed,
                "provisioning" => ThreadsSandboxStatus.SandboxStatusProvisioning,
                "ready" => ThreadsSandboxStatus.SandboxStatusReady,
                "stopped" => ThreadsSandboxStatus.SandboxStatusStopped,
                _ => null,
            };
        }
    }
}