
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for dataset transformation types.<br/>
    /// Ordering determines the order in which transformations are applied if there are multiple transformations on the same path.
    /// </summary>
    public enum DatasetTransformationType
    {
        /// <summary>
        /// 
        /// </summary>
        ConvertToOpenaiMessage,
        /// <summary>
        /// 
        /// </summary>
        ConvertToOpenaiTool,
        /// <summary>
        /// 
        /// </summary>
        RemoveSystemMessages,
        /// <summary>
        /// 
        /// </summary>
        RemoveExtraFields,
        /// <summary>
        /// 
        /// </summary>
        ExtractToolsFromRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetTransformationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetTransformationType value)
        {
            return value switch
            {
                DatasetTransformationType.ConvertToOpenaiMessage => "convert_to_openai_message",
                DatasetTransformationType.ConvertToOpenaiTool => "convert_to_openai_tool",
                DatasetTransformationType.RemoveSystemMessages => "remove_system_messages",
                DatasetTransformationType.RemoveExtraFields => "remove_extra_fields",
                DatasetTransformationType.ExtractToolsFromRun => "extract_tools_from_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetTransformationType? ToEnum(string value)
        {
            return value switch
            {
                "convert_to_openai_message" => DatasetTransformationType.ConvertToOpenaiMessage,
                "convert_to_openai_tool" => DatasetTransformationType.ConvertToOpenaiTool,
                "remove_system_messages" => DatasetTransformationType.RemoveSystemMessages,
                "remove_extra_fields" => DatasetTransformationType.RemoveExtraFields,
                "extract_tools_from_run" => DatasetTransformationType.ExtractToolsFromRun,
                _ => null,
            };
        }
    }
}