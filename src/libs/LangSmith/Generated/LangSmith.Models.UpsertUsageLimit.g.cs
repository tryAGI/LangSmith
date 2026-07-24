
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request body for creating or updating a usage limit.
    /// </summary>
    public sealed partial class UpsertUsageLimit
    {
        /// <summary>
        /// Type of usage limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.UsageLimitType LimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LimitValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Granularity a limit applies to within a tenant.<br/>
        /// Default Value: workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.UsageLimitScopeJsonConverter))]
        public global::LangSmith.UsageLimitScope? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        public global::System.Guid? IdentityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertUsageLimit" /> class.
        /// </summary>
        /// <param name="limitType">
        /// Type of usage limit.
        /// </param>
        /// <param name="limitValue"></param>
        /// <param name="id"></param>
        /// <param name="scope">
        /// Granularity a limit applies to within a tenant.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="identityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertUsageLimit(
            global::LangSmith.UsageLimitType limitType,
            int limitValue,
            global::System.Guid? id,
            global::LangSmith.UsageLimitScope? scope,
            global::System.Guid? sessionId,
            global::System.Guid? identityId)
        {
            this.LimitType = limitType;
            this.LimitValue = limitValue;
            this.Id = id;
            this.Scope = scope;
            this.SessionId = sessionId;
            this.IdentityId = identityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertUsageLimit" /> class.
        /// </summary>
        public UpsertUsageLimit()
        {
        }

    }
}