
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
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
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
                CreateRunClusteringJobRequestModel.Anthropic => "anthropic",
                CreateRunClusteringJobRequestModel.Openai => "openai",
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
                "anthropic" => CreateRunClusteringJobRequestModel.Anthropic,
                "openai" => CreateRunClusteringJobRequestModel.Openai,
                _ => null,
            };
        }
    }
}