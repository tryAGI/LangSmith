
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Valid trigger types for prompt webhooks.
    /// </summary>
    public enum EPromptWebhookTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        Commit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EPromptWebhookTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EPromptWebhookTrigger value)
        {
            return value switch
            {
                EPromptWebhookTrigger.Commit => "commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EPromptWebhookTrigger? ToEnum(string value)
        {
            return value switch
            {
                "commit" => EPromptWebhookTrigger.Commit,
                _ => null,
            };
        }
    }
}