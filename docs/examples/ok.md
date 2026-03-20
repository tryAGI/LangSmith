# Ok



This example assumes `using LangSmith;` is in scope and `apiKey` contains your LangSmith API key.

```csharp
using var client = GetAuthorizedClient();
var response = await client.OkAsync();
```