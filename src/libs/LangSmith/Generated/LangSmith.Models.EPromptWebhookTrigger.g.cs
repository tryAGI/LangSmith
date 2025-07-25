
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
        /// <summary>
        /// 
        /// </summary>
        Tag_create,
        /// <summary>
        /// 
        /// </summary>
        Tag_update,
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
                EPromptWebhookTrigger.Tag_create => "tag:create",
                EPromptWebhookTrigger.Tag_update => "tag:update",
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
                "tag:create" => EPromptWebhookTrigger.Tag_create,
                "tag:update" => EPromptWebhookTrigger.Tag_update,
                _ => null,
            };
        }
    }
}