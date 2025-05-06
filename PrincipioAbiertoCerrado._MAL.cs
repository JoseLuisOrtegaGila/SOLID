using RestSharp;
using System.Threading.Tasks;
public class TodoService
{
    private readonly RestClient _client;
    public TodoService()
    {
        _client = new RestClient("https://jsonplaceholder.typicode.com");
    }
    public async Task<string> GetTodoItems()
    {
        var request = new RestRequest("todos", Method.Get);
        var response = await _client.ExecuteAsync(request);
        
        if (response.IsSuccessful)
        {
            return response.Content;
        }        
        throw new Exception($"Error: {response.StatusCode} - {response.ErrorMessage}");
    }
}
public class PostService
{
    private readonly RestClient _client;
    public PostService()
    {
        _client = new RestClient("https://jsonplaceholder.typicode.com");
    }
    public async Task<string> GetPosts()
    {
        var request = new RestRequest("posts", Method.Get);
        var response = await _client.ExecuteAsync(request);
  
        if (response.IsSuccessful)
        {
            return response.Content;
        }       
        throw new Exception($"Error: {response.StatusCode} - {response.ErrorMessage}");
    }
}

