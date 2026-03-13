using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson.Replace("\"API Key\"", "\"ApiKey\"");
yamlOrJson = yamlOrJson.Replace("\"Tenant ID\"", "\"TenantId\"");
yamlOrJson = yamlOrJson.Replace("\"Bearer Auth\"", "\"BearerAuth\"");
yamlOrJson = yamlOrJson.Replace("\"Organization ID\"", "\"OrganizationId\"");
yamlOrJson = yamlOrJson.Replace("[Beta]", "Beta");
yamlOrJson = yamlOrJson.Replace("\"TTL Settings\"", "\"Workspace TTL Settings\"");

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);
var paths = openApiDocument.Paths ?? throw new InvalidOperationException("The OpenAPI document does not contain any paths.");

var ownerParameter = new OpenApiParameter
{
    Name = "owner",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = JsonSchemaType.String,
    },
};
var repoParameter = new OpenApiParameter
{
    Name = "repo",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = JsonSchemaType.String,
    },
};
var jobIdParameter = new OpenApiParameter
{
    Name = "job_id",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = JsonSchemaType.String,
        Format = "uuid",
    },
};

ClearOperationParameters(paths, "/runs");
ClearOperationParameters(paths, "/runs/batch");

EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/tags", ownerParameter);
EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/tags/{tag_name}", ownerParameter);
EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/optimization-jobs", ownerParameter);
EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}", ownerParameter, repoParameter);
EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs", ownerParameter, repoParameter);
EnsureOperationParameters(paths, "/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs/{log_id}", ownerParameter, repoParameter, jobIdParameter);

foreach (var (_, pathItem) in paths)
{
    if (pathItem?.Operations is not { } operations)
    {
        continue;
    }

    foreach (var (_, operation) in operations)
    {
        // AutoSDK currently derives method names from summaries for this repo.
        operation.Summary = operation.Summary?.Replace("'", string.Empty, StringComparison.Ordinal);
    }
}

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);

static void ClearOperationParameters(OpenApiPaths paths, string path)
{
    foreach (var operation in GetOperations(paths, path))
    {
        operation.Parameters ??= [];
        operation.Parameters.Clear();
    }
}

static void EnsureOperationParameters(
    OpenApiPaths paths,
    string path,
    params OpenApiParameter[] parameters)
{
    foreach (var operation in GetOperations(paths, path))
    {
        foreach (var parameter in parameters)
        {
            EnsureOperationParameter(operation, parameter);
        }
    }
}

static IEnumerable<OpenApiOperation> GetOperations(OpenApiPaths paths, string path)
{
    if (!paths.TryGetValue(path, out var pathItem) || pathItem?.Operations is not { } operations)
    {
        throw new InvalidOperationException($"Expected OpenAPI path '{path}' was not found.");
    }

    return operations.Values;
}

static void EnsureOperationParameter(OpenApiOperation operation, OpenApiParameter parameter)
{
    operation.Parameters ??= [];

    foreach (var existingParameter in operation.Parameters)
    {
        if (string.Equals(existingParameter.Name, parameter.Name, StringComparison.Ordinal) &&
            existingParameter.In == parameter.In)
        {
            return;
        }
    }

    operation.Parameters.Add(parameter);
}
