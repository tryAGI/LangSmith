
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// AnnotationQueue update schema.
    /// </summary>
    public sealed partial class AnnotationQueueUpdateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset")]
        public global::System.Guid? DefaultDataset { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reviewers_per_item")]
        public int? NumReviewersPerItem { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reservations")]
        public bool? EnableReservations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_minutes")]
        public int? ReservationMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_items")]
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? RubricItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_instructions")]
        public string? RubricInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes"></param>
        /// <param name="rubricItems"></param>
        /// <param name="rubricInstructions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueUpdateSchema(
            string? name,
            string? description,
            global::System.Guid? defaultDataset,
            int? numReviewersPerItem,
            bool? enableReservations,
            int? reservationMinutes,
            global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? rubricItems,
            string? rubricInstructions)
        {
            this.Name = name;
            this.Description = description;
            this.DefaultDataset = defaultDataset;
            this.NumReviewersPerItem = numReviewersPerItem;
            this.EnableReservations = enableReservations;
            this.ReservationMinutes = reservationMinutes;
            this.RubricItems = rubricItems;
            this.RubricInstructions = rubricInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateSchema" /> class.
        /// </summary>
        public AnnotationQueueUpdateSchema()
        {
        }
    }
}