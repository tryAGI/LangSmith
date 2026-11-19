
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
        public global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgIdentityPatch? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgMemberIdentity? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgPendingIdentity? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgUsage? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Organization? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationConfig? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentMethodInfo? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationBillingInfo? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlusPlanTransitionInfo? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationCreate? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardColorScheme? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardSchema? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationDashboardType? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationInfo? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationRoles? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationMembers? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationPGSchemaSlim? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrganizationUpdate? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PagerdutySeverity? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentity? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityCreate? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PendingIdentityPatch? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PermissionResponse? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSavedOptions? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequest? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestSettingsType? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestScope? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponse? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseSettingsType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequest? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PopulateAnnotationQueueSchema? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProblemDetails? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJob? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationResult? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobCreate? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLog? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobLogCreate? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobUpdate? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptOptimizationJobWithLogs? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhook? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookBase? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookCreate? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookPayload? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookTest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PromptWebhookUpdate? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProvisioningMethod? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequest? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProxyRequestMethod? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicComparativeExperiment? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PublicExampleWithRuns? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutDatasetVersionsSchema? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRuns? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonView? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryExampleSchemaWithRunsRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDelta? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryFeedbackDeltaBatch? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryGroupedExamplesWithRuns? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryParamsForPublicRunSchema? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QuerySessionFeedbackConfigIds? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueueInfoResponse? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RemoveRepoOwnerRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTag? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoTagRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoUpdateTagRequest? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsRepoType? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RepoWithLookupsSource? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RequestBodyForRunsGenerateQuery? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsGenerateQueryFeedbackKeys? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchema? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResolvedAnnotationQueueRunSchemaSection? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Resource? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ResponseBodyForRunsGenerateQuery? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Role? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RoleRestrictionUpdate? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRule? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionRuleOp? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RubricItemConditionsJoin? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RubricItemConditionRule>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionOutcome? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogActionResponse? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogSchema? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RuleLogsPaginatedResponse? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupBy? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunGroupStats? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaInput? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitWindow? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRuleSpendLimitSchemaOutput? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesAlertType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchema? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesPagerdutyAlertSchema? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesWebhookSchema? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesCreateSchemaGroupBy? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchema? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesSchemaGroupBy? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchema? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesUpdateSchemaGroupBy? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchema? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunRulesValidateSchemaGroupBy? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunSchemaWithAnnotationQueueInfo? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunShareSchema? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStats? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupByAttribute? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseAttribute? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsGroupBySeriesResponseSetBy? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParams? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsSelect? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunStatsQueryParamsPublic? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationError? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsQueryValidationResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOConfirmEmailRequest? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationSendRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOEmailVerificationStatusResponse? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProvider? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMapping? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOProviderSlim? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsCreate? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SSOSettingsUpdate? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SavedRunClusteringJobRequestModel? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfig? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigSource? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretConfigInput? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretUpsert? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccount? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountWorkspaceAssignment? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountCreateResponse? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ServiceAccountDeleteResponse? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIds? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackConfigIdsPage? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SessionFeedbackConfigIds>? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackDelta? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionSortableColumns? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SetTenantHandleRequest? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseBase? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerializedChartType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByComparativeExperimentColumn? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortByDatasetColumn? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SortParamsForRunsComparisonViewSortOrder? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SourceType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessBillingInfo? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerAddress? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoInput? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeTaxId? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeBusinessInfoOutput? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCheckoutSessionsCreate? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeCustomerBillingInfo? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripePaymentInformation? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StripeSetupIntentResponse? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.StudioRunOverDatasetRequestSchema? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SupabaseAttributeMappingKey? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TTLSettings? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKey? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyCreate? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyUpdate? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValues? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValue>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValue? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagKeyWithValuesAndTaggings? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueWithTaggings? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueCreate? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagValueUpdate? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tagging>? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tagging? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingCreate? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsByResourceType? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Resource>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TaggingsResponse? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Tenant? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantBulkUnshareRequest? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantCreate? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantForUser? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantMembers? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareDatasetToken? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareRunToken? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareThreadToken? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponse? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EntitiesItem? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminator? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantStats? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitInfo? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantUsageLimitType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleRequest? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadEvaluatorSampleResponse? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadMessagesFormatType? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadPreviewResponse? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionCreate? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionUpdate? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyCreateRequest? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracingKeyListResponse? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TriggerRulesRequest? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TrueFalseLiteral? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateClusteringJobConfigRequest? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateFeedbackConfigSchema? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateGetStartedPathRequest? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateOrgDefaultMonthlyTraceLimit? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoRequest? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRoleRequest? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobRequest? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRunClusteringJobResponse? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertTTLSettingsRequest? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertUsageLimit? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageLimitScope? Type653 { get; set; }
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
        public global::LangSmith.AgreementAnswer? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AgreementState? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertAction? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionTarget? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBase? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertActionBaseTarget? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRule? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAggregation? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleAttribute? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleOperator? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBase? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAggregation? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseAttribute? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseOperator? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleBaseType? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsAlertRuleResponse? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsCreateAlertRuleRequest? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsErrorResponse? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AlertsUpdateAlertRuleRequest? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemInput? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItem? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerRequest? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAddReviewerResponse? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueListItem? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.AnnotationqueuesItemKeyAgreement>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesItemKeyAgreement? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthSandboxDelegationMode? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnOrganizationConfig? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthnPublicAuthInfo? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacAttributeName? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAbacOperator? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicy? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalConditionGroup? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAccessPolicyCreateResponse? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalAttachAccessPoliciesPayload? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCondition? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalPermission? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalCreateAccessPolicyPayload? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalListAccessPoliciesResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AuthzInternalUpdateAccessPolicyPayload? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AwsResourceTag? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AzureResourceTag? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BackfillsRestartBackfillRequest? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitResponse? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsExampleRun? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCommitWithLookups? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitReq? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsCreateCommitResponse? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CommitsListCommitsResponse? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneBYOIAMSettings? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettings? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant1? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneCMKSettingsVariant2? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequest? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAws? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestAzure? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateDataPlaneRequestGCP? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AwsResourceTag>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOVPCSettings? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneIngressSettings? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTraceStorage? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AzureResourceTag>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneBYOIAMSettings? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesCreateErrorResponse? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneCloud? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFirewallSettings? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<int>>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneFleetOIDCSettings? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneProvisioningSettings? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesDataPlaneTTLSettings? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesErrorResponse? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesMissingPermission? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesListPublicDataPlanesResponse? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlane? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesStatus? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesPublicDataPlaneWorkspace? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneFleetOIDCSettings? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneRequest? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsListDatasetsV2Response? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Dataset>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunSelectField? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DatasetsV2ExampleWithRuns? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunResponse? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitInfo? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitResponse? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCreateDirectoryCommitRequest? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInput? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryGetDirectoryResponse? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutput? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryErrorResponse? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersCreateRequest? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersListResponse? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EndusersUser>? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersUser? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EndusersUpdateRequest? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ErrutilUserError? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluator? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCodeEvaluatorInput? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorBuildStatus? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorKey? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting>? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorRequest? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsCreateEvaluatorResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluator? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsErrorResponse? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsLLMEvaluator? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsEvaluatorRunRule? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendLimit? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsGetEvaluatorSpendResponse? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendGroup? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsListEvaluatorsResponse? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsManagedCodeEvaluatorMetricSetting? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsSpendDay? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequestCodeEvaluatorInput? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorRequest? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.EvaluatorsUpdateEvaluatorResponse? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataRequest? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesMetadataOperation>? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperation? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataResponse? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatus? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesDeleteExamplesRequest? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesErrorResponse? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesCreatedResponse? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesDeletedResponse? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesExamplesUpdatedResponse? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExamplesMetadataOperationOperation? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesColumnOverride? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverride? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesDisableModelRequest? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesErrorResponse? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesFeatureConfig? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FeaturesUpsertDefaultModelRequest? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsErrorResponse? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.FilterviewsValidationErrorResponse? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSubjectMatcher? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesGatewayPolicyRecord? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSpendUsage>? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSpendUsage? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesRateLimitUsage>? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitUsage? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitMetric? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesRateLimitWindow? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GatewayPoliciesErrorResponse? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HttperrErrorResponse? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsEnvironmentEntry? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsErrorResponse? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsHubEnvironmentsModel? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoBatchIngestConfig? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoCustomerInfo? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoInfoGetResponse? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.InfoSDKVersions? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationCatalogEntry? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverride? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IntegrationsIntegrationOverrideUpdate? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesErrorResponse? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidence? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesSeriesEvidence? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesEvidenceType? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesFix? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssue? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerification? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesFix>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearContext? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSync? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesStatus? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueType? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResult? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueFixVerificationStatus? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesIssueValidationResultOutcome? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesLinearSyncState? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesListViewsResponse? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.IssuesViewedIssue? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricDefinition? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountOrg? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountProject? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeAccountResponseList? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsRequest? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsArcadeSettingsResponse? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsErrorResponse? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsGetMcpVendorResponse? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendorStatus? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpGatewaysResponse? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGateway? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListMcpVendorsResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpVendor? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsListVendorToolsResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsVendorTool? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayBinding? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.McpVendorsMcpGatewayToolFilter? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizationServerMetadata? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthAuthorizedAppView? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientPublicMetadata? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationRequest? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthClientRegistrationResponse? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthCreateOAuthClientRequest? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthDeviceCodeResponse? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientCredentialsResponse? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientView? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOAuthClientListResponse? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthOIDCProviderMetadata? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenErrorResponse? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthTokenResponse? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUpdateOAuthClientRequest? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OauthUserinfoResponse? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsLinkedLoginMethod? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsListOrgsResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrg>? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrg? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrgMemberEnriched? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsSCIMGroup? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsWorkspaceMembership? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationInfo? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OrgsOrganizationRole? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCategory? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackClientContext? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackCreateRequest? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackSource? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ProductfeedbackProductFeedback? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarification? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryAISearchClarificationOption>? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOption? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchClarificationOptionScope? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBody? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseRequestBodyScope? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponse? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryAISearchParseResponseScope? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBody? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsRequestBody? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunType? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryRunsResponseBody? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTraceResponseBody? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesRequestBody? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryQueryTracesResponseBody? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTrace? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionCostDetails? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunCompletionTokenDetails? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunEvent? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunFeedbackStat? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptCostDetails? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunPromptTokenDetails? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunStatus? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryRunURLResponse? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.QueryTraceAggregates? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlert? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertSeverity? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesAlertType? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluator? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorCodeEvaluatorInput? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesCodeEvaluatorLanguage? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesEvaluator? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesStructuredEvaluator? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesListResponse? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesRule>? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRule? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetails? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedParseErrorDetails? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesProblemDetailsErrorClass? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesAlert>? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesCodeEvaluator>? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimit? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesEvaluator>? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesRuleGroupBy? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RulesWebhook>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesWebhook? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RulesSpendLimitWindow? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsErrorResponse? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRun? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsRunRunType? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsScalarMetricDefinition? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricEntity? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricField? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricParams? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsMetricType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsProjectUser? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsProjectUserStatsStatus? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsQueryUsersRequest? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.RunsanalyticsQueryUsersResponse? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsanalyticsProjectUser>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobMountSpec? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubMountSpec? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiFileInfo? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSMountSpec? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpec? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountRefSpecType? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitMountSpec? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGrepMatch? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountCacheSpec? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountEncryptionSpec? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountKind? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpec? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3MountSpec? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiS3BucketMountSpec? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGCSBucketMountSpec? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiGitRepoMountSpec? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiContextHubRepoMountSpec? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiAzureBlobContainerMountSpec? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminator? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiMountSpecDiscriminatorType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfig? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiProxyRewriteConfigCredentials? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxapiRunConfig? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessControl? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAccessDelegation? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayload? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesAttachBrowserPayloadController? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteRequest? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteResponse? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBatchDeleteSkipped? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachment? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserAttachmentController? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserTab? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserResponse? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserAttachment>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesBrowserWindowLinks? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCallback? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyHeader? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayload? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotImageConfig? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCloneVolumePayload? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserPayload? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyConfig? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateBrowserWindowLinksPayload? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayload? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateRegistryPayloadAuthType? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSandboxPayload? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountConfig? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeMountRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateSnapshotPayload? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesCreateVolumePayload? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayload? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesDownloadURLResponse? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponse? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesErrorResponseDetail? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecRequest? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecResponse? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamRequest? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesExecStreamResumeRequest? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobRequest? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGlobResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepRequest? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesGrepResponse? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesHeaderType? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesLoadBrowserExtensionsResponse? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesOpenBrowserTabPayload? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSConfig? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSRoleConfig? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfig? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureConfig? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfig? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureAccountKeyConfig? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureSASConfig? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRule? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPConfig? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPWorkloadIdentityConfig? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyGCPServiceAccountConfig? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyRuleMatchScheme? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxySecretValue? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryListResponse? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponse? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseAuthType? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseProvider? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesRegistryResponseRepositorySearchMode? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountAuthConfig? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountRoleAuthConfig? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfig? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAuthConfig? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountWorkloadIdentityAuthConfig? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountAccountKeyAuthConfig? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAzureMountSASAuthConfig? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountAuthConfig? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountWorkloadIdentityAuthConfig? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxGCPMountServiceAccountAuthConfig? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxListResponse? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxResponse? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxMountAuthConfig? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxVolumeResponse>? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxVolumeResponse? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxStatusResponse? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCost? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageCostResourceType? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostTotals? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageCostsResponse? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDailyResponse? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageCost>? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxUsageDaily? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxUsageDaily>? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantListResponse? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesServiceURLGrantResponse>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponse? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLGrantResponseAccess? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayload? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponse? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesServiceURLResponseAccess? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayload? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSetBrowserControllerPayloadController? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotListResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponse? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameResponse? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotNameTag? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSnapshotResponseIncludedItem? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesStartSandboxPayload? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateBrowserAttachmentPayload? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayload? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateRegistryPayloadAuthType? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateSandboxPayload? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUpdateVolumePayload? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUploadResponse? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesUsageResponse? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrorDetail? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesValidationErrors? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesValidationErrorDetail>? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeAttachmentResponse? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeListResponse? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeResponse>? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesVolumeResponse? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeAttachmentResponse>? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimCreateScimTokenPayload? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimErrorResponse? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenResponse? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimScimTokenSensitiveResponse? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ScimUpdateScimTokenPayload? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsErrorResponse? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsListResponse? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsSecretItem>? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsSecretItem? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsBulkUpsertItem? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SecretsPutRequest? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenRequestBody? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareCreateShareTokenResponseBody? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ShareDeleteShareTokenRequestBody? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetails? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedProblemDetailsErrorClass? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumn? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryColumnDataType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryRequest? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponse? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SqlqueryColumn>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SqlqueryQueryResponseTruncationReason? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsErrorResponse? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransition? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TagTransitionsTagTransitionHistoryResponse? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsErrorResponse? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsListTenantsResponse? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantsTenant>? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TenantsTenant? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsRequestBody? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadStatsSelectField>? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadStatsSelectField? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadStatsResponseBody? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadTracesResponseBody? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceListItem? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsRequestBody? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsQueryThreadsResponseBody? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadListItem? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxActivationProblem? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxRef? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxScope? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSandboxStatus? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsSingleThreadStatsSelectField? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadsThreadTraceSelectField? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareCreateShareTokenRequestBody? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareShareTokenResponseBody? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ThreadshareThreadManifest? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsCreateToolPayload? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsErrorResponse? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsListToolsResponse? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsTool? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ToolsUpdateToolPayload? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.WebhooksSlackHandoffResponse? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsAgentVersionResponse? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequest? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestTraceTier? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsCreateSessionRequestType? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsListSessionsV2Response? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Session>? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.Session? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequest? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionsUpdateSessionRequestTraceTier? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsTTLSettingsResponse? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TtlSettingsUpdateTTLSettingsRequest? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageAgentUsagePage? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicAgentUsage>? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicAgentUsage? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsagePublicUserUsage? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsageUserUsagePage? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsagePublicUserUsage>? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersPayload? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAddUserGroupMembersResponse? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMemberStatus>? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatus? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsAttachUserGroupAccessPolicyPayload? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupPayload? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsCreateUserGroupWorkspaceGrantPayload? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupAccessPoliciesResponse? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupAccessPolicy>? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicy? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupMembersResponse? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupMember>? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMember? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceGrantsResponse? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceGrant? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupWorkspaceMembersResponse? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupWorkspaceMember? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsListUserGroupsResponse? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserGroupsUserGroupListItem>? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupListItem? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupPayload? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUpdateUserGroupWorkspaceGrantPayload? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroup? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupAccessPolicyEffect? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UserGroupsUserGroupMemberStatusStatus? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersErrorResponse? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersListResponse? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsersUser>? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUser? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UsersUserRef? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelector? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryLatestSelectorType? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelector? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryCommitSelectorType? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelector? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminator? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectorySelectorDiscriminatorType? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInput? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryInputType? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInput? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryInputType? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntry? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryFileEntryType? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminator? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryInputDiscriminatorType? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutput? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryAgentEntryOutputType? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutput? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectorySkillEntryOutputType? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminator? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DirectoryDirectoryEntryOutputDiscriminatorType? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAWSStaticConfigRoleArn? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesSandboxAWSMountStaticAuthConfigRoleArn? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEvent? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SharedSSEEventEvent? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStat? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionFeedbackStatType? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionTraceTier? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SessionType? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.TracerSessionWithoutVirtualFields? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExampleApiV1ExamplesPostRequest? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchRequest? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunsRun>? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsMultipartRequest? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequest? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformDatasetsExamplesRequest? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformDatasetsExamplesRequest? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateSandboxesUploadRequest? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateAwsMarketplaceRegisterRequest? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthAuthorizeApproveRequest? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceAuthorizeRequest? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthDeviceCodeRequest? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthRevokeRequest? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateOauthTokenRequest? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem>? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadFilterViewsApiV1SessionsSessionIdViewsGetType? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?>? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DataType>? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRulesApiV1RunsRulesGetType? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SourceType>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetIsArchived? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoType? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSource? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetSortField? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortBy? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSortOrder? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsSourceType? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetAgentsInclude? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsStatus? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsItemType? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsDirection? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsAgreement? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformAnnotationQueuesItemsCountAgreement? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformHubReposDirectoriesRepoType? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesStatus? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesActivityItem? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetPlatformIssuesSortBy? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsKind? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSessionsResolutionsEnvironment? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetDatasetsSortOrder? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRunRulesType? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRunsSelect? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsResourceType? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSandboxesUsageCostsGranularity? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ListSessionsV2TypeItem>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2TypeItem? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortBy? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortOrder? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListSessionsV2SortByFeedbackSource? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsStatsSelect? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetThreadsTracesSelect? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTracesRunsSelect? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetOrgsCurrentDataPlanesView? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortBy? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageAgentsSortOrder? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortBy? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetFleetUsageUsersSortOrder? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSession>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2>? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateWorkspaceApiV1WorkspacesPostResponse2? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2>? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchWorkspaceApiV1WorkspacesWorkspaceIdPatchResponse2? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3>? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteWorkspaceApiV1WorkspacesWorkspaceIdDeleteResponse3? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2>? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceStatsApiV1WorkspacesCurrentStatsGetResponse2? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2>? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetSharedTokensApiV1WorkspacesCurrentSharedGetResponse2? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3>? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.BulkUnshareEntitiesApiV1WorkspacesCurrentSharedDeleteResponse3? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceSecret>? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsGetResponse2? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpsertCurrentWorkspaceSecretsApiV1WorkspacesCurrentSecretsPostResponse3? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2>? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PutCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyPutResponse2? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2>? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteCurrentWorkspaceSecretApiV1WorkspacesCurrentSecretsKeyDeleteResponse2? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2>? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetResponse2? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKey>? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagKeyApiV1WorkspacesCurrentTagKeysPostResponse2? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2>? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdPatchResponse2? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2>? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdGetResponse2? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse3>? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagKeyApiV1WorkspacesCurrentTagKeysTagKeyIdDeleteResponse3? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2>? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesPostResponse2? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2>? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagValuesApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesGetResponse2? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2>? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdGetResponse2? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2>? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdPatchResponse2? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse3>? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTagValueApiV1WorkspacesCurrentTagKeysTagKeyIdTagValuesTagValueIdDeleteResponse3? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateTaggingApiV1WorkspacesCurrentTaggingsPostResponse2? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2>? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTaggingsApiV1WorkspacesCurrentTaggingsGetResponse2? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3>? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteTaggingApiV1WorkspacesCurrentTaggingsTaggingIdDeleteResponse3? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2>? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsApiV1WorkspacesCurrentTagsGetResponse2? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2>? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourceApiV1WorkspacesCurrentTagsResourceGetResponse2? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3>? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListTagsForResourcesApiV1WorkspacesCurrentTagsResourcesPostResponse3? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FilterView>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Example>? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchRunsResponse3? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsResponse3? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRunsBatchResponse3? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExport>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponse? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Role>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.Tenant>? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListReposApiV1ReposGetResponse2>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListReposApiV1ReposGetResponse2? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.CreateRepoApiV1ReposPostResponse2>? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreateRepoApiV1ReposPostResponse2? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteReposApiV1ReposDeleteResponse3>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteReposApiV1ReposDeleteResponse3? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.GetRepoApiV1ReposOwnerRepoGetResponse2? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.UpdateRepoApiV1ReposOwnerRepoPatchResponse2? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeleteRepoApiV1ReposOwnerRepoDeleteResponse3? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ForkRepoApiV1ReposOwnerRepoForkPostResponse2? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2>? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.ListRepoTagsApiV1ReposTagsGetResponse2? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<global::LangSmith.ProblemDetails, global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2>? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.OptimizePromptJobApiV1ReposOptimizeJobPostResponse2? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.RepoTag>? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CreatePlatformAlertsTestResponse3? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.DeletePlatformAlertsResponse3? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.PatchPlatformAlertsResponse3? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.AgentIssuesAgent>? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OauthAuthorizedAppView>? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? Type1612 { get; set; }

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
        public global::System.Collections.Generic.List<global::LangSmith.AlertThreshold>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RubricItemConditionRule>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SessionFeedbackConfigIds>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValue>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tagging>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Resource>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>? ListType77 { get; set; }
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
        public global::System.Collections.Generic.List<global::LangSmith.EndusersUser>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendGroup>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendDay>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesMetadataOperation>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExamplesBulkUpdateMetadataStatus>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSubjectMatcher>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSpendUsage>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesRateLimitUsage>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesFix>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthOAuthClientView>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrg>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryAISearchClarificationOption>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryTrace>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesRule>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesAlert>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesCodeEvaluator>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesEvaluator>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RulesWebhook>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsanalyticsProjectUser>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserTab>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesBrowserAttachment>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCaptureSnapshotPayloadIncludeItem>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeMountRequest>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSandboxFlag>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesDownloadURLPayloadCspSourceBundle>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxVolumeResponse>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageCost>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxUsageDaily>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesServiceURLGrantResponse>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesValidationErrorDetail>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeResponse>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesVolumeAttachmentResponse>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsSecretItem>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SqlqueryColumn>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantsTenant>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadStatsSelectField>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadTraceListItem>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadListItem>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ToolsTool>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Session>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicAgentUsage>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsagePublicUserUsage>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMemberStatus>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupAccessPolicy>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupMember>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceGrant>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupWorkspaceMember>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserGroupsUserGroupListItem>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsersUser>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyAzureWorkloadIdentityConfigResource>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunsRun>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SecretsBulkUpsertItem>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DataType>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SourceType>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortByVariant1Item>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListOrganizationRolesApiV1OrgsCurrentRolesGetSortOrderVariant1Item>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ListSessionsV2TypeItem>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsStatsSelect>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetThreadsTracesSelect>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSession>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TenantForUser>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceSecret>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKey>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TTLSettings>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FilterView>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Example>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExport>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Role>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProvider>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgUsage>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.Tenant>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.UsageLimit>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.RepoTag>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.AgentIssuesAgent>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OauthAuthorizedAppView>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>? ListType272 { get; set; }
    }
}