using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson.Replace("\"API Key\"", "\"ApiKey\"");
yamlOrJson = yamlOrJson.Replace("\"Tenant ID\"", "\"TenantId\"");
yamlOrJson = yamlOrJson.Replace("\"Bearer Auth\"", "\"BearerAuth\"");
yamlOrJson = yamlOrJson.Replace("\"Organization ID\"", "\"OrganizationId\"");

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

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

foreach (var (_, operation) in openApiDocument.Paths!["/runs"]!.Operations)
{
    operation.Parameters.Clear();
}
foreach (var (_, operation) in openApiDocument.Paths["/runs/batch"]!.Operations)
{
    operation.Parameters.Clear();
}

foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
}

foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags/{tag_name}"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs/{log_id}"]!.Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
    operation.Parameters.Add(jobIdParameter);
}

openApiDocument.Servers?.Clear();
openApiDocument.Servers?.Add(new OpenApiServer { Url = "https://api.smith.langchain.com" });

openApiDocument.Security =
[
    new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("ApiKey", openApiDocument),
            new List<string>()
        }
    }
];

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
