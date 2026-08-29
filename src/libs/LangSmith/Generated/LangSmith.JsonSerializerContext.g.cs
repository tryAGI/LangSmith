
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>), TypeInfoPropertyName = "CustomChartMetricPercentile_3c8b9621ba7cc835")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_76d2f2f51478e166")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_9b2281ccf99763ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_12fc55ec359bbf41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>), TypeInfoPropertyName = "ToolMessageChunk_f97dfaaf21890332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>?), TypeInfoPropertyName = "CustomChartMetricPercentile_ff9d133b07e10395")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_290a0cb75190567c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_17e37acb6be9a65c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>?), TypeInfoPropertyName = "ToolMessageChunk_804fa1e47962cb9b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_212e443f6115a54a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, object>), TypeInfoPropertyName = "AnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.InvalidToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InvalidToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AIMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope), TypeInfoPropertyName = "AccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.APIKeyUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRepoOwnerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRunToQueueByKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AddRunToQueueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllowedLoginMethodsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueBulkDeleteRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRubricItemSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Missing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunAddSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier), TypeInfoPropertyName = "TraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueRunUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AssignedReviewerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AssignedReviewerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaWithRubricQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType), TypeInfoPropertyName = "AnnotationQueueSchemaWithSizeQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSizeSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfInt32MissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2), TypeInfoPropertyName = "AnnotationQueueUpdateSchemaReviewerAccessMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ArtifactContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ArtifactContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AttachmentsOperations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogEnrichments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogOperation), TypeInfoPropertyName = "AuditLogOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider), TypeInfoPropertyName = "AuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AutoEvalFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthMemberCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BasicAuthUserPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyParamsForRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum), TypeInfoPropertyName = "RunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsFilterDataSourceTypeEnum), TypeInfoPropertyName = "RunsFilterDataSourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSelect), TypeInfoPropertyName = "RunSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunDateOrder), TypeInfoPropertyName = "RunDateOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyParamsForRunsQuerySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyCloneDatasetApiV1DatasetsClonePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.DateTime?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsAbacApiV1RunsDeleteTracesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyExecuteApiV1AceExecutePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUploadCsvDatasetApiV1DatasetsUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataType), TypeInfoPropertyName = "DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BodyUploadExamplesFromCsvApiV1ExamplesUploadDatasetIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2), TypeInfoPropertyName = "BotocoreS3ConfigAddressingStyle22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2), TypeInfoPropertyName = "BotocoreS3ConfigUsEast1RegionalEndpoint22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormat), TypeInfoPropertyName = "BulkExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormatVersion), TypeInfoPropertyName = "BulkExportFormatVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCompression), TypeInfoPropertyName = "BulkExportCompression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportStatus), TypeInfoPropertyName = "BulkExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationType), TypeInfoPropertyName = "BulkExportDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationS3Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationS3Credentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunStatus), TypeInfoPropertyName = "BulkExportRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2), TypeInfoPropertyName = "BulkExportRunMetadataExecutionBackend22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdatableStatus), TypeInfoPropertyName = "BulkExportUpdatableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanReq), TypeInfoPropertyName = "ChangePaymentPlanReq2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChatMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, string>), TypeInfoPropertyName = "AnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SavedRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorLanguage), TypeInfoPropertyName = "CodeEvaluatorLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitManifestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoExampleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SimpleExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SimpleExperimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ComparativeExperimentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CompositeEvaluatorCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CompositeMigrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CompositeMigrationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ConfiguredBy), TypeInfoPropertyName = "ConfiguredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateCommentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateFeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestRepoType), TypeInfoPropertyName = "CreateRepoRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestSource2), TypeInfoPropertyName = "CreateRepoRequestSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobRequestModel), TypeInfoPropertyName = "CreateRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreateChartType), TypeInfoPropertyName = "CustomChartCreateChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreatePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackCountMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackCountMetricParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricPercentile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricScalar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFeedbackScoreMetricScalarParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFilterByDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartFilterByTracingProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartGroupByComplex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartGroupByPlain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetric), TypeInfoPropertyName = "CustomChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricField), TypeInfoPropertyName = "CustomChartMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricPercentile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricPercentileParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricRatioInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricScalar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricRatioOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequestBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponseChartType), TypeInfoPropertyName = "CustomChartResponseChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HostProjectChartMetric), TypeInfoPropertyName = "HostProjectChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>), TypeInfoPropertyName = "AnyOfCustomChartGroupByPlainCustomChartGroupByComplex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>), TypeInfoPropertyName = "AnyOfCustomChartFilterByTracingProjectCustomChartFilterByDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartSeriesV2Equivalent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartType), TypeInfoPropertyName = "CustomChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfInt32Missing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfCustomChartTypeMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfIListCustomChartSeriesUpdateMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>), TypeInfoPropertyName = "AnyOfGuidMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfCustomChartSeriesFiltersMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, double?, object, object>), TypeInfoPropertyName = "AnyOfInt32DoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TimedeltaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChartsItem), TypeInfoPropertyName = "ChartsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerialized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType), TypeInfoPropertyName = "CustomChartsSectionChartDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartSubSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfDashboardLayoutInputMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionsCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlockCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomTextBlockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomerVisiblePlanInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PaymentPlanTier), TypeInfoPropertyName = "PaymentPlanTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardBreakpointLayoutInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardBreakpointLayoutOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutBreakpointsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutBreakpointsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DashboardLayoutItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DashboardLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetDiffInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetPublicSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetSchemaForUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformationType), TypeInfoPropertyName = "DatasetTransformationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.ExampleUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfIListDatasetTransformationMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>), TypeInfoPropertyName = "AnyOfGuidMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeleteClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeleteRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DemoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationAlgorithm), TypeInfoPropertyName = "EPromptOptimizationAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobLogType), TypeInfoPropertyName = "EPromptOptimizationJobLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobStatus), TypeInfoPropertyName = "EPromptOptimizationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptWebhookTrigger), TypeInfoPropertyName = "EPromptWebhookTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluateExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorSpendDefaultBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow), TypeInfoPropertyName = "EvaluatorSpendDefaultBodyWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorSpendDefaultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorStructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorTopLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Example))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleGroupWithSessions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?, double?>), TypeInfoPropertyName = "AnyOfStringInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GroupedRunsSessionStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedRunsSessionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleWithRunsCH))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleListOrder), TypeInfoPropertyName = "ExampleListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleSelect), TypeInfoPropertyName = "ExampleSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>), TypeInfoPropertyName = "AnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleUpdateWithID))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleValidationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentResultsUploadResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExportAnnotationQueueRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelFeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType), TypeInfoPropertyName = "FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType), TypeInfoPropertyName = "FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateWithTokenExtendedSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object>), TypeInfoPropertyName = "AnyOfDoubleInt32BooleanStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormula))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaAggregationType), TypeInfoPropertyName = "FeedbackFormulaAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaWeightedVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaCreateAggregationType), TypeInfoPropertyName = "FeedbackFormulaCreateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType), TypeInfoPropertyName = "FeedbackFormulaUpdateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackIngestTokenCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackIngestTokenSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackLevel), TypeInfoPropertyName = "FeedbackLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceParam), TypeInfoPropertyName = "FeedbackSourceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FetchClusteringJobRunsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewType), TypeInfoPropertyName = "FilterViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewRename))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ForkRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FunctionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FunctionMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel), TypeInfoPropertyName = "GenerateClusteringJobConfigRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateSyntheticExamplesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetClusteringJobConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ClusteringJobConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetDatasetsSelect), TypeInfoPropertyName = "GetDatasetsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunCluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunCluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InsightsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunClusteringJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunClusteringJobPydantic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunClusteringJobPydantic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageGroupBy), TypeInfoPropertyName = "GranularUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageKind), TypeInfoPropertyName = "GranularUsageKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageStride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupExampleRunsByField), TypeInfoPropertyName = "GroupExampleRunsByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedExamplesWithRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleGroupWithSessions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupedExperimentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HealthInfoGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Highlight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HighlightedRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HumanMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HumanMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.HighlightedRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InternalSecretsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InvokePromptPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.LikeRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.LikeRepoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListAuditLogOperationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListAuditLogsOCSFResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OCSFApiActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFApiActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListCommentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPublicDatasetRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunPublicDatasetSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunPublicDatasetSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPublicRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunPublicSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunPublicSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoOwnersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsForResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProviderUserSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField), TypeInfoPropertyName = "MemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelPriceMapCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelPriceMapSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ModelPriceMapUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFApi))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFClassName), TypeInfoPropertyName = "OCSFClassName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFCategoryName), TypeInfoPropertyName = "OCSFCategoryName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFHttpRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFHttpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OCSFResourceDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFResourceDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUnmapped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFProduct))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>), TypeInfoPropertyName = "AnyOfPromptimConfigDemoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptimConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OptimizePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgMemberIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgPendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentMethodInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlusPlanTransitionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardColorScheme), TypeInfoPropertyName = "OrganizationDashboardColorScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardType), TypeInfoPropertyName = "OrganizationDashboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationPGSchemaSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OutputTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PagerdutySeverity), TypeInfoPropertyName = "PagerdutySeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PendingIdentityPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SystemMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2), TypeInfoPropertyName = "PlaygroundPromptCanvasPayloadArtifactLength22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2), TypeInfoPropertyName = "PlaygroundPromptCanvasPayloadReadingLevel22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat), TypeInfoPropertyName = "PlaygroundPromptCanvasPayloadTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSavedOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2), TypeInfoPropertyName = "PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType), TypeInfoPropertyName = "PlaygroundSettingsResponseSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2), TypeInfoPropertyName = "PlaygroundSettingsResponseOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2), TypeInfoPropertyName = "PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PopulateAnnotationQueueSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobLogCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptOptimizationJobWithLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJobLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PromptWebhookUpdate))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>), TypeInfoPropertyName = "CustomChartMetricPercentile_3c8b9621ba7cc835")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_76d2f2f51478e166")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_9b2281ccf99763ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_12fc55ec359bbf41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>), TypeInfoPropertyName = "ToolMessageChunk_f97dfaaf21890332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>?), TypeInfoPropertyName = "CustomChartMetricPercentile_ff9d133b07e10395")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_290a0cb75190567c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_17e37acb6be9a65c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>?), TypeInfoPropertyName = "ToolMessageChunk_804fa1e47962cb9b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_212e443f6115a54a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod), TypeInfoPropertyName = "ProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProxyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProxyRequestMethod), TypeInfoPropertyName = "ProxyRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PublicComparativeExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PublicExampleWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PutDatasetVersionsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryExampleSchemaWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryExampleSchemaWithRunsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryFeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryFeedbackDeltaBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryGroupedExamplesWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryParamsForPublicRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueueInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RemoveRepoOwnerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>), TypeInfoPropertyName = "AnyOfBooleanIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoUpdateTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsRepoType), TypeInfoPropertyName = "RepoWithLookupsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsSource2), TypeInfoPropertyName = "RepoWithLookupsSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RequestBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys), TypeInfoPropertyName = "RunsGenerateQueryFeedbackKeys2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection), TypeInfoPropertyName = "ResolvedAnnotationQueueRunSchemaSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Resource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResponseBodyForRunsGenerateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Role))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RoleRestrictionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionOutcome), TypeInfoPropertyName = "RuleLogActionOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupBy), TypeInfoPropertyName = "RunGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitSchemaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitWindow), TypeInfoPropertyName = "RunRuleSpendLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitSchemaOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesAlertType), TypeInfoPropertyName = "RunRulesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesCreateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesPagerdutyAlertSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesWebhookSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesUpdateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesValidateSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSchemaWithAnnotationQueueInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunShareSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute), TypeInfoPropertyName = "RunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute), TypeInfoPropertyName = "RunStatsGroupBySeriesResponseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2), TypeInfoPropertyName = "RunStatsGroupBySeriesResponseSetBy22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsQueryParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsSelect), TypeInfoPropertyName = "RunStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsQueryParamsPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsQueryValidationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOConfirmEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationSendRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailVerificationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SupabaseAttributeMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOProviderSlim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOSettingsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SavedRunClusteringJobRequestModel), TypeInfoPropertyName = "SavedRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretUpsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountWorkspaceAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ServiceAccountDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SessionFeedbackDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.FeedbackDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SessionSortableColumns), TypeInfoPropertyName = "SessionSortableColumns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SetTenantHandleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType), TypeInfoPropertyName = "SingleCustomChartResponseSerializedChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SingleCustomChartResponseSerialized>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByComparativeExperimentColumn), TypeInfoPropertyName = "SortByComparativeExperimentColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByDatasetColumn), TypeInfoPropertyName = "SortByDatasetColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder), TypeInfoPropertyName = "SortParamsForRunsComparisonViewSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SourceType), TypeInfoPropertyName = "SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeAccountLinksCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeTaxId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeBusinessInfoOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCheckoutSessionsCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeCustomerBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripePaymentInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StripeSetupIntentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.StudioRunOverDatasetRequestSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.SupabaseAttributeMappingKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SupabaseAttributeMappingKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TTLSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagKeyWithValuesAndTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueWithTaggings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagValueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.Tagging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsByResourceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TaggingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantBulkUnshareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantForUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantMembers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareDatasetToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareRunToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareThreadToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EntitiesItem), TypeInfoPropertyName = "EntitiesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType), TypeInfoPropertyName = "TenantShareTokensResponseEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitType), TypeInfoPropertyName = "TenantUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadMessagesFormatType), TypeInfoPropertyName = "ThreadMessagesFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageStatus), TypeInfoPropertyName = "ToolMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageChunkStatus), TypeInfoPropertyName = "ToolMessageChunkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionWithoutVirtualFields))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TriggerRulesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TrueFalseLiteral), TypeInfoPropertyName = "TrueFalseLiteral2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateClusteringJobConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateFeedbackConfigSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRepoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRunClusteringJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateRunClusteringJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpsertTTLSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpsertUsageLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimitType), TypeInfoPropertyName = "UsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimitScope), TypeInfoPropertyName = "UsageLimitScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UserOnboardingStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UserWithPassword))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspaceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspaceInviteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.WorkspacePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SSOEmailLookupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppHubCrudTenantsTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AppSchemasTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentCreateIssuesAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel), TypeInfoPropertyName = "AgentCreateIssuesAgentRequestAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentIssuesAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel), TypeInfoPropertyName = "AgentIssuesAgentAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentLinearIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentLinearSyncHealth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentLinearIntegrationPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentSaveOverviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentSaveOverviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentUpdateIssuesAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel), TypeInfoPropertyName = "AgentUpdateIssuesAgentRequestAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionTarget), TypeInfoPropertyName = "AlertsAlertActionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBaseTarget), TypeInfoPropertyName = "AlertsAlertActionBaseTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAggregation), TypeInfoPropertyName = "AlertsAlertRuleAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAttribute), TypeInfoPropertyName = "AlertsAlertRuleAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleOperator), TypeInfoPropertyName = "AlertsAlertRuleOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleType), TypeInfoPropertyName = "AlertsAlertRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAggregation), TypeInfoPropertyName = "AlertsAlertRuleBaseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAttribute), TypeInfoPropertyName = "AlertsAlertRuleBaseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseOperator), TypeInfoPropertyName = "AlertsAlertRuleBaseOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseType), TypeInfoPropertyName = "AlertsAlertRuleBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsCreateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsUpdateAlertRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddAnnotationQueueItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAddReviewerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueItemListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemPlacementResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus), TypeInfoPropertyName = "AnnotationqueuesAnnotationQueueReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesCreateAnnotationQueueItemStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesDeleteAnnotationQueueItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesListAnnotationQueueItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesPatchAnnotationQueueItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthnOrganizationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthnPublicAuthInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacAttributeName), TypeInfoPropertyName = "AuthzInternalAbacAttributeName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacOperator), TypeInfoPropertyName = "AuthzInternalAbacOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAccessPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalConditionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAccessPolicyCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAttachAccessPoliciesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalPermission), TypeInfoPropertyName = "AuthzInternalPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalCreateAccessPolicyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalListAccessPoliciesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuthzInternalAccessPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalUpdateAccessPolicyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BackfillsRestartBackfillRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CommitsExampleRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsExampleRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCommitWithLookups))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCreateCommitReq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsCreateCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CommitsListCommitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CommitsCommitWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesCreateDataPlaneRequestAws))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesCreateErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesDataPlaneFirewallSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesDataPlaneTTLSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataPlanesMissingPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesMissingPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesListPublicDataPlanesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlane>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesPublicDataPlane))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesStatus), TypeInfoPropertyName = "DataPlanesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesPublicDataPlaneWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesUpdateDataPlaneFirewallSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesUpdateDataPlaneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField), TypeInfoPropertyName = "QueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2DatasetsExperimentRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetsV2ExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetsV2ExampleWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryCreateDirectoryCommitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryGetDirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DirectoryErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ErrutilUserError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCodeEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus), TypeInfoPropertyName = "EvaluatorsEvaluatorBuildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorType), TypeInfoPropertyName = "EvaluatorsEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsCreateEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsLLMEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorRunRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsSpendLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsGetEvaluatorSpendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsSpendGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsListEvaluatorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsSpendDay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsUpdateEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesDeleteExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesDeletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExamplesExamplesUpdatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesColumnOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesColumnOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverridePatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExperimentViewOverridesExperimentViewOverridePostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesDisableModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesFeatureConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeaturesUpsertDefaultModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesCreateGatewayPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesSubjectMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesSubjectMatcher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesGatewayPolicyRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesRateLimitUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesRateLimitUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesRateLimitMetric), TypeInfoPropertyName = "GatewayPoliciesRateLimitMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesRateLimitWindow), TypeInfoPropertyName = "GatewayPoliciesRateLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesSearchGatewayPoliciesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesUpdateGatewayPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HttperrErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsCreateEnvironmentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.HubEnvironmentsEnvironmentEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsEnvironmentEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsHubEnvironmentsModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HubEnvironmentsUpdateEnvironmentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InfoBatchIngestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InfoCustomerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InfoInfoGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.InfoSDKVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationCatalogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IntegrationsIntegrationOverrideUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesStatus), TypeInfoPropertyName = "IssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSyncState), TypeInfoPropertyName = "IssuesLinearSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesListViewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IssuesViewedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesViewedIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeAccountResponseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsArcadeAccountProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsArcadeSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsGetMcpVendorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpVendorStatus), TypeInfoPropertyName = "McpVendorsMcpVendorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListMcpGatewaysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGateway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListMcpVendorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpVendor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsListVendorToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.McpVendorsVendorTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsVendorTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGatewayBinding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpGatewayToolFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthAuthorizationServerMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthAuthorizedAppView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthClientPublicMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthClientRegistrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthClientRegistrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthCreateOAuthClientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthDeviceCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthOAuthClientCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthOAuthClientView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthOAuthClientListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OauthOAuthClientView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthOIDCProviderMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthTokenErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthUpdateOAuthClientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OauthUserinfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsLinkedLoginMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsListOrgsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrgMemberEnriched))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsSCIMGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsWorkspaceMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrgsOrganizationInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect), TypeInfoPropertyName = "QueryPublicSharedTraceRunsRequestBodySelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryRunsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType), TypeInfoPropertyName = "QueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTraceResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTracesRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryQueryTracesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunCompletionCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunCompletionTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunFeedbackStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.QueryRunFeedbackStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunPromptCostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunPromptTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.QueryRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunStatus), TypeInfoPropertyName = "QueryRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryTraceAggregates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRunRunType), TypeInfoPropertyName = "RunsRunRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiContextHubMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiFileInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGCSMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpecType), TypeInfoPropertyName = "SandboxapiGitMountRefSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGrepMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountCacheSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountKind), TypeInfoPropertyName = "SandboxapiMountKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiS3MountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiS3BucketMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGCSBucketMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitRepoMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiContextHubRepoMountSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType), TypeInfoPropertyName = "SandboxapiMountSpecDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesAccessControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesBatchDeleteSkipped))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCallback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCaptureSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateRegistryPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateSandboxPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxMountConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesCreateSnapshotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesDownloadURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesErrorResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesExecStreamResumeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGlobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGlobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGrepRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesGrepResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesHeaderType), TypeInfoPropertyName = "SandboxesHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyAWSConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxySecretValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesCallback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesProxyGCPConfig))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>), TypeInfoPropertyName = "CustomChartMetricPercentile_3c8b9621ba7cc835")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_76d2f2f51478e166")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_9b2281ccf99763ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_12fc55ec359bbf41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>), TypeInfoPropertyName = "ToolMessageChunk_f97dfaaf21890332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>?), TypeInfoPropertyName = "CustomChartMetricPercentile_ff9d133b07e10395")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_290a0cb75190567c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_17e37acb6be9a65c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>?), TypeInfoPropertyName = "ToolMessageChunk_804fa1e47962cb9b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_212e443f6115a54a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesRegistryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesRegistryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxAWSMountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxGCPMountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSandboxResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxMountAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxapiMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSandboxStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesServiceURLResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotNameResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotNameTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesSnapshotNameTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateRegistryPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUpdateSandboxPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimCreateScimTokenPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimScimTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimScimTokenSensitiveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ScimUpdateScimTokenPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretsSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretsSecretItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretsBulkUpsertItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SecretsPutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareCreateShareTokenRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareCreateShareTokenResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ShareDeleteShareTokenRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedParseErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass), TypeInfoPropertyName = "SharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsTagTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TagTransitionsTagTransitionHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagTransitionsTagTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantsListTenantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TenantsTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantsTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsPublicSharedThreadTraceRunsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsQueryThreadTracesResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsThreadTraceListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsQueryThreadsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsQueryThreadsResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsThreadListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField), TypeInfoPropertyName = "ThreadsSingleThreadStatsSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsThreadTraceSelectField), TypeInfoPropertyName = "ThreadsThreadTraceSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadshareCreateShareTokenRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadshareShareTokenResponseBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadshareThreadManifest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsCreateToolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolsUpdateToolPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType), TypeInfoPropertyName = "TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionsAgentVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TtlSettingsTTLSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TtlSettingsUpdateTTLSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsersErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsersUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsersUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsersUserRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateExampleApiV1ExamplesPostRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleUpdateWithID>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsMultipartRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>), TypeInfoPropertyName = "AnyOfFeedbackIngestTokenCreateSchemaIListFeedbackIngestTokenCreateSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>), TypeInfoPropertyName = "AnyOfIListGuidIListAddRunToQueueRequestIListAnnotationQueueRunAddSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequest), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreatePlatformDatasetsExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchPlatformDatasetsExamplesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateSandboxesUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateAwsMarketplaceRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateOauthAuthorizeApproveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateOauthDeviceAuthorizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateOauthDeviceCodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateOauthRevokeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateOauthTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2), TypeInfoPropertyName = "BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService), TypeInfoPropertyName = "GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AuditLogOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>), TypeInfoPropertyName = "AnyOfIListDataTypeDataTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2), TypeInfoPropertyName = "ListRulesApiV1RunsRulesGetType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>), TypeInfoPropertyName = "AnyOfIListGuidGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2), TypeInfoPropertyName = "GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2), TypeInfoPropertyName = "GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2), TypeInfoPropertyName = "GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2), TypeInfoPropertyName = "ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2), TypeInfoPropertyName = "ListReposApiV1ReposGetIsArchived22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2), TypeInfoPropertyName = "ListReposApiV1ReposGetRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item), TypeInfoPropertyName = "ListReposApiV1ReposGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSource2), TypeInfoPropertyName = "ListReposApiV1ReposGetSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSortField2), TypeInfoPropertyName = "ListReposApiV1ReposGetSortField22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, string, object>), TypeInfoPropertyName = "AnyOfStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetIsArchived22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2), TypeInfoPropertyName = "ListRepoTagsApiV1ReposTagsGetSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection), TypeInfoPropertyName = "GetPlatformAnnotationQueuesItemsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType), TypeInfoPropertyName = "DeletePlatformHubReposDirectoriesRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesStatus), TypeInfoPropertyName = "GetPlatformIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetPlatformIssuesActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesActivityItem), TypeInfoPropertyName = "GetPlatformIssuesActivityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesSortBy), TypeInfoPropertyName = "GetPlatformIssuesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsSelect), TypeInfoPropertyName = "GetRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetThreadsStatsSelect), TypeInfoPropertyName = "GetThreadsStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetThreadsTracesSelect), TypeInfoPropertyName = "GetThreadsTracesSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetTracesRunsSelect), TypeInfoPropertyName = "GetTracesRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FilterView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExampleValidationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunRulesSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>), TypeInfoPropertyName = "AllOfStringPatchRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>), TypeInfoPropertyName = "AnyOfRunStatsDictionaryStringRunStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>), TypeInfoPropertyName = "AllOfStringCreateRunsBatchResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunsBatchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>), TypeInfoPropertyName = "AnyOfFeedbackIngestTokenSchemaIListFeedbackIngestTokenSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PublicComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ModelPriceMapSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.CustomChartsSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponse), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType), TypeInfoPropertyName = "CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse), TypeInfoPropertyName = "ReadSingleChartApiV1ChartsChartIdPostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType), TypeInfoPropertyName = "ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse), TypeInfoPropertyName = "UpdateChartApiV1ChartsChartIdPatchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType), TypeInfoPropertyName = "UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.WorkspaceInviteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.RepoTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>), TypeInfoPropertyName = "AllOfStringCreatePlatformAlertsTestResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreatePlatformAlertsTestResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringDeletePlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>), TypeInfoPropertyName = "AllOfStringPatchPlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PatchPlatformAlertsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.FeaturesFeatureConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.IssuesIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.AgentIssuesAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OauthAuthorizedAppView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.TracerSessionsAgentVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, object>?), TypeInfoPropertyName = "NullableAnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AccessScope?), TypeInfoPropertyName = "NullableAccessScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TraceTier?), TypeInfoPropertyName = "NullableTraceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaWithRubricQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?), TypeInfoPropertyName = "NullableAnnotationQueueSchemaWithSizeQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfInt32MissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfObjectMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2?), TypeInfoPropertyName = "NullableAnnotationQueueUpdateSchemaReviewerAccessMode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuditLogOperation?), TypeInfoPropertyName = "NullableAuditLogOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthProvider?), TypeInfoPropertyName = "NullableAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunTypeEnum?), TypeInfoPropertyName = "NullableRunTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?), TypeInfoPropertyName = "NullableRunsFilterDataSourceTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunSelect?), TypeInfoPropertyName = "NullableRunSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunDateOrder?), TypeInfoPropertyName = "NullableRunDateOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataType?), TypeInfoPropertyName = "NullableDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2?), TypeInfoPropertyName = "NullableBotocoreS3ConfigAddressingStyle22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2?), TypeInfoPropertyName = "NullableBotocoreS3ConfigUsEast1RegionalEndpoint22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormat?), TypeInfoPropertyName = "NullableBulkExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportFormatVersion?), TypeInfoPropertyName = "NullableBulkExportFormatVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportCompression?), TypeInfoPropertyName = "NullableBulkExportCompression2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportStatus?), TypeInfoPropertyName = "NullableBulkExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportDestinationType?), TypeInfoPropertyName = "NullableBulkExportDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunStatus?), TypeInfoPropertyName = "NullableBulkExportRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2?), TypeInfoPropertyName = "NullableBulkExportRunMetadataExecutionBackend22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BulkExportUpdatableStatus?), TypeInfoPropertyName = "NullableBulkExportUpdatableStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChangePaymentPlanReq?), TypeInfoPropertyName = "NullableChangePaymentPlanReq2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, string>?), TypeInfoPropertyName = "NullableAnyOfGuidString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CodeEvaluatorLanguage?), TypeInfoPropertyName = "NullableCodeEvaluatorLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ConfiguredBy?), TypeInfoPropertyName = "NullableConfiguredBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestRepoType?), TypeInfoPropertyName = "NullableCreateRepoRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRepoRequestSource2?), TypeInfoPropertyName = "NullableCreateRepoRequestSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateRunClusteringJobRequestModel?), TypeInfoPropertyName = "NullableCreateRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartCreateChartType?), TypeInfoPropertyName = "NullableCustomChartCreateChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetric?), TypeInfoPropertyName = "NullableCustomChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartMetricField?), TypeInfoPropertyName = "NullableCustomChartMetricField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartResponseChartType?), TypeInfoPropertyName = "NullableCustomChartResponseChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.HostProjectChartMetric?), TypeInfoPropertyName = "NullableHostProjectChartMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>?), TypeInfoPropertyName = "NullableAnyOfCustomChartGroupByPlainCustomChartGroupByComplex2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>?), TypeInfoPropertyName = "NullableAnyOfCustomChartFilterByTracingProjectCustomChartFilterByDatasetObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartType?), TypeInfoPropertyName = "NullableCustomChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfStringMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfInt32Missing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfCustomChartTypeMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfIListCustomChartSeriesUpdateMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>?), TypeInfoPropertyName = "NullableAnyOfGuidMissing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfCustomChartSeriesFiltersMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, double?, object, object>?), TypeInfoPropertyName = "NullableAnyOfInt32DoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ChartsItem?), TypeInfoPropertyName = "NullableChartsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?), TypeInfoPropertyName = "NullableCustomChartsSectionChartDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfDashboardLayoutInputMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PaymentPlanTier?), TypeInfoPropertyName = "NullablePaymentPlanTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DatasetTransformationType?), TypeInfoPropertyName = "NullableDatasetTransformationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfIListDatasetTransformationMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing, object>?), TypeInfoPropertyName = "NullableAnyOfGuidMissingObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationAlgorithm?), TypeInfoPropertyName = "NullableEPromptOptimizationAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobLogType?), TypeInfoPropertyName = "NullableEPromptOptimizationJobLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptOptimizationJobStatus?), TypeInfoPropertyName = "NullableEPromptOptimizationJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EPromptWebhookTrigger?), TypeInfoPropertyName = "NullableEPromptWebhookTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow?), TypeInfoPropertyName = "NullableEvaluatorSpendDefaultBodyWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?, double?>?), TypeInfoPropertyName = "NullableAnyOfStringInt32Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleListOrder?), TypeInfoPropertyName = "NullableExampleListOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ExampleSelect?), TypeInfoPropertyName = "NullableExampleSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, string, object>?), TypeInfoPropertyName = "NullableAnyOfIListStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackType?), TypeInfoPropertyName = "NullableFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32BooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32BooleanStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<object, string, object>?), TypeInfoPropertyName = "NullableAnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, int?, bool?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleInt32BooleanStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaAggregationType?), TypeInfoPropertyName = "NullableFeedbackFormulaAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaCreateAggregationType?), TypeInfoPropertyName = "NullableFeedbackFormulaCreateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType?), TypeInfoPropertyName = "NullableFeedbackFormulaUpdateAggregationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackLevel?), TypeInfoPropertyName = "NullableFeedbackLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FeedbackSourceParam?), TypeInfoPropertyName = "NullableFeedbackSourceParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.FilterViewType?), TypeInfoPropertyName = "NullableFilterViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel?), TypeInfoPropertyName = "NullableGenerateClusteringJobConfigRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetDatasetsSelect?), TypeInfoPropertyName = "NullableGetDatasetsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageGroupBy?), TypeInfoPropertyName = "NullableGranularUsageGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GranularUsageKind?), TypeInfoPropertyName = "NullableGranularUsageKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GroupExampleRunsByField?), TypeInfoPropertyName = "NullableGroupExampleRunsByField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<int?, string>?), TypeInfoPropertyName = "NullableAnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.MemberSortField?), TypeInfoPropertyName = "NullableMemberSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFClassName?), TypeInfoPropertyName = "NullableOCSFClassName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OCSFCategoryName?), TypeInfoPropertyName = "NullableOCSFCategoryName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>?), TypeInfoPropertyName = "NullableAnyOfPromptimConfigDemoConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardColorScheme?), TypeInfoPropertyName = "NullableOrganizationDashboardColorScheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OrganizationDashboardType?), TypeInfoPropertyName = "NullableOrganizationDashboardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PagerdutySeverity?), TypeInfoPropertyName = "NullablePagerdutySeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2?), TypeInfoPropertyName = "NullablePlaygroundPromptCanvasPayloadArtifactLength22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2?), TypeInfoPropertyName = "NullablePlaygroundPromptCanvasPayloadReadingLevel22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat?), TypeInfoPropertyName = "NullablePlaygroundPromptCanvasPayloadTemplateFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2?), TypeInfoPropertyName = "NullablePlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?), TypeInfoPropertyName = "NullablePlaygroundSettingsResponseSettingsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2?), TypeInfoPropertyName = "NullablePlaygroundSettingsResponseOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2?), TypeInfoPropertyName = "NullablePlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProvisioningMethod?), TypeInfoPropertyName = "NullableProvisioningMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ProxyRequestMethod?), TypeInfoPropertyName = "NullableProxyRequestMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>?), TypeInfoPropertyName = "NullableAnyOfBooleanIListGuid2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsRepoType?), TypeInfoPropertyName = "NullableRepoWithLookupsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RepoWithLookupsSource2?), TypeInfoPropertyName = "NullableRepoWithLookupsSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?), TypeInfoPropertyName = "NullableRunsGenerateQueryFeedbackKeys2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?), TypeInfoPropertyName = "NullableResolvedAnnotationQueueRunSchemaSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RuleLogActionOutcome?), TypeInfoPropertyName = "NullableRuleLogActionOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunGroupBy?), TypeInfoPropertyName = "NullableRunGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRuleSpendLimitWindow?), TypeInfoPropertyName = "NullableRunRuleSpendLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunRulesAlertType?), TypeInfoPropertyName = "NullableRunRulesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupByAttribute?), TypeInfoPropertyName = "NullableRunStatsGroupByAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?), TypeInfoPropertyName = "NullableRunStatsGroupBySeriesResponseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2?), TypeInfoPropertyName = "NullableRunStatsGroupBySeriesResponseSetBy22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunStatsSelect?), TypeInfoPropertyName = "NullableRunStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SavedRunClusteringJobRequestModel?), TypeInfoPropertyName = "NullableSavedRunClusteringJobRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SessionSortableColumns?), TypeInfoPropertyName = "NullableSessionSortableColumns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?), TypeInfoPropertyName = "NullableSingleCustomChartResponseSerializedChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByComparativeExperimentColumn?), TypeInfoPropertyName = "NullableSortByComparativeExperimentColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortByDatasetColumn?), TypeInfoPropertyName = "NullableSortByDatasetColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?), TypeInfoPropertyName = "NullableSortParamsForRunsComparisonViewSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SourceType?), TypeInfoPropertyName = "NullableSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EntitiesItem?), TypeInfoPropertyName = "NullableEntitiesItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?), TypeInfoPropertyName = "NullableTenantShareTokensResponseEntitieDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TenantUsageLimitType?), TypeInfoPropertyName = "NullableTenantUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadMessagesFormatType?), TypeInfoPropertyName = "NullableThreadMessagesFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageStatus?), TypeInfoPropertyName = "NullableToolMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ToolMessageChunkStatus?), TypeInfoPropertyName = "NullableToolMessageChunkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TrueFalseLiteral?), TypeInfoPropertyName = "NullableTrueFalseLiteral2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimitType?), TypeInfoPropertyName = "NullableUsageLimitType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UsageLimitScope?), TypeInfoPropertyName = "NullableUsageLimitScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel?), TypeInfoPropertyName = "NullableAgentCreateIssuesAgentRequestAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel?), TypeInfoPropertyName = "NullableAgentIssuesAgentAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel?), TypeInfoPropertyName = "NullableAgentUpdateIssuesAgentRequestAnalysisLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionTarget?), TypeInfoPropertyName = "NullableAlertsAlertActionTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertActionBaseTarget?), TypeInfoPropertyName = "NullableAlertsAlertActionBaseTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAggregation?), TypeInfoPropertyName = "NullableAlertsAlertRuleAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleAttribute?), TypeInfoPropertyName = "NullableAlertsAlertRuleAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleOperator?), TypeInfoPropertyName = "NullableAlertsAlertRuleOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleType?), TypeInfoPropertyName = "NullableAlertsAlertRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseAttribute2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseOperator?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AlertsAlertRuleBaseType?), TypeInfoPropertyName = "NullableAlertsAlertRuleBaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueItemListStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?), TypeInfoPropertyName = "NullableAnnotationqueuesAnnotationQueueReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacAttributeName?), TypeInfoPropertyName = "NullableAuthzInternalAbacAttributeName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalAbacOperator?), TypeInfoPropertyName = "NullableAuthzInternalAbacOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AuthzInternalPermission?), TypeInfoPropertyName = "NullableAuthzInternalPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DataPlanesStatus?), TypeInfoPropertyName = "NullableDataPlanesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunSelectField?), TypeInfoPropertyName = "NullableQueryRunSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus?), TypeInfoPropertyName = "NullableEvaluatorsEvaluatorBuildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.EvaluatorsEvaluatorType?), TypeInfoPropertyName = "NullableEvaluatorsEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesRateLimitMetric?), TypeInfoPropertyName = "NullableGatewayPoliciesRateLimitMetric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GatewayPoliciesRateLimitWindow?), TypeInfoPropertyName = "NullableGatewayPoliciesRateLimitWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesStatus?), TypeInfoPropertyName = "NullableIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.IssuesLinearSyncState?), TypeInfoPropertyName = "NullableIssuesLinearSyncState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.McpVendorsMcpVendorStatus?), TypeInfoPropertyName = "NullableMcpVendorsMcpVendorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?), TypeInfoPropertyName = "NullableQueryPublicSharedTraceRunsRequestBodySelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunType?), TypeInfoPropertyName = "NullableQueryRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.QueryRunStatus?), TypeInfoPropertyName = "NullableQueryRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.RunsRunRunType?), TypeInfoPropertyName = "NullableRunsRunRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiGitMountRefSpecType?), TypeInfoPropertyName = "NullableSandboxapiGitMountRefSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountKind?), TypeInfoPropertyName = "NullableSandboxapiMountKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?), TypeInfoPropertyName = "NullableSandboxapiMountSpecDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SandboxesHeaderType?), TypeInfoPropertyName = "NullableSandboxesHeaderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.SharedProblemDetailsErrorClass?), TypeInfoPropertyName = "NullableSharedProblemDetailsErrorClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField?), TypeInfoPropertyName = "NullableThreadsSingleThreadStatsSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ThreadsThreadTraceSelectField?), TypeInfoPropertyName = "NullableThreadsThreadTraceSelectField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType?), TypeInfoPropertyName = "NullableTracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>?), TypeInfoPropertyName = "NullableAnyOfFeedbackIngestTokenCreateSchemaIListFeedbackIngestTokenCreateSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>?), TypeInfoPropertyName = "NullableAnyOfIListGuidIListAddRunToQueueRequestIListAnnotationQueueRunAddSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequest?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2?), TypeInfoPropertyName = "NullableBetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?), TypeInfoPropertyName = "NullableGetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>?), TypeInfoPropertyName = "NullableAnyOfIListDataTypeDataTypeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2?), TypeInfoPropertyName = "NullableListRulesApiV1RunsRulesGetType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>?), TypeInfoPropertyName = "NullableAnyOfIListGuidGuidObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2?), TypeInfoPropertyName = "NullableGetAnnotationQueuesApiV1AnnotationQueuesGetQueueType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2?), TypeInfoPropertyName = "NullableGetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2?), TypeInfoPropertyName = "NullableGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2?), TypeInfoPropertyName = "NullableListPlaygroundSettingsApiV1PlaygroundSettingsGetScope22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetIsArchived22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSource2?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListReposApiV1ReposGetSortField2?), TypeInfoPropertyName = "NullableListReposApiV1ReposGetSortField22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, string, object>?), TypeInfoPropertyName = "NullableAnyOfStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetIsArchived22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2?), TypeInfoPropertyName = "NullableListRepoTagsApiV1ReposTagsGetSource22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?), TypeInfoPropertyName = "NullableGetPlatformAnnotationQueuesItemsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?), TypeInfoPropertyName = "NullableDeletePlatformHubReposDirectoriesRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesStatus?), TypeInfoPropertyName = "NullableGetPlatformIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesActivityItem?), TypeInfoPropertyName = "NullableGetPlatformIssuesActivityItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetPlatformIssuesSortBy?), TypeInfoPropertyName = "NullableGetPlatformIssuesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetRunsSelect?), TypeInfoPropertyName = "NullableGetRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetThreadsStatsSelect?), TypeInfoPropertyName = "NullableGetThreadsStatsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetThreadsTracesSelect?), TypeInfoPropertyName = "NullableGetThreadsTracesSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.GetTracesRunsSelect?), TypeInfoPropertyName = "NullableGetTracesRunsSelect2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchRunsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringPatchRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>?), TypeInfoPropertyName = "NullableAnyOfRunStatsDictionaryStringRunStats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreateRunsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreateRunsBatchResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreateRunsBatchResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>?), TypeInfoPropertyName = "NullableAnyOfFeedbackIngestTokenSchemaIListFeedbackIngestTokenSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponse?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableCreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponse?), TypeInfoPropertyName = "NullableReadSingleChartApiV1ChartsChartIdPostResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponse?), TypeInfoPropertyName = "NullableUpdateChartApiV1ChartsChartIdPatchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?), TypeInfoPropertyName = "NullableUpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.CreatePlatformAlertsTestResponse3>?), TypeInfoPropertyName = "NullableAllOfStringCreatePlatformAlertsTestResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.DeletePlatformAlertsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringDeletePlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AllOf<string, global::LangSmith.PatchPlatformAlertsResponse3>?), TypeInfoPropertyName = "NullableAllOfStringPatchPlatformAlertsResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, object>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.InvalidToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRubricItemSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AssignedReviewerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ArtifactContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoExampleResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SimpleExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartSeriesUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ChartsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartSubSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DashboardLayoutItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GroupedRunsSessionStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleWithRunsCH>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<string>, string, object>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>), TypeInfoPropertyName = "CustomChartMetricPercentile_3c8b9621ba7cc835")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_76d2f2f51478e166")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_9b2281ccf99763ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_12fc55ec359bbf41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>), TypeInfoPropertyName = "ToolMessageChunk_f97dfaaf21890332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>?), TypeInfoPropertyName = "CustomChartMetricPercentile_ff9d133b07e10395")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioInput_object_290a0cb75190567c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>?), TypeInfoPropertyName = "CustomChartMetricRatioOutput_object_17e37acb6be9a65c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>?), TypeInfoPropertyName = "ToolMessageChunk_804fa1e47962cb9b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OneOf<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>>), TypeInfoPropertyName = "ToolMessageChunk_212e443f6115a54a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaComparisonView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCreateCoreSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentResultRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackFormulaWeightedVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ClusteringJobConfigResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunCluster>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunClusteringJobPydantic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GranularUsageRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleGroupWithSessions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.HighlightedRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OCSFApiActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunPublicDatasetSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunPublicSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoOwner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ProviderUserSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OCSFResourceDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgMemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgPendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJobLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EPromptWebhookTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.List<global::System.Guid>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsGenerateQueryFeedbackKeys>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RuleLogSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CodeEvaluatorTopLevel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesPagerdutyAlertSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesWebhookSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsQueryValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ServiceAccountWorkspaceAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SingleCustomChartResponseSerialized>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagValueWithTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Tagging>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Resource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.MemberIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EntitiesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AlertsAlertActionBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItemInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuthzInternalAccessPolicy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CommitsExampleRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CommitsCommitWithLookups>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataPlanesMissingPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlane>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataPlanesPublicDataPlaneWorkspace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunSelectField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetsV2ExampleWithRuns>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsBulkDeleteEvaluatorFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluatorRunRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsEvaluator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.EvaluatorsSpendDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesColumnOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesSubjectMatcher>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesRateLimitUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.HubEnvironmentsEnvironmentEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationCatalogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IntegrationsIntegrationOverrideUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IssuesViewedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsArcadeAccountProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsMcpVendor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.McpVendorsVendorTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OauthOAuthClientView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsLinkedLoginMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsSCIMGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsWorkspaceMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.QueryRunEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesBatchDeleteSkipped>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiFileInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiGrepMatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesCallback>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesProxyRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesRegistryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSandboxResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxapiMountSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SandboxesSnapshotNameTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretsSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagTransitionsTagTransition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TenantsTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadTraceListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ThreadsThreadListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ToolsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsersUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretUpsert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListTagsForResourceRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CreateExamplesApiV1ExamplesBulkPostRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleUpdateWithID>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunsRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenCreateSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunAddSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AddRunToQueueByKeyRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PendingIdentityCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BasicAuthMemberCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretsBulkUpsertItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AuditLogOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::LangSmith.DataType>, global::LangSmith.DataType?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetDatasetsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ThreadMessagesFormatType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::System.Collections.Generic.List<global::System.Guid>, global::System.Guid?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SourceType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetPlatformIssuesActivityItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetThreadsStatsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetThreadsTracesSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GetTracesRunsSelect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TracerSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FilterView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TenantForUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SecretKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TaggingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValues>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::LangSmith.TagKeyWithValuesAndTaggings>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TTLSettings>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExampleValidationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.DatasetVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunRulesSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LangSmith.AnyOf<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackIngestTokenSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PublicComparativeExperiment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchemaWithSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueRunSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RunSchemaWithAnnotationQueueInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AnnotationQueueSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.BulkExportRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeedbackConfigSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ModelPriceMapSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptWebhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PlaygroundSettingsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.CustomChartsSectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrganizationPGSchemaSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.Role>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PermissionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UserWithPassword>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SSOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.APIKeyGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.SSOProviderSlim>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ServiceAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AppSchemasTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.WorkspaceInviteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.RepoTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.PromptOptimizationJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.FeaturesFeatureConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.GatewayPoliciesGatewayPolicyRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.IssuesIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.AgentIssuesAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OauthAuthorizedAppView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.OrgsOrgMemberEnriched>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ScimScimTokenResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.TracerSessionsAgentVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LangSmith.ExperimentViewOverridesExperimentViewOverride>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::LangSmith.JsonConverters.ChartsItemJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.FeedbackSourceVariant1JsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.FeedbackSourceVariant12JsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.EntitiesItemJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseJsonConverter());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, double?, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.DashboardLayoutInput, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DatasetTransformation>, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?, double?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.OneOfJsonConverter<global::LangSmith.AIMessage, global::LangSmith.HumanMessage, global::LangSmith.ChatMessage, global::LangSmith.SystemMessage, global::LangSmith.FunctionMessage, global::LangSmith.ToolMessage, global::LangSmith.AIMessageChunk, global::LangSmith.HumanMessageChunk, global::LangSmith.ChatMessageChunk, global::LangSmith.SystemMessageChunk, global::LangSmith.FunctionMessageChunk, global::LangSmith.ToolMessageChunk>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<global::System.Guid>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::LangSmith.AnyOf<string, object>>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenCreateSchema>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Collections.Generic.IList<global::LangSmith.AddRunToQueueRequest>, global::System.Collections.Generic.IList<global::LangSmith.AnnotationQueueRunAddSchema>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.DataType>, global::LangSmith.DataType?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<string, string, object>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchRunsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.RunStats, global::System.Collections.Generic.Dictionary<string, global::LangSmith.RunStats>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreateRunsBatchResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::LangSmith.FeedbackIngestTokenSchema>>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.CreatePlatformAlertsTestResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.DeletePlatformAlertsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.AllOfJsonConverter<string, global::LangSmith.PatchPlatformAlertsResponse3>());
            options.Converters.Add(new global::LangSmith.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LangSmith.AccessScope)

                    || typeToConvert == typeof(global::LangSmith.AccessScope?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2)

                    || typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2?)

                    || typeToConvert == typeof(global::LangSmith.AuditLogOperation)

                    || typeToConvert == typeof(global::LangSmith.AuditLogOperation?)

                    || typeToConvert == typeof(global::LangSmith.AuthProvider)

                    || typeToConvert == typeof(global::LangSmith.AuthProvider?)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2?)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2)

                    || typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportCompression)

                    || typeToConvert == typeof(global::LangSmith.BulkExportCompression?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportDestinationType)

                    || typeToConvert == typeof(global::LangSmith.BulkExportDestinationType?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormat)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormat?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion)

                    || typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportRunStatus?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportStatus?)

                    || typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus)

                    || typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus?)

                    || typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq)

                    || typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq?)

                    || typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage)

                    || typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage?)

                    || typeToConvert == typeof(global::LangSmith.ConfiguredBy)

                    || typeToConvert == typeof(global::LangSmith.ConfiguredBy?)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType?)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource2)

                    || typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource2?)

                    || typeToConvert == typeof(global::LangSmith.CreateRunClusteringJobRequestModel)

                    || typeToConvert == typeof(global::LangSmith.CreateRunClusteringJobRequestModel?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetric)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetric?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetricField)

                    || typeToConvert == typeof(global::LangSmith.CustomChartMetricField?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartType?)

                    || typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.DataType)

                    || typeToConvert == typeof(global::LangSmith.DataType?)

                    || typeToConvert == typeof(global::LangSmith.DatasetTransformationType)

                    || typeToConvert == typeof(global::LangSmith.DatasetTransformationType?)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm?)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobLogType)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobLogType?)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobStatus)

                    || typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobStatus?)

                    || typeToConvert == typeof(global::LangSmith.EPromptWebhookTrigger)

                    || typeToConvert == typeof(global::LangSmith.EPromptWebhookTrigger?)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow?)

                    || typeToConvert == typeof(global::LangSmith.ExampleListOrder)

                    || typeToConvert == typeof(global::LangSmith.ExampleListOrder?)

                    || typeToConvert == typeof(global::LangSmith.ExampleSelect)

                    || typeToConvert == typeof(global::LangSmith.ExampleSelect?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaAggregationType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaAggregationType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaCreateAggregationType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaCreateAggregationType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackLevel)

                    || typeToConvert == typeof(global::LangSmith.FeedbackLevel?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackSourceParam)

                    || typeToConvert == typeof(global::LangSmith.FeedbackSourceParam?)

                    || typeToConvert == typeof(global::LangSmith.FeedbackType)

                    || typeToConvert == typeof(global::LangSmith.FeedbackType?)

                    || typeToConvert == typeof(global::LangSmith.FilterViewType)

                    || typeToConvert == typeof(global::LangSmith.FilterViewType?)

                    || typeToConvert == typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel)

                    || typeToConvert == typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel?)

                    || typeToConvert == typeof(global::LangSmith.GetDatasetsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetDatasetsSelect?)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageKind)

                    || typeToConvert == typeof(global::LangSmith.GranularUsageKind?)

                    || typeToConvert == typeof(global::LangSmith.GroupExampleRunsByField)

                    || typeToConvert == typeof(global::LangSmith.GroupExampleRunsByField?)

                    || typeToConvert == typeof(global::LangSmith.HostProjectChartMetric)

                    || typeToConvert == typeof(global::LangSmith.HostProjectChartMetric?)

                    || typeToConvert == typeof(global::LangSmith.MemberSortField)

                    || typeToConvert == typeof(global::LangSmith.MemberSortField?)

                    || typeToConvert == typeof(global::LangSmith.OCSFCategoryName)

                    || typeToConvert == typeof(global::LangSmith.OCSFCategoryName?)

                    || typeToConvert == typeof(global::LangSmith.OCSFClassName)

                    || typeToConvert == typeof(global::LangSmith.OCSFClassName?)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme?)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardType)

                    || typeToConvert == typeof(global::LangSmith.OrganizationDashboardType?)

                    || typeToConvert == typeof(global::LangSmith.PagerdutySeverity)

                    || typeToConvert == typeof(global::LangSmith.PagerdutySeverity?)

                    || typeToConvert == typeof(global::LangSmith.PaymentPlanTier)

                    || typeToConvert == typeof(global::LangSmith.PaymentPlanTier?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2?)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2)

                    || typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2?)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod)

                    || typeToConvert == typeof(global::LangSmith.ProvisioningMethod?)

                    || typeToConvert == typeof(global::LangSmith.ProxyRequestMethod)

                    || typeToConvert == typeof(global::LangSmith.ProxyRequestMethod?)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType?)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource2)

                    || typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource2?)

                    || typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection)

                    || typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?)

                    || typeToConvert == typeof(global::LangSmith.ResourceType)

                    || typeToConvert == typeof(global::LangSmith.ResourceType?)

                    || typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome)

                    || typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome?)

                    || typeToConvert == typeof(global::LangSmith.RunDateOrder)

                    || typeToConvert == typeof(global::LangSmith.RunDateOrder?)

                    || typeToConvert == typeof(global::LangSmith.RunGroupBy)

                    || typeToConvert == typeof(global::LangSmith.RunGroupBy?)

                    || typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow)

                    || typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow?)

                    || typeToConvert == typeof(global::LangSmith.RunRulesAlertType)

                    || typeToConvert == typeof(global::LangSmith.RunRulesAlertType?)

                    || typeToConvert == typeof(global::LangSmith.RunSelect)

                    || typeToConvert == typeof(global::LangSmith.RunSelect?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2)

                    || typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2?)

                    || typeToConvert == typeof(global::LangSmith.RunStatsSelect)

                    || typeToConvert == typeof(global::LangSmith.RunStatsSelect?)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum)

                    || typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?)

                    || typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys)

                    || typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?)

                    || typeToConvert == typeof(global::LangSmith.SavedRunClusteringJobRequestModel)

                    || typeToConvert == typeof(global::LangSmith.SavedRunClusteringJobRequestModel?)

                    || typeToConvert == typeof(global::LangSmith.SessionSortableColumns)

                    || typeToConvert == typeof(global::LangSmith.SessionSortableColumns?)

                    || typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType)

                    || typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?)

                    || typeToConvert == typeof(global::LangSmith.SortByComparativeExperimentColumn)

                    || typeToConvert == typeof(global::LangSmith.SortByComparativeExperimentColumn?)

                    || typeToConvert == typeof(global::LangSmith.SortByDatasetColumn)

                    || typeToConvert == typeof(global::LangSmith.SortByDatasetColumn?)

                    || typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder)

                    || typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?)

                    || typeToConvert == typeof(global::LangSmith.SourceType)

                    || typeToConvert == typeof(global::LangSmith.SourceType?)

                    || typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.TenantUsageLimitType)

                    || typeToConvert == typeof(global::LangSmith.TenantUsageLimitType?)

                    || typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType)

                    || typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType?)

                    || typeToConvert == typeof(global::LangSmith.ToolMessageStatus)

                    || typeToConvert == typeof(global::LangSmith.ToolMessageStatus?)

                    || typeToConvert == typeof(global::LangSmith.ToolMessageChunkStatus)

                    || typeToConvert == typeof(global::LangSmith.ToolMessageChunkStatus?)

                    || typeToConvert == typeof(global::LangSmith.TraceTier)

                    || typeToConvert == typeof(global::LangSmith.TraceTier?)

                    || typeToConvert == typeof(global::LangSmith.TrueFalseLiteral)

                    || typeToConvert == typeof(global::LangSmith.TrueFalseLiteral?)

                    || typeToConvert == typeof(global::LangSmith.UsageLimitScope)

                    || typeToConvert == typeof(global::LangSmith.UsageLimitScope?)

                    || typeToConvert == typeof(global::LangSmith.UsageLimitType)

                    || typeToConvert == typeof(global::LangSmith.UsageLimitType?)

                    || typeToConvert == typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel)

                    || typeToConvert == typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel?)

                    || typeToConvert == typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel)

                    || typeToConvert == typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel?)

                    || typeToConvert == typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel)

                    || typeToConvert == typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator?)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType)

                    || typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus)

                    || typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalAbacAttributeName)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalAbacAttributeName?)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalAbacOperator)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalAbacOperator?)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalPermission)

                    || typeToConvert == typeof(global::LangSmith.AuthzInternalPermission?)

                    || typeToConvert == typeof(global::LangSmith.DataPlanesStatus)

                    || typeToConvert == typeof(global::LangSmith.DataPlanesStatus?)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus?)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorType)

                    || typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorType?)

                    || typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitMetric)

                    || typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitMetric?)

                    || typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitWindow)

                    || typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitWindow?)

                    || typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState)

                    || typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState?)

                    || typeToConvert == typeof(global::LangSmith.IssuesStatus)

                    || typeToConvert == typeof(global::LangSmith.IssuesStatus?)

                    || typeToConvert == typeof(global::LangSmith.McpVendorsMcpVendorStatus)

                    || typeToConvert == typeof(global::LangSmith.McpVendorsMcpVendorStatus?)

                    || typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect)

                    || typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField)

                    || typeToConvert == typeof(global::LangSmith.QueryRunSelectField?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus)

                    || typeToConvert == typeof(global::LangSmith.QueryRunStatus?)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType)

                    || typeToConvert == typeof(global::LangSmith.QueryRunType?)

                    || typeToConvert == typeof(global::LangSmith.RunsRunRunType)

                    || typeToConvert == typeof(global::LangSmith.RunsRunRunType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountKind)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountKind?)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType)

                    || typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?)

                    || typeToConvert == typeof(global::LangSmith.SandboxesHeaderType)

                    || typeToConvert == typeof(global::LangSmith.SandboxesHeaderType?)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass)

                    || typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?)

                    || typeToConvert == typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField)

                    || typeToConvert == typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField?)

                    || typeToConvert == typeof(global::LangSmith.ThreadsThreadTraceSelectField)

                    || typeToConvert == typeof(global::LangSmith.ThreadsThreadTraceSelectField?)

                    || typeToConvert == typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType)

                    || typeToConvert == typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType?)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2)

                    || typeToConvert == typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2?)

                    || typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService)

                    || typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?)

                    || typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2)

                    || typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2?)

                    || typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2)

                    || typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2?)

                    || typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2)

                    || typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2?)

                    || typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2)

                    || typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2?)

                    || typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2)

                    || typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource2)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource2?)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField2)

                    || typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField2?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2)

                    || typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?)

                    || typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType)

                    || typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem?)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy)

                    || typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy?)

                    || typeToConvert == typeof(global::LangSmith.GetRunsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetRunsSelect?)

                    || typeToConvert == typeof(global::LangSmith.GetThreadsStatsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetThreadsStatsSelect?)

                    || typeToConvert == typeof(global::LangSmith.GetThreadsTracesSelect)

                    || typeToConvert == typeof(global::LangSmith.GetThreadsTracesSelect?)

                    || typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect)

                    || typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect?)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?)

                    || typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType)

                    || typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LangSmith.AccessScope))
                {
                    return new global::LangSmith.JsonConverters.AccessScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AccessScope?))
                {
                    return new global::LangSmith.JsonConverters.AccessScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithRubricQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithRubricQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueSchemaWithSizeQueueType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueSchemaWithSizeQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationQueueUpdateSchemaReviewerAccessMode2?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationQueueUpdateSchemaReviewerAccessMode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuditLogOperation))
                {
                    return new global::LangSmith.JsonConverters.AuditLogOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuditLogOperation?))
                {
                    return new global::LangSmith.JsonConverters.AuditLogOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthProvider))
                {
                    return new global::LangSmith.JsonConverters.AuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthProvider?))
                {
                    return new global::LangSmith.JsonConverters.AuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigAddressingStyle2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigAddressingStyle2?))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigAddressingStyle2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigUsEast1RegionalEndpoint2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BotocoreS3ConfigUsEast1RegionalEndpoint2?))
                {
                    return new global::LangSmith.JsonConverters.BotocoreS3ConfigUsEast1RegionalEndpoint2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportCompression))
                {
                    return new global::LangSmith.JsonConverters.BulkExportCompressionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportCompression?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportCompressionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportDestinationType))
                {
                    return new global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportDestinationType?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormat))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormat?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportFormatVersion?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportFormatVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunMetadataExecutionBackend2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunMetadataExecutionBackend2?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunMetadataExecutionBackend2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportRunStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus))
                {
                    return new global::LangSmith.JsonConverters.BulkExportUpdatableStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BulkExportUpdatableStatus?))
                {
                    return new global::LangSmith.JsonConverters.BulkExportUpdatableStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq))
                {
                    return new global::LangSmith.JsonConverters.ChangePaymentPlanReqJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ChangePaymentPlanReq?))
                {
                    return new global::LangSmith.JsonConverters.ChangePaymentPlanReqNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage))
                {
                    return new global::LangSmith.JsonConverters.CodeEvaluatorLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CodeEvaluatorLanguage?))
                {
                    return new global::LangSmith.JsonConverters.CodeEvaluatorLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ConfiguredBy))
                {
                    return new global::LangSmith.JsonConverters.ConfiguredByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ConfiguredBy?))
                {
                    return new global::LangSmith.JsonConverters.ConfiguredByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestRepoType?))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource2))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestSource2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRepoRequestSource2?))
                {
                    return new global::LangSmith.JsonConverters.CreateRepoRequestSource2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRunClusteringJobRequestModel))
                {
                    return new global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateRunClusteringJobRequestModel?))
                {
                    return new global::LangSmith.JsonConverters.CreateRunClusteringJobRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartCreateChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartCreateChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartCreateChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetric))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetric?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetricField))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartMetricField?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartMetricFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartResponseChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartResponseChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartResponseChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CustomChartsSectionChartDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CustomChartsSectionChartDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CustomChartsSectionChartDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DataType))
                {
                    return new global::LangSmith.JsonConverters.DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DataType?))
                {
                    return new global::LangSmith.JsonConverters.DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DatasetTransformationType))
                {
                    return new global::LangSmith.JsonConverters.DatasetTransformationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DatasetTransformationType?))
                {
                    return new global::LangSmith.JsonConverters.DatasetTransformationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationAlgorithm?))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobLogType))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobLogType?))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationJobLogTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobStatus))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptOptimizationJobStatus?))
                {
                    return new global::LangSmith.JsonConverters.EPromptOptimizationJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptWebhookTrigger))
                {
                    return new global::LangSmith.JsonConverters.EPromptWebhookTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EPromptWebhookTrigger?))
                {
                    return new global::LangSmith.JsonConverters.EPromptWebhookTriggerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorSpendDefaultBodyWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorSpendDefaultBodyWindow?))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorSpendDefaultBodyWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ExampleListOrder))
                {
                    return new global::LangSmith.JsonConverters.ExampleListOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ExampleListOrder?))
                {
                    return new global::LangSmith.JsonConverters.ExampleListOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ExampleSelect))
                {
                    return new global::LangSmith.JsonConverters.ExampleSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ExampleSelect?))
                {
                    return new global::LangSmith.JsonConverters.ExampleSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateCoreSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackCreateSchemaFeedbackSourceVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaAggregationType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaAggregationType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaAggregationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaCreateAggregationType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaCreateAggregationType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaCreateAggregationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackFormulaUpdateAggregationType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackFormulaUpdateAggregationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackLevel))
                {
                    return new global::LangSmith.JsonConverters.FeedbackLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackLevel?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackSourceParam))
                {
                    return new global::LangSmith.JsonConverters.FeedbackSourceParamJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackSourceParam?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackSourceParamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackType))
                {
                    return new global::LangSmith.JsonConverters.FeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FeedbackType?))
                {
                    return new global::LangSmith.JsonConverters.FeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FilterViewType))
                {
                    return new global::LangSmith.JsonConverters.FilterViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.FilterViewType?))
                {
                    return new global::LangSmith.JsonConverters.FilterViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel))
                {
                    return new global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GenerateClusteringJobConfigRequestModel?))
                {
                    return new global::LangSmith.JsonConverters.GenerateClusteringJobConfigRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetDatasetsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetDatasetsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetDatasetsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetDatasetsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageKind))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageKindJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GranularUsageKind?))
                {
                    return new global::LangSmith.JsonConverters.GranularUsageKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GroupExampleRunsByField))
                {
                    return new global::LangSmith.JsonConverters.GroupExampleRunsByFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GroupExampleRunsByField?))
                {
                    return new global::LangSmith.JsonConverters.GroupExampleRunsByFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.HostProjectChartMetric))
                {
                    return new global::LangSmith.JsonConverters.HostProjectChartMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.HostProjectChartMetric?))
                {
                    return new global::LangSmith.JsonConverters.HostProjectChartMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.MemberSortField))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.MemberSortField?))
                {
                    return new global::LangSmith.JsonConverters.MemberSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OCSFCategoryName))
                {
                    return new global::LangSmith.JsonConverters.OCSFCategoryNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OCSFCategoryName?))
                {
                    return new global::LangSmith.JsonConverters.OCSFCategoryNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OCSFClassName))
                {
                    return new global::LangSmith.JsonConverters.OCSFClassNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OCSFClassName?))
                {
                    return new global::LangSmith.JsonConverters.OCSFClassNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardColorScheme?))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardType))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.OrganizationDashboardType?))
                {
                    return new global::LangSmith.JsonConverters.OrganizationDashboardTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PagerdutySeverity))
                {
                    return new global::LangSmith.JsonConverters.PagerdutySeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PagerdutySeverity?))
                {
                    return new global::LangSmith.JsonConverters.PagerdutySeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PaymentPlanTier))
                {
                    return new global::LangSmith.JsonConverters.PaymentPlanTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PaymentPlanTier?))
                {
                    return new global::LangSmith.JsonConverters.PaymentPlanTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadArtifactLength2?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadArtifactLength2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadReadingLevel2?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadReadingLevel2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundPromptCanvasPayloadTemplateFormat?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundPromptCanvasPayloadTemplateFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestSettingsType?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestSettingsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestScope?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsCreateRequestOauthTokenEndpointAuthMethod2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseSettingsType?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseSettingsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsResponseOauthTokenEndpointAuthMethod2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2?))
                {
                    return new global::LangSmith.JsonConverters.PlaygroundSettingsUpdateRequestOauthTokenEndpointAuthMethod2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProvisioningMethod?))
                {
                    return new global::LangSmith.JsonConverters.ProvisioningMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProxyRequestMethod))
                {
                    return new global::LangSmith.JsonConverters.ProxyRequestMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ProxyRequestMethod?))
                {
                    return new global::LangSmith.JsonConverters.ProxyRequestMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsRepoType?))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource2))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsSource2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RepoWithLookupsSource2?))
                {
                    return new global::LangSmith.JsonConverters.RepoWithLookupsSource2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection))
                {
                    return new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResolvedAnnotationQueueRunSchemaSection?))
                {
                    return new global::LangSmith.JsonConverters.ResolvedAnnotationQueueRunSchemaSectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResourceType))
                {
                    return new global::LangSmith.JsonConverters.ResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ResourceType?))
                {
                    return new global::LangSmith.JsonConverters.ResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome))
                {
                    return new global::LangSmith.JsonConverters.RuleLogActionOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RuleLogActionOutcome?))
                {
                    return new global::LangSmith.JsonConverters.RuleLogActionOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunDateOrder))
                {
                    return new global::LangSmith.JsonConverters.RunDateOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunDateOrder?))
                {
                    return new global::LangSmith.JsonConverters.RunDateOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunGroupBy))
                {
                    return new global::LangSmith.JsonConverters.RunGroupByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunGroupBy?))
                {
                    return new global::LangSmith.JsonConverters.RunGroupByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow))
                {
                    return new global::LangSmith.JsonConverters.RunRuleSpendLimitWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRuleSpendLimitWindow?))
                {
                    return new global::LangSmith.JsonConverters.RunRuleSpendLimitWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesAlertType))
                {
                    return new global::LangSmith.JsonConverters.RunRulesAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunRulesAlertType?))
                {
                    return new global::LangSmith.JsonConverters.RunRulesAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunSelect))
                {
                    return new global::LangSmith.JsonConverters.RunSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunSelect?))
                {
                    return new global::LangSmith.JsonConverters.RunSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupByAttribute?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupByAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseAttribute?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsGroupBySeriesResponseSetBy2?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsGroupBySeriesResponseSetBy2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsSelect))
                {
                    return new global::LangSmith.JsonConverters.RunStatsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunStatsSelect?))
                {
                    return new global::LangSmith.JsonConverters.RunStatsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum))
                {
                    return new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsFilterDataSourceTypeEnum?))
                {
                    return new global::LangSmith.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys))
                {
                    return new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsGenerateQueryFeedbackKeys?))
                {
                    return new global::LangSmith.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SavedRunClusteringJobRequestModel))
                {
                    return new global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SavedRunClusteringJobRequestModel?))
                {
                    return new global::LangSmith.JsonConverters.SavedRunClusteringJobRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SessionSortableColumns))
                {
                    return new global::LangSmith.JsonConverters.SessionSortableColumnsJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SessionSortableColumns?))
                {
                    return new global::LangSmith.JsonConverters.SessionSortableColumnsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType))
                {
                    return new global::LangSmith.JsonConverters.SingleCustomChartResponseSerializedChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SingleCustomChartResponseSerializedChartType?))
                {
                    return new global::LangSmith.JsonConverters.SingleCustomChartResponseSerializedChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByComparativeExperimentColumn))
                {
                    return new global::LangSmith.JsonConverters.SortByComparativeExperimentColumnJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByComparativeExperimentColumn?))
                {
                    return new global::LangSmith.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByDatasetColumn))
                {
                    return new global::LangSmith.JsonConverters.SortByDatasetColumnJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortByDatasetColumn?))
                {
                    return new global::LangSmith.JsonConverters.SortByDatasetColumnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder))
                {
                    return new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SortParamsForRunsComparisonViewSortOrder?))
                {
                    return new global::LangSmith.JsonConverters.SortParamsForRunsComparisonViewSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SourceType))
                {
                    return new global::LangSmith.JsonConverters.SourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SourceType?))
                {
                    return new global::LangSmith.JsonConverters.SourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantShareTokensResponseEntitieDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantUsageLimitType))
                {
                    return new global::LangSmith.JsonConverters.TenantUsageLimitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TenantUsageLimitType?))
                {
                    return new global::LangSmith.JsonConverters.TenantUsageLimitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType))
                {
                    return new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadMessagesFormatType?))
                {
                    return new global::LangSmith.JsonConverters.ThreadMessagesFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ToolMessageStatus))
                {
                    return new global::LangSmith.JsonConverters.ToolMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ToolMessageStatus?))
                {
                    return new global::LangSmith.JsonConverters.ToolMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ToolMessageChunkStatus))
                {
                    return new global::LangSmith.JsonConverters.ToolMessageChunkStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ToolMessageChunkStatus?))
                {
                    return new global::LangSmith.JsonConverters.ToolMessageChunkStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier))
                {
                    return new global::LangSmith.JsonConverters.TraceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TraceTier?))
                {
                    return new global::LangSmith.JsonConverters.TraceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TrueFalseLiteral))
                {
                    return new global::LangSmith.JsonConverters.TrueFalseLiteralJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TrueFalseLiteral?))
                {
                    return new global::LangSmith.JsonConverters.TrueFalseLiteralNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UsageLimitScope))
                {
                    return new global::LangSmith.JsonConverters.UsageLimitScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UsageLimitScope?))
                {
                    return new global::LangSmith.JsonConverters.UsageLimitScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UsageLimitType))
                {
                    return new global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UsageLimitType?))
                {
                    return new global::LangSmith.JsonConverters.UsageLimitTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel))
                {
                    return new global::LangSmith.JsonConverters.AgentCreateIssuesAgentRequestAnalysisLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel?))
                {
                    return new global::LangSmith.JsonConverters.AgentCreateIssuesAgentRequestAnalysisLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel))
                {
                    return new global::LangSmith.JsonConverters.AgentIssuesAgentAnalysisLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentIssuesAgentAnalysisLevel?))
                {
                    return new global::LangSmith.JsonConverters.AgentIssuesAgentAnalysisLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel))
                {
                    return new global::LangSmith.JsonConverters.AgentUpdateIssuesAgentRequestAnalysisLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AgentUpdateIssuesAgentRequestAnalysisLevel?))
                {
                    return new global::LangSmith.JsonConverters.AgentUpdateIssuesAgentRequestAnalysisLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionTarget?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertActionBaseTarget?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertActionBaseTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAggregation?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleAttribute?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleOperator?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleType?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAggregation?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseAttribute?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseAttributeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseOperator?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AlertsAlertRuleBaseType?))
                {
                    return new global::LangSmith.JsonConverters.AlertsAlertRuleBaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemListStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemListStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueItemType?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueReviewStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus?))
                {
                    return new global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueReviewStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalAbacAttributeName))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalAbacAttributeName?))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalAbacAttributeNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalAbacOperator))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalAbacOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalAbacOperator?))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalAbacOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalPermission))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.AuthzInternalPermission?))
                {
                    return new global::LangSmith.JsonConverters.AuthzInternalPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DataPlanesStatus))
                {
                    return new global::LangSmith.JsonConverters.DataPlanesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DataPlanesStatus?))
                {
                    return new global::LangSmith.JsonConverters.DataPlanesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorsEvaluatorBuildStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorBuildStatus?))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorsEvaluatorBuildStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorType))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.EvaluatorsEvaluatorType?))
                {
                    return new global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitMetric))
                {
                    return new global::LangSmith.JsonConverters.GatewayPoliciesRateLimitMetricJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitMetric?))
                {
                    return new global::LangSmith.JsonConverters.GatewayPoliciesRateLimitMetricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitWindow))
                {
                    return new global::LangSmith.JsonConverters.GatewayPoliciesRateLimitWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GatewayPoliciesRateLimitWindow?))
                {
                    return new global::LangSmith.JsonConverters.GatewayPoliciesRateLimitWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState))
                {
                    return new global::LangSmith.JsonConverters.IssuesLinearSyncStateJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesLinearSyncState?))
                {
                    return new global::LangSmith.JsonConverters.IssuesLinearSyncStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesStatus))
                {
                    return new global::LangSmith.JsonConverters.IssuesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.IssuesStatus?))
                {
                    return new global::LangSmith.JsonConverters.IssuesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.McpVendorsMcpVendorStatus))
                {
                    return new global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.McpVendorsMcpVendorStatus?))
                {
                    return new global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect))
                {
                    return new global::LangSmith.JsonConverters.QueryPublicSharedTraceRunsRequestBodySelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryPublicSharedTraceRunsRequestBodySelect?))
                {
                    return new global::LangSmith.JsonConverters.QueryPublicSharedTraceRunsRequestBodySelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunSelectField))
                {
                    return new global::LangSmith.JsonConverters.QueryRunSelectFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunSelectField?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunSelectFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunStatus))
                {
                    return new global::LangSmith.JsonConverters.QueryRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunStatus?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunType))
                {
                    return new global::LangSmith.JsonConverters.QueryRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.QueryRunType?))
                {
                    return new global::LangSmith.JsonConverters.QueryRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsRunRunType))
                {
                    return new global::LangSmith.JsonConverters.RunsRunRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.RunsRunRunType?))
                {
                    return new global::LangSmith.JsonConverters.RunsRunRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiGitMountRefSpecTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiGitMountRefSpecType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiGitMountRefSpecTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountKind))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountKindJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountKind?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountSpecDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxapiMountSpecDiscriminatorType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxapiMountSpecDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesHeaderType))
                {
                    return new global::LangSmith.JsonConverters.SandboxesHeaderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SandboxesHeaderType?))
                {
                    return new global::LangSmith.JsonConverters.SandboxesHeaderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.SharedProblemDetailsErrorClass?))
                {
                    return new global::LangSmith.JsonConverters.SharedProblemDetailsErrorClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField))
                {
                    return new global::LangSmith.JsonConverters.ThreadsSingleThreadStatsSelectFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadsSingleThreadStatsSelectField?))
                {
                    return new global::LangSmith.JsonConverters.ThreadsSingleThreadStatsSelectFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadsThreadTraceSelectField))
                {
                    return new global::LangSmith.JsonConverters.ThreadsThreadTraceSelectFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ThreadsThreadTraceSelectField?))
                {
                    return new global::LangSmith.JsonConverters.ThreadsThreadTraceSelectFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType))
                {
                    return new global::LangSmith.JsonConverters.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationType?))
                {
                    return new global::LangSmith.JsonConverters.TracerSessionIssuesAgentWebhooksIssuesAgentWebhookDestinationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2))
                {
                    return new global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2?))
                {
                    return new global::LangSmith.JsonConverters.BetaGetRunsFromInsightsJobApiV1SessionsSessionIdInsightsJobIdRunsGetAttributeSortOrder2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService))
                {
                    return new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetService?))
                {
                    return new global::LangSmith.JsonConverters.GetCurrentWorkspaceEncryptedSecretsApiV1WorkspacesCurrentSecretsEncryptedGetServiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2))
                {
                    return new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRulesApiV1RunsRulesGetType2?))
                {
                    return new global::LangSmith.JsonConverters.ListRulesApiV1RunsRulesGetType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2))
                {
                    return new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2?))
                {
                    return new global::LangSmith.JsonConverters.GetAnnotationQueuesApiV1AnnotationQueuesGetQueueType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2))
                {
                    return new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2?))
                {
                    return new global::LangSmith.JsonConverters.GetRunsFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2))
                {
                    return new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2?))
                {
                    return new global::LangSmith.JsonConverters.GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2))
                {
                    return new global::LangSmith.JsonConverters.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2?))
                {
                    return new global::LangSmith.JsonConverters.ListPlaygroundSettingsApiV1PlaygroundSettingsGetScope2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetIsArchived2?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoType2?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetRepoTypesVariant1Item?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetRepoTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource2))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSource2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSource2?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSource2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField2))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListReposApiV1ReposGetSortField2?))
                {
                    return new global::LangSmith.JsonConverters.ListReposApiV1ReposGetSortField2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetIsArchived2?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoType2?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1Item?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetRepoTypesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetSource2JsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ListRepoTagsApiV1ReposTagsGetSource2?))
                {
                    return new global::LangSmith.JsonConverters.ListRepoTagsApiV1ReposTagsGetSource2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsItemType?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformAnnotationQueuesItemsDirection?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformAnnotationQueuesItemsDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType))
                {
                    return new global::LangSmith.JsonConverters.DeletePlatformHubReposDirectoriesRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.DeletePlatformHubReposDirectoriesRepoType?))
                {
                    return new global::LangSmith.JsonConverters.DeletePlatformHubReposDirectoriesRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesStatus?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesActivityItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesActivityItem?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesActivityItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetPlatformIssuesSortBy?))
                {
                    return new global::LangSmith.JsonConverters.GetPlatformIssuesSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetRunsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetRunsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetRunsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetThreadsStatsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetThreadsStatsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetThreadsStatsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetThreadsStatsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetThreadsTracesSelect))
                {
                    return new global::LangSmith.JsonConverters.GetThreadsTracesSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetThreadsTracesSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetThreadsTracesSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect))
                {
                    return new global::LangSmith.JsonConverters.GetTracesRunsSelectJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.GetTracesRunsSelect?))
                {
                    return new global::LangSmith.JsonConverters.GetTracesRunsSelectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.ReadSingleChartApiV1ChartsChartIdPostResponseDiscriminatorChartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType))
                {
                    return new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType?))
                {
                    return new global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[4];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}