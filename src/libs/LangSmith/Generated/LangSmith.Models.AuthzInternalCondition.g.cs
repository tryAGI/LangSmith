
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthzInternalCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_key")]
        public string? AttributeKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameJsonConverter))]
        public global::LangSmith.AuthzInternalAbacAttributeName? AttributeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_value")]
        public string? AttributeValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthzInternalAbacOperatorJsonConverter))]
        public global::LangSmith.AuthzInternalAbacOperator? Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalCondition" /> class.
        /// </summary>
        /// <param name="attributeKey"></param>
        /// <param name="attributeName"></param>
        /// <param name="attributeValue"></param>
        /// <param name="operator"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthzInternalCondition(
            string? attributeKey,
            global::LangSmith.AuthzInternalAbacAttributeName? attributeName,
            string? attributeValue,
            global::LangSmith.AuthzInternalAbacOperator? @operator)
        {
            this.AttributeKey = attributeKey;
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzInternalCondition" /> class.
        /// </summary>
        public AuthzInternalCondition()
        {
        }
    }
}