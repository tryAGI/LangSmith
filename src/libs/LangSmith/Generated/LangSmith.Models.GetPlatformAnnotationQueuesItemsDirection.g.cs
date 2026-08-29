
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: forward
    /// </summary>
    public enum GetPlatformAnnotationQueuesItemsDirection
    {
        /// <summary>
        ///
        /// </summary>
        Backward,
        /// <summary>
        ///
        /// </summary>
        Forward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPlatformAnnotationQueuesItemsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlatformAnnotationQueuesItemsDirection value)
        {
            return value switch
            {
                GetPlatformAnnotationQueuesItemsDirection.Backward => "backward",
                GetPlatformAnnotationQueuesItemsDirection.Forward => "forward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlatformAnnotationQueuesItemsDirection? ToEnum(string value)
        {
            return value switch
            {
                "backward" => GetPlatformAnnotationQueuesItemsDirection.Backward,
                "forward" => GetPlatformAnnotationQueuesItemsDirection.Forward,
                _ => null,
            };
        }
    }
}