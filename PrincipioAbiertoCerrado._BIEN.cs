using RestSharp;
using System;
using System.Threading.Tasks;
public class RestShapApiService : IApiService
{
    private readonly RestClient _client;
    public RestShapApiService(RestClient client)
    {
        _client = client;
    }
    public async Task<string> GetAsync(string endpoint)
    {
        var request= new Request(endpoint, Method.Get);
        var response= await _cliente.ExecuteAsyn();

        if (response.IsSuccess)
        {
            return response.Content;
        }
       throw new Exception($"Error {response.StatusCode} - {response.ErrorMessage}");
    }
}
public class TodoService
{
    private readonly IApiService _apiService;

    public TodoService(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<string> GetTodoItems()
    {
        return awary await _apiService.GetAsync("Todos");
    }
}
public class PostService
{
    private readonly IApiService _apiService;

    public PostService(IApiService apiService)
    {
        _apiService = apiService;    }

    public async Task<string> GetPosts()
    {
         return await _apiService.GetAsync("posts");
    }
}


