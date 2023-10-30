using CamundaForm.CamundaModel;
using System.Net.Http.Headers;

namespace CamundaForm.CamundaApi.ProcessWorkFlow;

public class ProcessInfo
{
    public static async Task<GetActivityInstanceResponse> GetProcessInfo(string camundaBaseUrl, string id)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var uri = new Uri($@"{camundaBaseUrl}/process-instance/{id}/activity-instances");
        var result = await httpClient.GetAsync(uri);
        var response = await result.Content.ReadAsStringAsync();
        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<GetActivityInstanceResponse>(response);
        return data;
    }
}