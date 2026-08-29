
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPlatformAnnotationQueuesItemsItemType
    {
        /// <summary>
        ///
        /// </summary>
        Run,
        /// <summary>
        ///
        /// </summary>
        Thread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformAnnotationQueuesItemsItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformAnnotationQueuesItemsItemType value)
        {
            return value switch
            {
                GetPlatformAnnotationQueuesItemsItemType.Run => "RUN",
                GetPlatformAnnotationQueuesItemsItemType.Thread => "THREAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformAnnotationQueuesItemsItemType? ToEnum(string value)
        {
            return value switch
            {
                "RUN" => GetPlatformAnnotationQueuesItemsItemType.Run,
                "THREAD" => GetPlatformAnnotationQueuesItemsItemType.Thread,
                _ => null,
            };
        }
    }
}