using CamundaForm.CamundaModel;
using System.Net.Http.Headers;

namespace CamundaForm.CamundaApi.LoadProcess;

public class GetAllProcess
{
    public static async Task<List<string>> Loader(string camundaBaseUrl)
    {

        var str = new List<string>();

        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var uri = new Uri($@"{camundaBaseUrl}/history/process-instance?sortBy=startTime&sortOrder=desc");
        var result = await httpClient.GetAsync(uri);
        var response = await result.Content.ReadAsStringAsync();
        var workFlow = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProcessInfoData>>(response);

        str.Add("Item Count = " + workFlow.Count);

        foreach (var item in workFlow)
        {
            var q = $"{item.Id}__*__{item.ProcessDefinitionId}";
            str.Add(q);
        }

        return str;
    }

}