using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

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

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

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

foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags"].Operations)
{
    operation.Parameters.Add(ownerParameter);
}
foreach (var (_, operation) in openApiDocument.Paths["/api/v1/repos/{owner}/{repo}/tags/{tag_name}"].Operations)
{
    operation.Parameters.Add(ownerParameter);
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
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

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
