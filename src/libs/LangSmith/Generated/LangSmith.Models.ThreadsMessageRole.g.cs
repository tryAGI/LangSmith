
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Example: user
    /// </summary>
    public enum ThreadsMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadsMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadsMessageRole value)
        {
            return value switch
            {
                ThreadsMessageRole.Assistant => "assistant",
                ThreadsMessageRole.System => "system",
                ThreadsMessageRole.Tool => "tool",
                ThreadsMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadsMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ThreadsMessageRole.Assistant,
                "system" => ThreadsMessageRole.System,
                "tool" => ThreadsMessageRole.Tool,
                "user" => ThreadsMessageRole.User,
                _ => null,
            };
        }
    }
}