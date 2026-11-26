using System.Net;
using System.Net.Http;
using System.Text;
using Xunit;

public class JsonProjectServiceTests
{
    [Fact]
    public async Task GetProjectsAsync_DeserializesProjectList()
    {
        using var http = CreateClient("""
            [{"title":"Demo","description":"Description","repoUrl":"https://github.com/example/demo"}]
            """);
        var service = new JsonProjectService(http);

        var projects = await service.GetProjectsAsync();

        var project = Assert.Single(projects);
        Assert.Equal("Demo", project.Title);
        Assert.Equal("Description", project.Description);
        Assert.Equal("https://github.com/example/demo", project.RepoUrl);
    }

    [Fact]
    public async Task GetProjectsAsync_ReturnsEmptyListForJsonNull()
    {
        using var http = CreateClient("null");
        var service = new JsonProjectService(http);

        var projects = await service.GetProjectsAsync();

        Assert.Empty(projects);
    }

    private static HttpClient CreateClient(string json)
    {
        var handler = new StubHttpMessageHandler(json);
        return new HttpClient(handler) { BaseAddress = new Uri("https://portfolio.test/") };
    }

    private sealed class StubHttpMessageHandler(string json) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Assert.Equal("data/projects.json", request.RequestUri?.PathAndQuery.TrimStart('/'));
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            });
        }
    }
}
