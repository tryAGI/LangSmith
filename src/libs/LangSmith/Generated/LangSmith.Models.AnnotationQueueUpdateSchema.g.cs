
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// AnnotationQueue update schema.
    /// </summary>
    public sealed partial class AnnotationQueueUpdateSchema
    {
        /// <summary>
        /// New name for the queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Dataset that reviewed runs are added to by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset")]
        public global::System.Guid? DefaultDataset { get; set; }

        /// <summary>
        /// How many reviewers must review each run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_reviewers_per_item")]
        public int? NumReviewersPerItem { get; set; }

        /// <summary>
        /// Whether a reviewer reserves a run while reviewing it, so others skip it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reservations")]
        public bool? EnableReservations { get; set; }

        /// <summary>
        /// How long a reservation lasts, in minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reservation_minutes")]
        public int? ReservationMinutes { get; set; }

        /// <summary>
        /// Feedback keys reviewers fill in for each run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_items")]
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? RubricItems { get; set; }

        /// <summary>
        /// Instructions shown to reviewers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric_instructions")]
        public string? RubricInstructions { get; set; }

        /// <summary>
        /// Metadata to store on the queue. Replaces the existing metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Who completes a run: any (one reviewer is enough) or assigned (every assigned reviewer must submit).
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
        /// <param name="name">
        /// New name for the queue.
        /// </param>
        /// <param name="description">
        /// New description.
        /// </param>
        /// <param name="defaultDataset">
        /// Dataset that reviewed runs are added to by default.
        /// </param>
        /// <param name="numReviewersPerItem">
        /// How many reviewers must review each run.
        /// </param>
        /// <param name="enableReservations">
        /// Whether a reviewer reserves a run while reviewing it, so others skip it.
        /// </param>
        /// <param name="reservationMinutes">
        /// How long a reservation lasts, in minutes.
        /// </param>
        /// <param name="rubricItems">
        /// Feedback keys reviewers fill in for each run.
        /// </param>
        /// <param name="rubricInstructions">
        /// Instructions shown to reviewers.
        /// </param>
        /// <param name="metadata">
        /// Metadata to store on the queue. Replaces the existing metadata.
        /// </param>
        /// <param name="reviewerAccessMode">
        /// Who completes a run: any (one reviewer is enough) or assigned (every assigned reviewer must submit).
        /// </param>
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
            string? rubricInstructions,
            object? metadata,
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