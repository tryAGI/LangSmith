
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
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reviewers_per_item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? NumReviewersPerItem { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reservations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<bool?, global::LangSmith.Missing>? EnableReservations { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_minutes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? ReservationMinutes { get; set; }

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
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_access_mode")]
        public global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? ReviewerAccessMode { get; set; }

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
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="reservationMinutes">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="rubricItems"></param>
        /// <param name="rubricInstructions"></param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="reviewerAccessMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueUpdateSchema(
            string? name,
            string? description,
            global::System.Guid? defaultDataset,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? numReviewersPerItem,
            global::LangSmith.AnyOf<bool?, global::LangSmith.Missing>? enableReservations,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? reservationMinutes,
            global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? rubricItems,
            string? rubricInstructions,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata,
            global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? reviewerAccessMode)
        {
            this.Name = name;
            this.Description = description;
            this.DefaultDataset = defaultDataset;
            this.NumReviewersPerItem = numReviewersPerItem;
            this.EnableReservations = enableReservations;
            this.ReservationMinutes = reservationMinutes;
            this.RubricItems = rubricItems;
            this.RubricInstructions = rubricInstructions;
            this.Metadata = metadata;
            this.ReviewerAccessMode = reviewerAccessMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdateSchema" /> class.
        /// </summary>
        public AnnotationQueueUpdateSchema()
        {
        }

    }
}