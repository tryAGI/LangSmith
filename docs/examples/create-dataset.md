# Create Dataset



This example assumes `using LangSmith;` is in scope and `apiKey` contains your LangSmith API key.

```csharp
using var client = GetAuthorizedClient();

var response = await client.Datasets.CreateDatasetAsync(name: "test3");
try
{
    var response2 = await client.Datasets.DeleteDatasetAsync(datasetId: response.Id);
}
catch (Exception e)
{
    Console.WriteLine(e);
}
```