
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ForgeConfigurationsForgePR
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::LangSmith.ForgeConfigurationsForgePRUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfigurationsForgePR" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="draft"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="number"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="updatedAt"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForgeConfigurationsForgePR(
            string? createdAt,
            bool? draft,
            string? htmlUrl,
            int? number,
            string? state,
            string? title,
            string? updatedAt,
            global::LangSmith.ForgeConfigurationsForgePRUser? user)
        {
            this.CreatedAt = createdAt;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl;
            this.Number = number;
            this.State = state;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgeConfigurationsForgePR" /> class.
        /// </summary>
        public ForgeConfigurationsForgePR()
        {
        }
    }
}