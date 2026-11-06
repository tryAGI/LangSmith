
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// UPDATED if the example's metadata was changed; NOT_FOUND if the example is not in<br/>
    /// the dataset or was deleted.
    /// </summary>
    public enum ExamplesBulkUpdateMetadataStatusStatus
    {
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExamplesBulkUpdateMetadataStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExamplesBulkUpdateMetadataStatusStatus value)
        {
            return value switch
            {
                ExamplesBulkUpdateMetadataStatusStatus.NotFound => "NOT_FOUND",
                ExamplesBulkUpdateMetadataStatusStatus.Updated => "UPDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExamplesBulkUpdateMetadataStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "NOT_FOUND" => ExamplesBulkUpdateMetadataStatusStatus.NotFound,
                "UPDATED" => ExamplesBulkUpdateMetadataStatusStatus.Updated,
                _ => null,
            };
        }
    }
}