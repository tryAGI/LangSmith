
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlayGroundGraphArtifactLength
    {
        /// <summary>
        /// 
        /// </summary>
        Shortest,
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Longest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlayGroundGraphArtifactLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlayGroundGraphArtifactLength value)
        {
            return value switch
            {
                PlayGroundGraphArtifactLength.Shortest => "shortest",
                PlayGroundGraphArtifactLength.Short => "short",
                PlayGroundGraphArtifactLength.Long => "long",
                PlayGroundGraphArtifactLength.Longest => "longest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlayGroundGraphArtifactLength? ToEnum(string value)
        {
            return value switch
            {
                "shortest" => PlayGroundGraphArtifactLength.Shortest,
                "short" => PlayGroundGraphArtifactLength.Short,
                "long" => PlayGroundGraphArtifactLength.Long,
                "longest" => PlayGroundGraphArtifactLength.Longest,
                _ => null,
            };
        }
    }
}