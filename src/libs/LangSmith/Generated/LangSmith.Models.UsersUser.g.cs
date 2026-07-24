
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersUser
    {
        /// <summary>
        /// Example: ada@example.com
        /// </summary>
        /// <example>ada@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: Ada Lovelace
        /// </summary>
        /// <example>Ada Lovelace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersUser" /> class.
        /// </summary>
        /// <param name="email">
        /// Example: ada@example.com
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// Example: Ada Lovelace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersUser(
            string? email,
            global::System.Guid? id,
            string? name)
        {
            this.Email = email;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersUser" /> class.
        /// </summary>
        public UsersUser()
        {
        }

    }
}