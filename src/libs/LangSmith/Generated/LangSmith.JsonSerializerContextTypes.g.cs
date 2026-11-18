
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
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIFeedbackSource? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyCreateRequest? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyCreateResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AccessScope? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyGetResponse? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.APIKeyUpdateRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRepoOwnerRequest? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRunToQueueByKeyRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddRunToQueueRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertThreshold? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertThresholdKind? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllowedLoginMethodsUpdate? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueBulkDeleteRunsRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueCreateSchema? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRubricItemSchema? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditions? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackConfigSchema? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunAddSchema? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TraceTier? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunSchema? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueRunUpdateSchema? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchema? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaQueueType? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AssignedReviewerSchema>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AssignedReviewerSchema? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubric? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithRubricQueueType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSize? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSchemaWithSizeQueueType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueSizeSchema? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchema? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AppFeedbackSource? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AttachmentsOperations? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogAgentAccessToken? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogAgentAccessTokenTrigger? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogEnrichments? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogGateway? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogUpstream? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogServer? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogMessage? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuditLogOperation? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthProvider? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AutoEvalFeedbackSource? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthMemberCreate? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BasicAuthUserPatch? Type55 { get; set; }
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
        public global::LangSmith.BodyParamsForRunsQuerySchema? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.DateTime?, string>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyExecuteApiV1AceExecutePost? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataType? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3Config? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3ConfigAddressingStyle? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExport? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportFormat? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportFormatVersion? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportCompression? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportCreate? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestination? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationType? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Config? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationCreate? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationS3Credentials? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportDestinationUpdate? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRun? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunMetadata? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunStatus? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunMetadataExecutionBackend? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportRunProgress? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingUpload? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportUpdatableStatus? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkExportUpdate? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChangePaymentPlanReq? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChangePaymentPlanSchema? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ClusteringJobConfigResponse? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Guid?, string>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequest? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorInputType? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorLanguage? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CodeEvaluatorTopLevel? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Comment? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitManifestResponse? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoExampleResponse? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperiment? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SimpleExperimentInfo? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperimentBase? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ComparativeExperimentCreate? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeEvaluatorCreated? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeMigrationRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CompositeMigrationResult? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ConfiguredBy? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateClusteringJobConfigRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateClusteringJobConfigResponse? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateCommentRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateFeedbackConfigSchema? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackConfig? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequest? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequestRepoType? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoRequestSource? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookups? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRoleRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobRequestModel? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunClusteringJobResponse? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreate? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreateChartType? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesCreate? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesFilters? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartCreatePreview? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesInput>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesInput? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackCountMetric? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackCountMetricParams? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricPercentile? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricScalar? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFeedbackScoreMetricScalarParams? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFilterByDataset? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartFilterByTracingProject? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartGroupByComplex? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartGroupByPlain? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetric? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricCount? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricField? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricPercentile? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricPercentileParams? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricRatioInput? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricScalar? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartMetricRatioOutput? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartPreviewRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsRequestBase? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartResponseChartType? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesOutput>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesOutput? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HostProjectChartMetric? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBy? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesUpdate? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartSeriesV2Equivalent? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartType? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartUpdate? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsDataPoint? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<int?, double?, object>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsRequest? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TimedeltaInput? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsResponse? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSection? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ChartsItem>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ChartsItem? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerialized? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlock? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminator? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartSubSectionResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutOutput? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionCreate? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionUpdate? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutInput? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionsCloneRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockCreate? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlockResponse? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomerVisiblePlanInfo? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PaymentPlanTier? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutInput? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutRow>? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutRow? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardBreakpointLayoutOutput? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsInput? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutBreakpointsOutput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DashboardLayoutItem? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Dataset? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformation? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetCreate? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetDiffInfo? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetPublicSchema? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetSchemaForUpdate? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetShareSchema? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetTransformationType? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetUpdate? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdate? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetVersion? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestion? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelQuestionType? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchema? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaTemplateFormat? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DecisionModelQuestion>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DecisionModelRuleCreateSchemaProvider? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteClusteringJobConfigResponse? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRunClusteringJobResponse? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DemoConfig? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationAlgorithm? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobLogType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptOptimizationJobStatus? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EPromptWebhookTrigger? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluateExperimentRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorFeedbackMapping? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBody? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultBodyWindow? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorSpendDefaultResponse? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorStructuredOutput? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorTopLevel? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Example? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleGroupWithSessions? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?, double?>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedRunsSessionStats? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleWithRunsCH? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleListOrder? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleSelect? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleUpdateWithID? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExampleValidationResult? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaComparisonView? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentProgress? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultRow? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchema? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUpload? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentResultsUploadResult? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSession? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExportAnnotationQueueRunsRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCategory? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<object, string>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant12? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelFeedbackSource? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchema? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceVariant1? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1Discriminator? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackCreateWithTokenExtendedSchema? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, int?, bool?, string>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackDelta? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormula? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaAggregationType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaWeightedVariable? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreate? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaCreateAggregationType? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdate? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackFormulaUpdateAggregationType? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenCreateSchema? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackIngestTokenSchema? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackLevel? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSchema? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSource? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackSourceParam? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeedbackUpdateSchema? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FetchClusteringJobRunsResult? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterView? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreate? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewCreateType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewRename? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdate? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterViewUpdateType? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoRequest? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigRequestModel? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateClusteringJobConfigResponse? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GenerateSyntheticExamplesBody? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetClusteringJobConfigsResponse? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSelect? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoResponse? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusterResponse? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobResponse? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunCluster>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunCluster? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSummary? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunClusteringJobsResponse? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunClusteringJobPydantic? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetStartedPath? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageDimensions? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageGroupBy? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageKind? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageRecord? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageResponse? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GranularUsageStride? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupExampleRunsByField? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExamplesWithRunsResponse? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GroupedExperimentsRequest? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HTTPValidationError? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HealthInfoGetResponse? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HighlightedRun? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Identity? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityCreate? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IdentityPatch? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSlackSettings? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InsightsSlackSettingsInput? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InternalSecretsResponse? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InvokePromptPayload? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoRequest? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.LikeRepoResponse? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogOperationsResponse? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListAuditLogsOCSFResponse? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApiActivity? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCommentsResponse? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Comment>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicDatasetRunsResponse? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicDatasetSchema? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPublicRunsResponse? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunPublicSchema? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoOwnersResponse? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoOwner? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposResponse? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunsResponse? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchema>? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchema? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResourceType? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsResponse? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagCount>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagCount? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpToolsResponse? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberIdentity? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProviderUserSlim? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.MemberSortField? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapCreateSchema? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<double?, string>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapListResponse? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchema? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProviderSchema? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapProvidersResponse? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapProviderSchema>? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapSchemaScope? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ModelPriceMapUpdateSchema? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFActor? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUser? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFApi? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFClassName? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFCategoryName? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFMetadata? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpRequest? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFHttpResponse? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFEndpoint? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFResourceDetails? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUnmapped? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFUrl? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OCSFProduct? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobRequest? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptimConfig? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptResponse? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgDefaultApplyTo? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgDefaultMonthlyTraceLimit? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsage? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Organization? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlusPlanTransitionInfo? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationRoles? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentity? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityPatch? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PermissionResponse? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestScope? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseSettingsType? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProblemDetails? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhook? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProvisioningMethod? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequest? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequestMethod? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsRequest? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDeltaBatch? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QuerySessionFeedbackConfigIds? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueueInfoResponse? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RemoveRepoOwnerRequest? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTag? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsRepoType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsSource? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchema? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchemaSection? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Resource? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Role? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RoleRestrictionUpdate? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRule? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRuleOp? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionsJoin? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogsPaginatedResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupBy? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupStats? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaInput? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitWindow? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaOutput? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchemaGroupBy? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchemaGroupBy? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchema? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchemaGroupBy? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchema? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchemaGroupBy? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunShareSchema? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStats? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsSelect? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParamsPublic? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationError? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationResponse? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProvider? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMapping? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequestModel? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfig? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigSource? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigInput? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretUpsert? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccount? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountWorkspaceAssignment? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIds? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIdsPage? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SessionFeedbackConfigIds>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerializedChartType? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SourceType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeTaxId? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMappingKey? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TTLSettings? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKey? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValue? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueCreate? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tagging? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingCreate? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tenant? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantCreate? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantForUser? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantMembers? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareThreadToken? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EntitiesItem? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantStats? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleRequest? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleResponse? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadMessagesFormatType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadPreviewResponse? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyCreateRequest? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyListResponse? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TrueFalseLiteral? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateClusteringJobConfigRequest? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateGetStartedPathRequest? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateOrgDefaultMonthlyTraceLimit? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobResponse? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitScope? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimit? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserOnboardingStateResponse? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserWithPassword? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ValidationError? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, int?>? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceCreate? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceInviteResult? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspacePatch? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecret? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfig>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WorkspaceSecretUpsert? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailLookupRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AddressesResolveResponse? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepoInput>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepoInput? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentErrorResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentGithubRepo? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepohostProvider? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgent? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentIssuesAgentAnalysisLevel? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentGithubRepo>? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegration? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearSyncHealth? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetView? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthStatus? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentLinearIntegrationPatch? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInput? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetInputKind? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentRedTeamTargetViewKind? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewRequest? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentSaveOverviewResponse? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentTargetAuthInput? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequest? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgent? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentType? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentEnvironment>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironment? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentSourceType? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentCreate? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentEnvironmentName? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgentRuntimeBinding>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentRuntimeBinding? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentListResponse? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgent>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgentplatformAgentUpdate? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemInput? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItem? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerRequest? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerResponse? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueListItem? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthSandboxDelegationMode? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnOrganizationConfig? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnPublicAuthInfo? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacAttributeName? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacOperator? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicy? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalConditionGroup? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicyCreateResponse? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAttachAccessPoliciesPayload? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCondition? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalPermission? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCreateAccessPolicyPayload? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalListAccessPoliciesResponse? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalUpdateAccessPolicyPayload? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AwsResourceTag? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AzureResourceTag? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BackfillsRestartBackfillRequest? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitResponse? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsExampleRun? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitWithLookups? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitReq? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitResponse? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsListCommitsResponse? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettings? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant1? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant2? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestGCP? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneIngressSettings? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AzureResourceTag>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMSettings? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateErrorResponse? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneCloud? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFirewallSettings? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFleetOIDCSettings? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneProvisioningSettings? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTTLSettings? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesErrorResponse? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesMissingPermission? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesListPublicDataPlanesResponse? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlane? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesStatus? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlaneWorkspace? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneRequest? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsListDatasetsV2Response? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunSelectField? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2ExampleWithRuns? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunResponse? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitInfo? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitResponse? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCreateDirectoryCommitRequest? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInput? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryGetDirectoryResponse? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutput? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryErrorResponse? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ErrutilUserError? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluator? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluatorInput? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorBuildStatus? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorKey? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorRequest? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorType? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorResponse? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluator? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsErrorResponse? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsLLMEvaluator? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorRunRule? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendLimit? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsGetEvaluatorSpendResponse? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendGroup? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsListEvaluatorsResponse? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendDay? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorRequest? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataRequest? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperation? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatus? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperationOperation? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesDisableModelRequest? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesErrorResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesFeatureConfig? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesUpsertDefaultModelRequest? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsErrorResponse? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsValidationErrorResponse? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSubjectMatcher? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesGatewayPolicyRecord? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSpendUsage>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSpendUsage? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesRateLimitUsage>? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitUsage? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitMetric? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitWindow? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesErrorResponse? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HttperrErrorResponse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsEnvironmentEntry? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsErrorResponse? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsHubEnvironmentsModel? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoBatchIngestConfig? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoCustomerInfo? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoInfoGetResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoSDKVersions? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationCatalogEntry? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverride? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverrideUpdate? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesErrorResponse? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidence? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesSeriesEvidence? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidenceType? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesFix? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssue? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerification? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesFix>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearContext? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSync? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesStatus? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueType? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResult? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerificationStatus? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResultOutcome? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSyncState? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesListViewsResponse? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesViewedIssue? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricDefinition? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountOrg? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountProject? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountResponseList? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsRequest? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsResponse? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsErrorResponse? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsGetMcpVendorResponse? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendorStatus? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpGatewaysResponse? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGateway? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpVendorsResponse? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendor? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListVendorToolsResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsVendorTool? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayBinding? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayToolFilter? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizationServerMetadata? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizedAppView? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientPublicMetadata? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationRequest? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthCreateOAuthClientRequest? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthDeviceCodeResponse? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientCredentialsResponse? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientView? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientListResponse? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOIDCProviderMetadata? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenErrorResponse? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenResponse? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUpdateOAuthClientRequest? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUserinfoResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsLinkedLoginMethod? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsListOrgsResponse? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrg>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrg? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrgMemberEnriched? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsSCIMGroup? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsWorkspaceMembership? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationInfo? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationRole? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCategory? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackClientContext? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCreateRequest? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackSource? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackProductFeedback? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarification? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryAISearchClarificationOption>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOption? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOptionScope? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBody? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBodyScope? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponse? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponseScope? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBody? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsRequestBody? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunType? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsResponseBody? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTraceResponseBody? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesRequestBody? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesResponseBody? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTrace? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionCostDetails? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionTokenDetails? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunEvent? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunFeedbackStat? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptCostDetails? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptTokenDetails? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunStatus? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunURLResponse? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTraceAggregates? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlert? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertSeverity? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertType? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluator? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorCodeEvaluatorInput? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorLanguage? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesEvaluator? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesStructuredEvaluator? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesListResponse? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesRule>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRule? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetails? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedParseErrorDetails? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetailsErrorClass? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesAlert>? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesCodeEvaluator>? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimit? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesEvaluator>? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRuleGroupBy? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesWebhook>? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesWebhook? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimitWindow? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRun? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricEntity? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricField? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricParams? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricType? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobMountSpec? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubMountSpec? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiFileInfo? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSMountSpec? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpec? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpecType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountSpec? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGrepMatch? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountCacheSpec? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountEncryptionSpec? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountKind? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpec? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3MountSpec? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3BucketMountSpec? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSBucketMountSpec? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitRepoMountSpec? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubRepoMountSpec? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobContainerMountSpec? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminator? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminatorType? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfig? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfigCredentials? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiRunConfig? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessControl? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessDelegation? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayload? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayloadController? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteRequest? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteResponse? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteSkipped? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachment? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachmentController? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserTab? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserResponse? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserWindowLinks? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCallback? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyHeader? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayload? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotImageConfig? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCloneVolumePayload? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserPayload? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyConfig? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserWindowLinksPayload? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayload? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayloadAuthType? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSandboxPayload? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountConfig? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeMountRequest? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSnapshotPayload? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateVolumePayload? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayload? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLResponse? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponse? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponseDetail? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecRequest? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecResponse? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamRequest? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamResumeRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobRequest? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobResponse? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepRequest? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepResponse? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesHeaderType? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesLoadBrowserExtensionsResponse? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesOpenBrowserTabPayload? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSConfig? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureConfig? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureSASConfig? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRule? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPConfig? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRuleMatchScheme? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxySecretValue? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryListResponse? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponse? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseAuthType? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseProvider? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseRepositorySearchMode? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountAuthConfig? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAuthConfig? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountAuthConfig? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxListResponse? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxResponse? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountAuthConfig? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxVolumeResponse>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxVolumeResponse? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxStatusResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCost? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageCostResourceType? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostTotals? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostsResponse? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDailyResponse? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost>? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDaily? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantListResponse? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponse? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponseAccess? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayload? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponse? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponseAccess? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayload? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayloadController? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotListResponse? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponse? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameResponse? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameTag? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponseIncludedItem? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesStartSandboxPayload? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateBrowserAttachmentPayload? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayload? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateSandboxPayload? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateVolumePayload? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUploadResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageResponse? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrorDetail? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrors? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesValidationErrorDetail>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeAttachmentResponse? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeListResponse? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeResponse>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeResponse? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeAttachmentResponse>? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimCreateScimTokenPayload? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimErrorResponse? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenResponse? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenSensitiveResponse? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimUpdateScimTokenPayload? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsErrorResponse? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsListResponse? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsSecretItem>? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsSecretItem? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsBulkUpsertItem? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsPutRequest? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenRequestBody? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenResponseBody? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareDeleteShareTokenRequestBody? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetails? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetailsErrorClass? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumn? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumnDataType? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryRequest? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponse? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SqlqueryColumn>? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponseTruncationReason? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsErrorResponse? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransition? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransitionHistoryResponse? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsErrorResponse? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsListTenantsResponse? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantsTenant>? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsTenant? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsRequestBody? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField>? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadStatsSelectField? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsResponseBody? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadTracesResponseBody? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceListItem? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsRequestBody? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsResponseBody? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadListItem? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxActivationProblem? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxRef? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxScope? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxStatus? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSingleThreadStatsSelectField? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceSelectField? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareCreateShareTokenRequestBody? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareShareTokenResponseBody? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareThreadManifest? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsCreateToolPayload? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsErrorResponse? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsListToolsResponse? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsTool? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsUpdateToolPayload? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WebhooksSlackHandoffResponse? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsAgentVersionResponse? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequest? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestType? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsListSessionsV2Response? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Session>? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Session? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequest? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsTTLSettingsResponse? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsUpdateTTLSettingsRequest? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageAgentUsagePage? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicAgentUsage>? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicAgentUsage? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicUserUsage? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageUserUsagePage? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicUserUsage>? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersPayload? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersResponse? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMemberStatus>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatus? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAttachUserGroupAccessPolicyPayload? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupPayload? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupWorkspaceGrantPayload? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupAccessPoliciesResponse? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupAccessPolicy>? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicy? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupMembersResponse? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMember>? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMember? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceGrantsResponse? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceGrant? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceMembersResponse? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceMember? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupsResponse? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupListItem>? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupListItem? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupPayload? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupWorkspaceGrantPayload? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroup? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicyEffect? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatusStatus? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersErrorResponse? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersListResponse? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsersUser>? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUser? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUserRef? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelector? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelectorType? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelector? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelectorType? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelector? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminator? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInput? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInputType? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInput? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInputType? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntry? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntryType? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminator? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutput? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutputType? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutput? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutputType? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEvent? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEventEvent? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStat? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStatType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionTraceTier? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionType? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExampleApiV1ExamplesPostRequest? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchRequest? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsMultipartRequest? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequest? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformDatasetsExamplesRequest? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformDatasetsExamplesRequest? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateSandboxesUploadRequest? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateAwsMarketplaceRegisterRequest? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthAuthorizeApproveRequest? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceAuthorizeRequest? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceCodeRequest? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthRevokeRequest? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthTokenRequest? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem>? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadFilterViewsApiV1SessionsSessionIdViewsGetType? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSource? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortField? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortBy? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortOrder? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSourceType? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsInclude? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsStatus? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformHubReposDirectoriesRepoType? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesStatus? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesActivityItem? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesSortBy? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsKind? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsEnvironment? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSortOrder? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunRulesType? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsSelect? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsResourceType? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsGranularity? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2TypeItem? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortBy? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortOrder? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortByFeedbackSource? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsStatsSelect? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsTracesSelect? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTracesRunsSelect? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetOrgsCurrentDataPlanesView? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortBy? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortOrder? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortBy? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortOrder? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2>? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2>? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2>? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2>? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3>? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceSecret>? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2>? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse3>? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse3? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2>? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse3>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse3? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2>? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2>? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3>? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchRunsResponse3? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsResponse3? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchResponse3? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponse? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tenant>? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListReposApiV1ReposGetResponse2>? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetResponse2? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateRepoApiV1ReposPostResponse2>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoApiV1ReposPostResponse2? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteReposApiV1ReposDeleteResponse3>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteReposApiV1ReposDeleteResponse3? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2>? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformAlertsTestResponse3? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformAlertsResponse3? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformAlertsResponse3? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentIssuesAgent>? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthAuthorizedAppView>? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? Type1596 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRubricItemSchema>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AssignedReviewerSchema>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSelect>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoExampleResponse>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SimpleExperimentInfo>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesCreate>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesInput>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesOutput>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ChartsItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutRow>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutItem>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, object>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GroupedRunsSessionStats>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormulaWeightedVariable>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ClusteringJobConfigResponse>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunCluster>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunClusteringJobPydantic>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleGroupWithSessions>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HighlightedRun>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFApiActivity>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Comment>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicDatasetSchema>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunPublicSchema>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoOwner>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchema>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagCount>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapSchema>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapProviderSchema>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OCSFResourceDetails>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RubricItemConditionRule>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SessionFeedbackConfigIds>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValue>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tagging>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Resource>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertThreshold>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, int?>>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfig>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretConfigInput>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepoInput>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentGithubRepo>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentEnvironment>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgentRuntimeBinding>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentplatformAgent>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalConditionGroup>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalCondition>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuthzInternalAccessPolicy>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsExampleRun>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CommitsCommitWithLookups>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AwsResourceTag>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AzureResourceTag>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<int>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesMissingPermission>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlane>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Dataset>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetsV2ExampleWithRuns>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendGroup>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendDay>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesMetadataOperation>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSubjectMatcher>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSpendUsage>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesRateLimitUsage>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesFix>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthOAuthClientView>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrg>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryAISearchClarificationOption>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryTrace>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesRule>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesAlert>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesCodeEvaluator>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesEvaluator>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesWebhook>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserTab>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserAttachment>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeMountRequest>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxVolumeResponse>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageCost>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageDaily>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesServiceURLGrantResponse>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesValidationErrorDetail>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeResponse>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeAttachmentResponse>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsSecretItem>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SqlqueryColumn>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantsTenant>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadStatsSelectField>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadTraceListItem>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadListItem>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ToolsTool>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Session>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicAgentUsage>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicUserUsage>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMemberStatus>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupAccessPolicy>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMember>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupListItem>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsersUser>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsRun>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsBulkUpsertItem>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataType>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SourceType>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListSessionsV2TypeItem>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsStatsSelect>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsTracesSelect>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSession>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantForUser>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceSecret>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKey>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TTLSettings>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FilterView>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Example>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExport>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Role>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProvider>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgUsage>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tenant>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsageLimit>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoTag>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentIssuesAgent>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthAuthorizedAppView>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? ListType270 { get; set; }
    }
}