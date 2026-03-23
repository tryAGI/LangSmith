
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: openai
    /// </summary>
    public enum GenerateClusteringJobConfigRequestModel
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
    public static class GenerateClusteringJobConfigRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateClusteringJobConfigRequestModel value)
        {
            return value switch
            {
                GenerateClusteringJobConfigRequestModel.Anthropic => "anthropic",
                GenerateClusteringJobConfigRequestModel.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateClusteringJobConfigRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => GenerateClusteringJobConfigRequestModel.Anthropic,
                "openai" => GenerateClusteringJobConfigRequestModel.Openai,
                _ => null,
            };
        }
    }
}