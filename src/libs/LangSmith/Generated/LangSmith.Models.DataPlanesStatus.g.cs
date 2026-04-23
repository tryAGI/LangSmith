
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataPlanesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusActive,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusDeleted,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusDeprovisioning,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusInactive,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusProvisioning,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusProvisioningFailed,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusRequested,
        /// <summary>
        /// 
        /// </summary>
        DataPlaneStatusRevoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataPlanesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataPlanesStatus value)
        {
            return value switch
            {
                DataPlanesStatus.DataPlaneStatusActive => "active",
                DataPlanesStatus.DataPlaneStatusDeleted => "deleted",
                DataPlanesStatus.DataPlaneStatusDeprovisioning => "deprovisioning",
                DataPlanesStatus.DataPlaneStatusInactive => "inactive",
                DataPlanesStatus.DataPlaneStatusProvisioning => "provisioning",
                DataPlanesStatus.DataPlaneStatusProvisioningFailed => "provisioning_failed",
                DataPlanesStatus.DataPlaneStatusRequested => "requested",
                DataPlanesStatus.DataPlaneStatusRevoked => "revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataPlanesStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => DataPlanesStatus.DataPlaneStatusActive,
                "deleted" => DataPlanesStatus.DataPlaneStatusDeleted,
                "deprovisioning" => DataPlanesStatus.DataPlaneStatusDeprovisioning,
                "inactive" => DataPlanesStatus.DataPlaneStatusInactive,
                "provisioning" => DataPlanesStatus.DataPlaneStatusProvisioning,
                "provisioning_failed" => DataPlanesStatus.DataPlaneStatusProvisioningFailed,
                "requested" => DataPlanesStatus.DataPlaneStatusRequested,
                "revoked" => DataPlanesStatus.DataPlaneStatusRevoked,
                _ => null,
            };
        }
    }
}