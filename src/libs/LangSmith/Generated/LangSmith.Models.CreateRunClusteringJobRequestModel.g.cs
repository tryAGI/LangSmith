
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: openai
    /// </summary>
    public enum CreateRunClusteringJobRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunClusteringJobRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunClusteringJobRequestModel value)
        {
            return value switch
            {
                CreateRunClusteringJobRequestModel.Openai => "openai",
                CreateRunClusteringJobRequestModel.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunClusteringJobRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "openai" => CreateRunClusteringJobRequestModel.Openai,
                "anthropic" => CreateRunClusteringJobRequestModel.Anthropic,
                _ => null,
            };
        }
    }
}