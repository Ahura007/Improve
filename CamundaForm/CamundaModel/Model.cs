using Newtonsoft.Json;

namespace CamundaForm.CamundaModel;


public enum WorkFlowStep
{
    A, B, C, D
}

public  class GetActivityInstanceResponse
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("parentActivityInstanceId")]
    public Guid? ParentActivityInstanceId { get; set; }

    [JsonProperty("activityId")]
    public string ActivityId { get; set; }

    [JsonProperty("activityType")]
    public string ActivityType { get; set; }

    [JsonProperty("processInstanceId")]
    public Guid ProcessInstanceId { get; set; }

    [JsonProperty("processDefinitionId")]
    public string ProcessDefinitionId { get; set; }

    [JsonProperty("childActivityInstances")]
    public GetActivityInstanceResponse[] ChildActivityInstances { get; set; }

    [JsonProperty("childTransitionInstances")]
    public object[] ChildTransitionInstances { get; set; }

    [JsonProperty("executionIds")]
    public Guid[] ExecutionIds { get; set; }

    [JsonProperty("activityName")]
    public string ActivityName { get; set; }

    [JsonProperty("incidentIds")]
    public Guid[] IncidentIds { get; set; }

    [JsonProperty("incidents")]
    public Incident[] Incidents { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public  class Incident
{
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("activityId")]
    public string ActivityId { get; set; }
}

public class StartProcessInstanceModel
{
    [JsonProperty("variables")]
    public StartProcessInstanceVariableModel Variables { get; set; }

    [JsonProperty("businessKey")]
    public string BusinessKey { get; set; }
}

public class StartProcessInstanceVariableModel
{
    [JsonProperty("aVariable")]
    public Mobile Mobile { get; set; }

    [JsonProperty("anotherVariable")]
    public Name Name { get; set; }
}

public class Mobile
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

public class Name
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}

public  class NextStepRequest
{
    [JsonProperty("skipCustomListeners")]
    public bool SkipCustomListeners { get; set; }

    [JsonProperty("skipIoMappings")]
    public bool SkipIoMappings { get; set; }

    [JsonProperty("instructions")]
    public Instruction[] Instructions { get; set; }

    [JsonProperty("annotation")]
    public string Annotation { get; set; }

    [JsonProperty("transitionId")]
    public string TransitionId { get; set; }
}

public  class Instruction
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("activityId", NullValueHandling = NullValueHandling.Ignore)]
    public string ActivityId { get; set; }

    [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
    public InstructionVariablesModel Variables { get; set; }

    [JsonProperty("activityInstanceId", NullValueHandling = NullValueHandling.Ignore)]
    public string ActivityInstanceId { get; set; }
}

public  class InstructionVariablesModel
{
    [JsonProperty("var")]
    public Var Name { get; set; }

    [JsonProperty("varLocal")]
    public Var Mobile { get; set; }
}

public  class Var
{
    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("local")]
    public bool Local { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}


public  class NextStepResponse
{
    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("code")]
    public int? Code { get; set; }
}
public class WorkFlow
{
    public string Id { get; set; }
    public string Key { get; set; }
    public string Name { get; set; }
}
public class ProcessInfoData
{
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("businessKey")]
    public object BusinessKey { get; set; }

    [JsonProperty("processDefinitionId")]
    public string ProcessDefinitionId { get; set; }

    [JsonProperty("processDefinitionKey")]
    public string ProcessDefinitionKey { get; set; }

    [JsonProperty("processDefinitionName")]
    public string ProcessDefinitionName { get; set; }

    [JsonProperty("processDefinitionVersion")]
    public long ProcessDefinitionVersion { get; set; }

    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    [JsonProperty("endTime")]
    public object EndTime { get; set; }

    [JsonProperty("removalTime")]
    public object RemovalTime { get; set; }

    [JsonProperty("durationInMillis")]
    public object DurationInMillis { get; set; }

    [JsonProperty("startUserId")]
    public object StartUserId { get; set; }

    [JsonProperty("startActivityId")]
    public string StartActivityId { get; set; }

    [JsonProperty("deleteReason")]
    public object DeleteReason { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public Guid RootProcessInstanceId { get; set; }

    [JsonProperty("superProcessInstanceId")]
    public object SuperProcessInstanceId { get; set; }

    [JsonProperty("superCaseInstanceId")]
    public object SuperCaseInstanceId { get; set; }

    [JsonProperty("caseInstanceId")]
    public object CaseInstanceId { get; set; }

    [JsonProperty("tenantId")]
    public object TenantId { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }
}
public class Link
{
    [JsonProperty("method")]
    public string Method { get; set; }

    [JsonProperty("href\"")]
    public Uri Href { get; set; }

    [JsonProperty("rel")]
    public string Rel { get; set; }
}
public class AuthResponse
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("permissions")]
    public string?[] Permissions { get; set; }

    [JsonProperty("userId")]
    public string? UserId { get; set; }

    [JsonProperty("groupId")]
    public string? GroupId { get; set; }

    [JsonProperty("resourceType")]
    public int? ResourceType { get; set; }

    [JsonProperty("resourceId")]
    public string? ResourceId { get; set; }

    [JsonProperty("removalTime")]
    public string? RemovalTime { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public string? RootProcessInstanceId { get; set; }

    [JsonProperty("links")]
    public Link[] Links { get; set; }
}
public class GetTokenResponse
{
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("type")]
    public long Type { get; set; }

    [JsonProperty("permissions")]
    public string[] Permissions { get; set; }

    [JsonProperty("userId")]
    public string UserId { get; set; }

    [JsonProperty("groupId")]
    public object GroupId { get; set; }

    [JsonProperty("resourceType")]
    public long ResourceType { get; set; }

    [JsonProperty("resourceId")]
    public string ResourceId { get; set; }

    [JsonProperty("removalTime")]
    public object RemovalTime { get; set; }

    [JsonProperty("rootProcessInstanceId")]
    public object RootProcessInstanceId { get; set; }
}
public class Model
{
    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("permissions")]
    public string?[] Permissions { get; set; }

    [JsonProperty("userId")]
    public string? UserId { get; set; }

    [JsonProperty("groupId")]
    public string? GroupId { get; set; }

    [JsonProperty("resourceType")]
    public int? ResourceType { get; set; }

    [JsonProperty("resourceId")]
    public string? ResourceId { get; set; }
}