namespace RoleEngineApp;

public class Wrestling
{
    public string Name { get; set; }
    public decimal Weight { get; set; }
}

public class RuleResult
{
    public List<string> ValidRole { get; set; }=new List<string>();
    public List<string> InValidRole { get; set; } = new List<string>();
}

public class Rule
{
    public string Description { get; set; }
    public Func<Wrestling, bool> Condition { get; set; }
}

public interface IRuleEngine
{
    void AddRule(string description, Func<Wrestling, bool> condition);
    RuleResult RunRules(Wrestling wrestling);
}

public class RuleEngine: IRuleEngine
{
    private readonly List<Rule> rules = new List<Rule>();

    public void AddRule(string description, Func<Wrestling, bool> condition)
    {
        rules.Add(new Rule { Description = description, Condition = condition });
    }

    public RuleResult RunRules(Wrestling wrestling)
    {
        var result = new RuleResult();
        foreach (var rule in rules)
        {
            if (rule.Condition(wrestling))
            {
                result.ValidRole.Add($"Rule: {rule.Description} - wrestling {wrestling.Name} is valid.");
            }
            else
            {
                result.InValidRole.Add($"Rule: {rule.Description} - wrestling {wrestling.Name} is Invalid.");
            }
        }
        return result;
    }



}


public class Self
{
    public static void StartRoleEngine()
    {
        var engine = new RuleEngine();
        engine.AddRule("Group A", wrestler => wrestler.Weight > 48 && wrestler.Weight < 52);
        engine.AddRule("Group B", wrestler => wrestler.Weight > 58 && wrestler.Weight < 62);
        engine.AddRule("Group C", wrestler => wrestler.Weight > 68 && wrestler.Weight < 72);

        var mamad = new Wrestling
        {
            Name = "mamad",
            Weight = 47
        };

        var ali = new Wrestling
        {
            Name = "ali",
            Weight = 59
        };

        var reza = new Wrestling
        {
            Name = "reza",
            Weight = 68
        };


        var result1 = engine.RunRules(mamad);
        var result2 = engine.RunRules(ali);
        var result3 = engine.RunRules(reza);
    }
}
