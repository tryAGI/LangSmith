
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DatasetInputFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        RemoveSystemMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetInputFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetInputFilterType value)
        {
            return value switch
            {
                DatasetInputFilterType.RemoveSystemMessages => "remove_system_messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetInputFilterType? ToEnum(string value)
        {
            return value switch
            {
                "remove_system_messages" => DatasetInputFilterType.RemoveSystemMessages,
                _ => null,
            };
        }
    }
}