
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF event metadata.
    /// </summary>
    public sealed partial class OCSFMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Uid { get; set; } = default!;

        /// <summary>
        /// OCSF product object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::LangSmith.OCSFProduct Product { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFMetadata" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="product">
        /// OCSF product object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFMetadata(
            global::System.Guid uid,
            global::LangSmith.OCSFProduct product)
        {
            this.Uid = uid;
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFMetadata" /> class.
        /// </summary>
        public OCSFMetadata()
        {
        }
    }
}