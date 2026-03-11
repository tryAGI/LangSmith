
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// OCSF API Activity event (Class UID: 6003).<br/>
    /// This represents an API call event in the OCSF format.<br/>
    /// Reference: https://schema.ocsf.io/1.7.0/classes/api_activity<br/>
    /// Remember to try to validate the OCSF event against the official OCSF schema validator API: https://schema.ocsf.io/doc/index.html#/Tools/SchemaWeb.SchemaController.validate<br/>
    /// Or with `test_ocsf_validates_against_schema()` in test_audit_logs_models.py.
    /// </summary>
    public sealed partial class OCSFApiActivity
    {
        /// <summary>
        /// OCSF class UIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClassUid { get; set; }

        /// <summary>
        /// OCSF class names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OCSFClassNameJsonConverter))]
        public global::LangSmith.OCSFClassName ClassName { get; set; }

        /// <summary>
        /// OCSF category UIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CategoryUid { get; set; }

        /// <summary>
        /// OCSF category names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.OCSFCategoryNameJsonConverter))]
        public global::LangSmith.OCSFCategoryName CategoryName { get; set; }

        /// <summary>
        /// Severity levels for OCSF events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeverityId { get; set; }

        /// <summary>
        /// OCSF type UIDs for API Activity (class_uid * 100 + activity_id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TypeUid { get; set; }

        /// <summary>
        /// Activity types for API Activity class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityName { get; set; }

        /// <summary>
        /// Status values for OCSF events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Time { get; set; }

        /// <summary>
        /// OCSF event metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFMetadata Metadata { get; set; }

        /// <summary>
        /// OCSF API details object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFApi Api { get; set; }

        /// <summary>
        /// OCSF HTTP request object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFHttpRequest HttpRequest { get; set; }

        /// <summary>
        /// OCSF HTTP response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFHttpResponse HttpResponse { get; set; }

        /// <summary>
        /// OCSF actor object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFActor Actor { get; set; }

        /// <summary>
        /// OCSF network endpoint object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFEndpoint SrcEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails> Resources { get; set; }

        /// <summary>
        /// OCSF unmapped attribute for source-specific data.<br/>
        /// Reference: https://schema.ocsf.io/1.7.0/classes/base_event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmapped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.OCSFUnmapped Unmapped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFApiActivity" /> class.
        /// </summary>
        /// <param name="classUid">
        /// OCSF class UIDs.
        /// </param>
        /// <param name="className">
        /// OCSF class names.
        /// </param>
        /// <param name="categoryUid">
        /// OCSF category UIDs.
        /// </param>
        /// <param name="categoryName">
        /// OCSF category names.
        /// </param>
        /// <param name="severityId">
        /// Severity levels for OCSF events.
        /// </param>
        /// <param name="typeUid">
        /// OCSF type UIDs for API Activity (class_uid * 100 + activity_id).
        /// </param>
        /// <param name="activityId">
        /// Activity types for API Activity class.
        /// </param>
        /// <param name="activityName"></param>
        /// <param name="statusId">
        /// Status values for OCSF events.
        /// </param>
        /// <param name="status"></param>
        /// <param name="time"></param>
        /// <param name="metadata">
        /// OCSF event metadata.
        /// </param>
        /// <param name="api">
        /// OCSF API details object.
        /// </param>
        /// <param name="httpRequest">
        /// OCSF HTTP request object.
        /// </param>
        /// <param name="httpResponse">
        /// OCSF HTTP response object.
        /// </param>
        /// <param name="actor">
        /// OCSF actor object.
        /// </param>
        /// <param name="srcEndpoint">
        /// OCSF network endpoint object.
        /// </param>
        /// <param name="resources"></param>
        /// <param name="unmapped">
        /// OCSF unmapped attribute for source-specific data.<br/>
        /// Reference: https://schema.ocsf.io/1.7.0/classes/base_event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCSFApiActivity(
            int classUid,
            int categoryUid,
            int severityId,
            int typeUid,
            int activityId,
            string activityName,
            int statusId,
            string status,
            int time,
            global::LangSmith.OCSFMetadata metadata,
            global::LangSmith.OCSFApi api,
            global::LangSmith.OCSFHttpRequest httpRequest,
            global::LangSmith.OCSFHttpResponse httpResponse,
            global::LangSmith.OCSFActor actor,
            global::LangSmith.OCSFEndpoint srcEndpoint,
            global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails> resources,
            global::LangSmith.OCSFUnmapped unmapped,
            global::LangSmith.OCSFClassName className,
            global::LangSmith.OCSFCategoryName categoryName)
        {
            this.ClassUid = classUid;
            this.CategoryUid = categoryUid;
            this.SeverityId = severityId;
            this.TypeUid = typeUid;
            this.ActivityId = activityId;
            this.ActivityName = activityName ?? throw new global::System.ArgumentNullException(nameof(activityName));
            this.StatusId = statusId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Time = time;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Api = api ?? throw new global::System.ArgumentNullException(nameof(api));
            this.HttpRequest = httpRequest ?? throw new global::System.ArgumentNullException(nameof(httpRequest));
            this.HttpResponse = httpResponse ?? throw new global::System.ArgumentNullException(nameof(httpResponse));
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.SrcEndpoint = srcEndpoint ?? throw new global::System.ArgumentNullException(nameof(srcEndpoint));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.Unmapped = unmapped ?? throw new global::System.ArgumentNullException(nameof(unmapped));
            this.ClassName = className;
            this.CategoryName = categoryName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCSFApiActivity" /> class.
        /// </summary>
        public OCSFApiActivity()
        {
        }
    }
}