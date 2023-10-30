using System.Net.Http.Headers;
using System.Net.Http.Json;
using CamundaForm.CamundaModel;

namespace CamundaForm.CamundaApi.StartInstance
{
    public class Service
    {
        public static async void StartProcess(string camundaBaseUrl)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var uri = new Uri($@"{camundaBaseUrl}/process-definition/key/TaskModelUniqueBpmnId/tenant-id/MyTenant/start");
            var start = new StartProcessInstanceModel()
            {
                BusinessKey = "default",
                Variables = new StartProcessInstanceVariableModel()
                {
                    Name = new Name() { Type = "long", Value = "0935" },
                    Mobile = new Mobile() { Type = "string", Value = "aliiiiii" }
                }
            };
            var result = await httpClient.PostAsJsonAsync(uri, start);
            var response = await result.Content.ReadAsStringAsync();
            var workFlow = Newtonsoft.Json.JsonConvert.DeserializeObject<NextStepResponse>(response);
        }
    }
}
