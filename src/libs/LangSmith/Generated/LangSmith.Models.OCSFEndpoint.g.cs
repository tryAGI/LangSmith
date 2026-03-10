
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF network endpoint object.
    /// </summary>
    public sealed partial class OCSFEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intermediate_ips")]
        public global::System.Collections.Generic.IList<string>? IntermediateIps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFEndpoint" /> class.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="intermediateIps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFEndpoint(
            string? ip,
            int? port,
            global::System.Collections.Generic.IList<string>? intermediateIps)
        {
            this.Ip = ip;
            this.Port = port;
            this.IntermediateIps = intermediateIps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFEndpoint" /> class.
        /// </summary>
        public OCSFEndpoint()
        {
        }
    }
}