
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DataPlanesDataPlaneTier
    {
        /// <summary>
        ///
        /// </summary>
        DataPlaneTierDev,
        /// <summary>
        ///
        /// </summary>
        DataPlaneTierProd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataPlanesDataPlaneTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataPlanesDataPlaneTier value)
        {
            return value switch
            {
                DataPlanesDataPlaneTier.DataPlaneTierDev => "DEV",
                DataPlanesDataPlaneTier.DataPlaneTierProd => "PROD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataPlanesDataPlaneTier? ToEnum(string value)
        {
            return value switch
            {
                "DEV" => DataPlanesDataPlaneTier.DataPlaneTierDev,
                "PROD" => DataPlanesDataPlaneTier.DataPlaneTierProd,
                _ => null,
            };
        }
    }
}