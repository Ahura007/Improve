namespace CamundaForm.CamundaApi.WorkflowList;

public class WorkFlowList
{
    public static async Task<List<string>> GetAllWorkflowList(string camundaBaseUrl)
    {
        var str = new List<string>();
        using var httpClient = new HttpClient();
        try
        {
            var uri = new Uri($@"{camundaBaseUrl}/process-definition");
            var response = await httpClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var workFlow = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CamundaModel.WorkFlow>>(content);

        
                foreach (var item in workFlow)
                {
                    var q = $"flow id is {item.Id} key is {item.Key} name is  {item.Name}";
                    str.Add(q);
                }

                return str;
            }
            throw new Exception($"Failed to retrieve process definitions. Status code: {response.StatusCode}");
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred: {ex.Message}");
        }
    }
}

