using CamundaForm.CamundaForms;
using CamundaForm.CamundaModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CamundaForm.CamundaApi.Auth;

public class GetService
{
    public static async Task<List<string>> GetToken(string camundaBaseUrl)
    {
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var uri = new Uri($@"{camundaBaseUrl}/authorization");
        var response = await httpClient.GetStringAsync(uri + "?type=0");
        var result = JsonConvert.DeserializeObject<List<GetTokenResponse>>(response);

        var str = new List<string>();

        foreach (var item in result)
        {
            var p = string.Empty;
            foreach (var permission in item.Permissions) p += permission + " ";

            var q = $"token is = " +
                    $" Id {item.Id} " +
                    $" GroupId {item.GroupId} " +
                    $" RemovalTime {item.RemovalTime} " +
                    $" Type{item.Type} " +
                    $" UserId {item.UserId} " +
                    $" RootProcessInstanceId {item.RootProcessInstanceId} " +
                    $" ResourceType {item.ResourceType} " +
                    $" ResourceId {item.ResourceId} " +
                    $" permission {p} ";

            str.Add(q);
   
        }

        return str;
    }
}