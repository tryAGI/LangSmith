namespace LangSmith.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CreateDataset()
    {
        using var api = GetAuthorizedApi();
        
        var response = await api.Datasets.CreateDatasetAsync(name: "test3");
        try
        {
            var response2 = await api.Datasets.DeleteDatasetAsync(datasetId: response.Id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}