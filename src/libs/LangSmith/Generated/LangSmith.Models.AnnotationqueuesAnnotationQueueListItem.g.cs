
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueListItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public string? AddedAt { get; set; }

        /// <summary>
        /// Whether the item's reviewers agreed across its rubric keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreement_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgreementStateJsonConverter))]
        public global::LangSmith.AgreementState? AgreementState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_to")]
        public global::System.Collections.Generic.IList<string>? AssignedTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_by")]
        public global::System.Collections.Generic.IList<string>? CompletedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_added_at")]
        public string? EffectiveAddedAt { get; set; }

        /// <summary>
        /// True while a key the reviewers disagreed on has no final answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_unresolved_keys")]
        public bool? HasUnresolvedKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? ItemType { get; set; }

        /// <summary>
        /// The reviewers' result for each rubric key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_agreements")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.AnnotationqueuesItemKeyAgreement>? KeyAgreements { get; set; }

        /// <summary>
        /// LastReviewedTime is always present on the wire (null until reviewed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public string? LastReviewedTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        public string? QueueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reserved_by")]
        public global::System.Collections.Generic.IList<string>? ReservedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_proposed_example_id")]
        public string? SourceProposedExampleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueListItem" /> class.
        /// </summary>
        /// <param name="addedAt"></param>
        /// <param name="agreementState">
        /// Whether the item's reviewers agreed across its rubric keys.
        /// </param>
        /// <param name="assignedTo"></param>
        /// <param name="completedBy"></param>
        /// <param name="effectiveAddedAt"></param>
        /// <param name="hasUnresolvedKeys">
        /// True while a key the reviewers disagreed on has no final answer.
        /// </param>
        /// <param name="id"></param>
        /// <param name="itemType"></param>
        /// <param name="keyAgreements">
        /// The reviewers' result for each rubric key.
        /// </param>
        /// <param name="lastReviewedTime">
        /// LastReviewedTime is always present on the wire (null until reviewed).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="queueId"></param>
        /// <param name="reservedBy"></param>
        /// <param name="runId"></param>
        /// <param name="sourceProposedExampleId"></param>
        /// <param name="startTime"></param>
        /// <param name="threadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueListItem(
            string? addedAt,
            global::LangSmith.AgreementState? agreementState,
            global::System.Collections.Generic.IList<string>? assignedTo,
            global::System.Collections.Generic.IList<string>? completedBy,
            string? effectiveAddedAt,
            bool? hasUnresolvedKeys,
            string? id,
            global::LangSmith.AnnotationqueuesAnnotationQueueItemType? itemType,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.AnnotationqueuesItemKeyAgreement>? keyAgreements,
            string? lastReviewedTime,
            string? projectId,
            string? queueId,
            global::System.Collections.Generic.IList<string>? reservedBy,
            string? runId,
            string? sourceProposedExampleId,
            string? startTime,
            string? threadId)
        {
            this.AddedAt = addedAt;
            this.AgreementState = agreementState;
            this.AssignedTo = assignedTo;
            this.CompletedBy = completedBy;
            this.EffectiveAddedAt = effectiveAddedAt;
            this.HasUnresolvedKeys = hasUnresolvedKeys;
            this.Id = id;
            this.ItemType = itemType;
            this.KeyAgreements = keyAgreements;
            this.LastReviewedTime = lastReviewedTime;
            this.ProjectId = projectId;
            this.QueueId = queueId;
            this.ReservedBy = reservedBy;
            this.RunId = runId;
            this.SourceProposedExampleId = sourceProposedExampleId;
            this.StartTime = startTime;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueListItem" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueListItem()
        {
        }

    }
}