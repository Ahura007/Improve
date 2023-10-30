using System.Net.Http.Headers;

namespace CamundaForm.CamundaApi.DeleteProcess;

public class Delete
{
    public static async void DeleteProcess(string camundaBaseUrl, string processDefinitionId)
    {
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var uri = new Uri($@"{camundaBaseUrl}/process-definition/{processDefinitionId}?cascade=true&skipCustomListeners=true&skipIoMappings=true");
        var result = await httpClient.DeleteAsync(uri);
    }
}