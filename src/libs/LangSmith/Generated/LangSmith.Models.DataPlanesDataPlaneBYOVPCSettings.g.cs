
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneBYOVPCSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_app_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? PrivateAppSubnetIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_db_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? PrivateDbSubnetIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_subnet_ids")]
        public global::System.Collections.Generic.IList<string>? PublicSubnetIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpc_id")]
        public string? VpcId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneBYOVPCSettings" /> class.
        /// </summary>
        /// <param name="privateAppSubnetIds"></param>
        /// <param name="privateDbSubnetIds"></param>
        /// <param name="publicSubnetIds"></param>
        /// <param name="vpcId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneBYOVPCSettings(
            global::System.Collections.Generic.IList<string>? privateAppSubnetIds,
            global::System.Collections.Generic.IList<string>? privateDbSubnetIds,
            global::System.Collections.Generic.IList<string>? publicSubnetIds,
            string? vpcId)
        {
            this.PrivateAppSubnetIds = privateAppSubnetIds;
            this.PrivateDbSubnetIds = privateDbSubnetIds;
            this.PublicSubnetIds = publicSubnetIds;
            this.VpcId = vpcId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneBYOVPCSettings" /> class.
        /// </summary>
        public DataPlanesDataPlaneBYOVPCSettings()
        {
        }

    }
}