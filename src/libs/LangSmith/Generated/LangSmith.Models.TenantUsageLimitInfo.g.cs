
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantUsageLimitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_reject_set")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InRejectSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter))]
        public global::LangSmith.TenantUsageLimitType? UsageLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_limit")]
        public int? TenantLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUsageLimitInfo" /> class.
        /// </summary>
        /// <param name="inRejectSet"></param>
        /// <param name="usageLimitType"></param>
        /// <param name="tenantLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TenantUsageLimitInfo(
            bool inRejectSet,
            global::LangSmith.TenantUsageLimitType? usageLimitType,
            int? tenantLimit)
        {
            this.InRejectSet = inRejectSet;
            this.UsageLimitType = usageLimitType;
            this.TenantLimit = tenantLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUsageLimitInfo" /> class.
        /// </summary>
        public TenantUsageLimitInfo()
        {
        }
    }
}