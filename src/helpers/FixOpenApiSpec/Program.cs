using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Microsoft.OpenApi.Validations;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

yamlOrJson = yamlOrJson.Replace("\"API Key\"", "\"ApiKey\"");
yamlOrJson = yamlOrJson.Replace("\"Tenant ID\"", "\"TenantId\"");
yamlOrJson = yamlOrJson.Replace("\"Bearer Auth\"", "\"BearerAuth\"");
yamlOrJson = yamlOrJson.Replace("\"Organization ID\"", "\"OrganizationId\"");

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader(new OpenApiReaderSettings
{
    RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
}).Read(yamlOrJson, out var diagnostics);

var ownerParameter = new OpenApiParameter
{
    Name = "owner",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = "string"
    },
};
var repoParameter = new OpenApiParameter
{
    Name = "repo",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = "string"
    },
};
var jobIdParameter = new OpenApiParameter
{
    Name = "job_id",
    In = ParameterLocation.Path,
    Required = true,
    Schema = new OpenApiSchema
    {
        Type = "string",
        Format = "uuid"
    },
};

foreach (var (_, operation) in openApiDocument.Paths["/runs"].Operations)
{
    operation.Parameters.Clear();
}
foreach (var (_, operation) in openApiDocument.Paths["/runs/batch"].Operations)
{
    operation.Parameters.Clear();
}

foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags"].Operations)
{
    operation.Parameters.Add(ownerParameter);
}

foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags"].Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags/{tag_name}"].Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs"].Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}"].Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs"].Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/optimization-jobs/{job_id}/logs/{log_id}"].Operations)
{
    operation.Parameters.Add(ownerParameter);
    operation.Parameters.Add(repoParameter);
    operation.Parameters.Add(jobIdParameter);
}

openApiDocument.Servers.Add(new OpenApiServer { Url = "https://api.smith.langchain.com" });

openApiDocument.SecurityRequirements = new List<OpenApiSecurityRequirement>
{
    // X-API-Key in header
    new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new List<string>()
        }
    }
};

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader(new OpenApiReaderSettings
{
    RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
}).Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);
