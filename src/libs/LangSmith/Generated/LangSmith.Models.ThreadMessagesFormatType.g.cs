
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for thread messages format types.
    /// </summary>
    public enum ThreadMessagesFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        AllMessages,
        /// <summary>
        /// 
        /// </summary>
        HumanAiPairs,
        /// <summary>
        /// 
        /// </summary>
        FirstHumanLastAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadMessagesFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadMessagesFormatType value)
        {
            return value switch
            {
                ThreadMessagesFormatType.AllMessages => "all_messages",
                ThreadMessagesFormatType.HumanAiPairs => "human_ai_pairs",
                ThreadMessagesFormatType.FirstHumanLastAi => "first_human_last_ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadMessagesFormatType? ToEnum(string value)
        {
            return value switch
            {
                "all_messages" => ThreadMessagesFormatType.AllMessages,
                "human_ai_pairs" => ThreadMessagesFormatType.HumanAiPairs,
                "first_human_last_ai" => ThreadMessagesFormatType.FirstHumanLastAi,
                _ => null,
            };
        }
    }
}