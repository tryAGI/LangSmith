
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessage? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, object>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageType? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCall>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCall? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallType? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvalidToolCall? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvalidToolCallType? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageMetadata? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InputTokenDetails? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OutputTokenDetails? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageChunk? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AIMessageChunkType? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallChunk? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolCallChunkType? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIFeedbackSource? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyCreateRequest? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyCreateResponse? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyGetResponse? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AccessScope? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllowedLoginMethodsUpdate? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueCreateSchema? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunSchema? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueRunUpdateSchema? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchema? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubric? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSize? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueSizeSchema? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchema? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Artifact? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ArtifactContent>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ArtifactContent? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AuthProvider? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AutoEvalFeedbackSource? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthMemberCreate? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BasicAuthUserPatch? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BatchIngestConfig? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyParamsForRunSchema? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunTypeEnum? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsFilterDataSourceTypeEnum? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSelect>? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSelect? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunDateOrder? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyExecuteApiV1AceExecutePost? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DataType? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExport? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportFormat? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCompression? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportStatus? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportCreate? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestination? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationType? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Config? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationCreate? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Credentials? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRun? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunMetadata? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunProgress? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportRunStatus? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdate? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.BulkExportUpdateStatus? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanReq? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChangePaymentPlanSchema? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessage? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageType? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunk? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ChatMessageChunkType? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CodeEvaluatorTopLevel? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Comment? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitManifestResponse? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoExampleResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CommitWithLookups? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperiment? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SimpleExperimentInfo? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentBase? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ComparativeExperimentCreate? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ConfiguredBy? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateCommentRequest? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequest? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateEventRequestEventType? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateFeedbackConfigSchema? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfig? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackType? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitRequest? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoCommitResponse? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoRequest? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRepoResponse? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoWithLookups? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CreateRoleRequest? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreate? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartType? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesCreate? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesFilters? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartMetric? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HostProjectChartMetric? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBy? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartCreatePreview? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries>? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeries? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, string>? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponse? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartPreviewRequest? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequestBase? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartResponse? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartSeriesUpdate? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartUpdate? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Missing? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MissingMissing1? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponse>? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponse? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartSubSectionResponse? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionRequest? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomChartsSectionsCloneRequest? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomerInfo? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Dataset? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetCreate? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexInfo? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexRequest? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetVersion? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DemoConfig? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Example? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleSelect? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRuns? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchema? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TraceTier? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsGroup? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSession? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSource3? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterView? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewType? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessage? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageType? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunk? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunkType? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsGroup>? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ValidationError>? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ValidationError? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Highlight? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessage? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageType? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunk? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunkType? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Identity? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityCreate? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityPatch? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InfoGetResponse? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommitsResponse? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups>? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string?>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposResponse? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object?>? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResourceType? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagCount? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MemberIdentity? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OAuthProvider? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptimConfig? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgUsage? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Organization? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Wallet? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentity? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PermissionResponse? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayload? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessage? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageType? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessage? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageType? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageStatus? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunk? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunkType? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunk? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkType? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkStatus? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetBatchRequestSchema? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunnableConfig? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<object>, object>? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunnerContextEnum? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetRequestSchema? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhook? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsFormat? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTag? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Resource? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Role? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupBy? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupStats? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunShareSchema? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStats? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsSelect? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProvider? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetRequest? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetResponse? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample>? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchedFewShotExample? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretKey? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretUpsert? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccount? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountWorkspaceAssignment? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SourceType? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeAccountLinksCreate? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeTaxId? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsConfirm? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TTLSettings? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKey? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValue? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Tagging? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueCreate? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingCreate? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantCreate? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantForUser? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantMembers? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetTokenType? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunTokenType? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EntitiesItem? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantStats? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimitType? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimit? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UserWithPassword? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppHubCrudTenantsTenant? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppSchemasTenant? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackCategory? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackConfig? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFeedbackCategory>? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackType? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackCreateSchema? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackSource? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsRun? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFeedbackCreateSchema>? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request2? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request3? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request4? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsPublic? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretKey>? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response26>? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response26? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response29>? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response29? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response32>? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response32? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response36>? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response36? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response39>? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response39? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response42>? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response42? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response45>? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response45? Type630 { get; set; }
    }
}