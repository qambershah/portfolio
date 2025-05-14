using System.Net.Http.Json;

public class JsonProjectService
{
    private readonly HttpClient _http;

    public JsonProjectService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<ProjectModel>> GetProjectsAsync()
        => await _http.GetFromJsonAsync<List<ProjectModel>>("data/projects.json") ?? new();
}

public class ProjectModel
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string RepoUrl { get; set; } = "";
}
