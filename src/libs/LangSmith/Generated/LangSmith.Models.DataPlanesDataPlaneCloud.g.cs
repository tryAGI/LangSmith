
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DataPlanesDataPlaneCloud
    {
        /// <summary>
        ///
        /// </summary>
        DataPlaneCloudAWS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataPlanesDataPlaneCloudExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataPlanesDataPlaneCloud value)
        {
            return value switch
            {
                DataPlanesDataPlaneCloud.DataPlaneCloudAWS => "AWS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataPlanesDataPlaneCloud? ToEnum(string value)
        {
            return value switch
            {
                "AWS" => DataPlanesDataPlaneCloud.DataPlaneCloudAWS,
                _ => null,
            };
        }
    }
}