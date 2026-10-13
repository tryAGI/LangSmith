
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DataPlanesDataPlaneTraceStorage
    {
        /// <summary>
        ///
        /// </summary>
        DataPlaneTraceStorageClickHouse,
        /// <summary>
        ///
        /// </summary>
        DataPlaneTraceStorageSmithDB,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataPlanesDataPlaneTraceStorageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataPlanesDataPlaneTraceStorage value)
        {
            return value switch
            {
                DataPlanesDataPlaneTraceStorage.DataPlaneTraceStorageClickHouse => "CLICKHOUSE",
                DataPlanesDataPlaneTraceStorage.DataPlaneTraceStorageSmithDB => "SMITHDB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataPlanesDataPlaneTraceStorage? ToEnum(string value)
        {
            return value switch
            {
                "CLICKHOUSE" => DataPlanesDataPlaneTraceStorage.DataPlaneTraceStorageClickHouse,
                "SMITHDB" => DataPlanesDataPlaneTraceStorage.DataPlaneTraceStorageSmithDB,
                _ => null,
            };
        }
    }
}