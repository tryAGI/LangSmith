using System.Text.RegularExpressions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var text = await File.ReadAllTextAsync(path);

text = text.Replace("\"openapi\":\"3.1.0\"", "\"openapi\":\"3.0.1\"");
// Regex replace string like "\"const\": \"$any\"," to string empty
text = Regex.Replace(text, "\"const\":\\s*\"([^\"]+)\",", "");
text = text.Replace("\"prefixItems\":[{\"type\":\"string\"},{\"type\":\"string\"}],", "\"items\":{\"type\":\"string\"},");

text = text.Replace("\"API Key\"", "\"ApiKey\"");
text = text.Replace("\"Tenant ID\"", "\"TenantId\"");
text = text.Replace("\"Bearer Auth\"", "\"BearerAuth\"");
text = text.Replace("\"Organization ID\"", "\"OrganizationId\"");

var openApiDocument = new OpenApiStringReader().Read(text, out var diagnostics);

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

text = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(text, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, text);
