
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataPlanesListPublicDataPlanesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_planes")]
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? DataPlanes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesListPublicDataPlanesResponse" /> class.
        /// </summary>
        /// <param name="dataPlanes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesListPublicDataPlanesResponse(
            global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? dataPlanes)
        {
            this.DataPlanes = dataPlanes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesListPublicDataPlanesResponse" /> class.
        /// </summary>
        public DataPlanesListPublicDataPlanesResponse()
        {
        }
    }
}