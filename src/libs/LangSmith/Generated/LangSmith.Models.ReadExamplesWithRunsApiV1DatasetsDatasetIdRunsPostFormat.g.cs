
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response format, e.g., 'csv'
    /// </summary>
    public enum ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat value)
        {
            return value switch
            {
                ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat.Csv => "csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => ReadExamplesWithRunsApiV1DatasetsDatasetIdRunsPostFormat.Csv,
                _ => null,
            };
        }
    }
}