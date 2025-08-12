
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The feedback source loaded from the database.
    /// </summary>
    public sealed partial class FeedbackSource3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public global::System.Guid? LsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string? UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSource3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="metadata"></param>
        /// <param name="userId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="userName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackSource3(
            string? type,
            object? metadata,
            global::System.Guid? userId,
            global::System.Guid? lsUserId,
            string? userName)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.UserId = userId;
            this.LsUserId = lsUserId;
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackSource3" /> class.
        /// </summary>
        public FeedbackSource3()
        {
        }
    }
}