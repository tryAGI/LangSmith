
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum SavedRunClusteringJobRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SavedRunClusteringJobRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SavedRunClusteringJobRequestModel value)
        {
            return value switch
            {
                SavedRunClusteringJobRequestModel.Anthropic => "anthropic",
                SavedRunClusteringJobRequestModel.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SavedRunClusteringJobRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => SavedRunClusteringJobRequestModel.Anthropic,
                "openai" => SavedRunClusteringJobRequestModel.Openai,
                _ => null,
            };
        }
    }
}