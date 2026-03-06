
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Default Value: GET
    /// </summary>
    public enum ProxyRequestMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Head,
        /// <summary>
        /// 
        /// </summary>
        Options,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProxyRequestMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProxyRequestMethod value)
        {
            return value switch
            {
                ProxyRequestMethod.Get => "GET",
                ProxyRequestMethod.Post => "POST",
                ProxyRequestMethod.Put => "PUT",
                ProxyRequestMethod.Delete => "DELETE",
                ProxyRequestMethod.Patch => "PATCH",
                ProxyRequestMethod.Head => "HEAD",
                ProxyRequestMethod.Options => "OPTIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProxyRequestMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => ProxyRequestMethod.Get,
                "POST" => ProxyRequestMethod.Post,
                "PUT" => ProxyRequestMethod.Put,
                "DELETE" => ProxyRequestMethod.Delete,
                "PATCH" => ProxyRequestMethod.Patch,
                "HEAD" => ProxyRequestMethod.Head,
                "OPTIONS" => ProxyRequestMethod.Options,
                _ => null,
            };
        }
    }
}