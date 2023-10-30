using CamundaForm.CamundaModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net;

namespace CamundaForm.CamundaApi.Auth;

public class PostService
{
    public static  async Task<AuthResponse> GenerateToken(string camundaBaseUrl)
    {
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var p = new Model
        {
            Type = 0,
            GroupId = null,
            ResourceId = "*",
            ResourceType = 1,
            UserId = "*",
            Permissions = new[] { "CREATE", "READ" }
        };
        var uri = new Uri($@"{camundaBaseUrl}/authorization/create");
        var response = await httpClient.PostAsJsonAsync(uri, p);

        if (response.IsSuccessStatusCode)
        {
            var strResult = await response.Content.ReadAsStringAsync();
           var result = JsonConvert.DeserializeObject<AuthResponse>(strResult);
           return result;
        }
        else if (response.StatusCode == HttpStatusCode.InternalServerError)
        {
            throw new Exception("توکن وجود دارد");
        }
        else
        {
            throw new Exception($"HTTP error: {response.StatusCode}");
        }
    }
}