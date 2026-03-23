
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
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Head,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
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
                ProxyRequestMethod.Delete => "DELETE",
                ProxyRequestMethod.Get => "GET",
                ProxyRequestMethod.Head => "HEAD",
                ProxyRequestMethod.Options => "OPTIONS",
                ProxyRequestMethod.Patch => "PATCH",
                ProxyRequestMethod.Post => "POST",
                ProxyRequestMethod.Put => "PUT",
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
                "DELETE" => ProxyRequestMethod.Delete,
                "GET" => ProxyRequestMethod.Get,
                "HEAD" => ProxyRequestMethod.Head,
                "OPTIONS" => ProxyRequestMethod.Options,
                "PATCH" => ProxyRequestMethod.Patch,
                "POST" => ProxyRequestMethod.Post,
                "PUT" => ProxyRequestMethod.Put,
                _ => null,
            };
        }
    }
}