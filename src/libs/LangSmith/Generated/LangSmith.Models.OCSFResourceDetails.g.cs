
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF resource details object.
    /// </summary>
    public sealed partial class OCSFResourceDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFResourceDetails" /> class.
        /// </summary>
        /// <param name="uid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFResourceDetails(
            global::System.Guid uid)
        {
            this.Uid = uid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFResourceDetails" /> class.
        /// </summary>
        public OCSFResourceDetails()
        {
        }
    }
}