
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
        GET,
        /// <summary>
        /// 
        /// </summary>
        POST,
        /// <summary>
        /// 
        /// </summary>
        PUT,
        /// <summary>
        /// 
        /// </summary>
        DELETE,
        /// <summary>
        /// 
        /// </summary>
        PATCH,
        /// <summary>
        /// 
        /// </summary>
        HEAD,
        /// <summary>
        /// 
        /// </summary>
        OPTIONS,
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
                ProxyRequestMethod.GET => "GET",
                ProxyRequestMethod.POST => "POST",
                ProxyRequestMethod.PUT => "PUT",
                ProxyRequestMethod.DELETE => "DELETE",
                ProxyRequestMethod.PATCH => "PATCH",
                ProxyRequestMethod.HEAD => "HEAD",
                ProxyRequestMethod.OPTIONS => "OPTIONS",
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
                "GET" => ProxyRequestMethod.GET,
                "POST" => ProxyRequestMethod.POST,
                "PUT" => ProxyRequestMethod.PUT,
                "DELETE" => ProxyRequestMethod.DELETE,
                "PATCH" => ProxyRequestMethod.PATCH,
                "HEAD" => ProxyRequestMethod.HEAD,
                "OPTIONS" => ProxyRequestMethod.OPTIONS,
                _ => null,
            };
        }
    }
}