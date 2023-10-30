using CamundaForm.CamundaModel;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.InteropServices;

namespace CamundaForm.CamundaApi.ProcessWorkFlow;

public class StepAService
{

    public static async Task<NextStepResponse> StepA(string camundaBaseUrl , string processInstanceId, GetActivityInstanceResponse processInfo)
    {
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        var uri = new Uri($@"{camundaBaseUrl}/process-instance/{processInstanceId}/modification");
        var start = new NextStepRequest()
        {
            SkipIoMappings = false,
            SkipCustomListeners = false,
            Annotation = "ok",
            Instructions = new[]
            {
                    new Instruction()
                    {
                        Type = "startAfterActivity",
                        ActivityId = processInfo.ActivityId,
                        Variables = new InstructionVariablesModel()
                        {
                            Mobile = new Var()
                            {
                                Type = "long",
                                Local = false,
                                Value = "09355555"
                            },
                            Name = new Var()
                            {
                                Type = "string",
                                Local = false,
                                Value = "alllllllliiiii"
                            }
                        },
                    },
                    //new Instruction()
                    //{
                    //    Type = "cancel",
                    //    ActivityInstanceId = processInfo.ParentActivityInstanceId.Value.ToString()
                    //}
                }
        };
        var result = await httpClient.PostAsJsonAsync(uri, start);
        var response = await result.Content.ReadAsStringAsync();
        var workFlow = Newtonsoft.Json.JsonConvert.DeserializeObject<NextStepResponse>(response);
        return workFlow;
    }




}