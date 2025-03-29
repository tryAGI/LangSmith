namespace LangSmith.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateDataset()
    {
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
    }
}