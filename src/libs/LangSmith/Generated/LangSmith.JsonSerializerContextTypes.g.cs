
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
        public global::LangSmith.APIKeyCreateResponse? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.APIKeyGetResponse? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AccessScope? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllowedLoginMethodsUpdate? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type32 { get; set; }
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
        public global::LangSmith.CustomerVisiblePlanInfo? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Dataset? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetCreate? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexInfo? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetIndexRequest? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing>? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DatasetVersion? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.DemoConfig? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Example? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleSelect? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRuns? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchema? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TraceTier? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExampleWithRunsGroup? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRuns>? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSession? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackSource3? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterView? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewType? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessage? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageType? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunk? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FunctionMessageChunkType? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsGroup>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ValidationError>? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ValidationError? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Highlight? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessage? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageType? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunk? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.HumanMessageChunkType? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Identity? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityCreate? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.IdentityPatch? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InfoGetResponse? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListCommitsResponse? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitWithLookups>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string?>? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposResponse? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object?>? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResourceType? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagCount? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.MemberIdentity? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OAuthProvider? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptimConfig? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrgUsage? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Organization? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Wallet? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentity? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PermissionResponse? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayload? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessage? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageType? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessage? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageType? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageStatus? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunk? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SystemMessageChunkType? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunk? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkType? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ToolMessageChunkStatus? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetBatchRequestSchema? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunnableConfig? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<object>, object>? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundRunOverDatasetRequestSchema? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhook? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsFormat? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTag? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Resource? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Role? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupBy? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunGroupStats? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunShareSchema? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStats? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProvider? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetRequest? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchDatasetResponse? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SearchedFewShotExample>? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SearchedFewShotExample? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretKey? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SecretUpsert? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccount? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.SourceType? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeAccountLinksCreate? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeTaxId? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsConfirm? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TTLSettings? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKey? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValue? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Tagging? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueCreate? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingCreate? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantCreate? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantForUser? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantMembers? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareDatasetTokenType? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareRunTokenType? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.EntitiesItem? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantStats? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimitType? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UsageLimit? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.UserWithPassword? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppHubCrudTenantsTenant? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AppSchemasTenant? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackCategory? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackConfig? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFeedbackCategory>? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackType? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackCreateSchema? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackFeedbackSource? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsRun? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFeedbackCreateSchema>? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request2? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request3? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Request4? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsPublic? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1?, global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2?>? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant1? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortDirectionVariant2? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsPublic? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretKey>? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response26>? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response26? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response29>? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response29? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response32>? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response32? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response36>? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response36? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response39>? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response39? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response42>? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response42? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.Response45>? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.Response45? Type624 { get; set; }
    }
}