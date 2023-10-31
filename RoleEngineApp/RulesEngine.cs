using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RulesEngine.Models;

namespace RoleEngineApp
{
    using RulesEngine;
    using RulesEngine.Interfaces;


    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }





    public class RegisterRule
    {

        public    async Task<List<RuleResultTree>> Evaluate()
        {
            var ruleEngine = RoleRegister();


            var mamad = new Student()
            {
                Age = 16,
                Name = "mamad"
            };
            var reza = new Student()
            {
                Age = 16,
                Name = "reza"
            };
      
            var result = await ruleEngine.ExecuteActionWorkflowAsync("Validation", "RegisterStudent", new RuleParameter[]
            {
                new RuleParameter(mamad.Name, mamad.Age),
            });

            return result.Results;
        }

        private RulesEngine RoleRegister()
        {
            var workflows = new List<Workflow>()
            {
                new Workflow()
                {
                    WorkflowName = "Validation",
                    Rules = new List<global::RulesEngine.Models.Rule>()
                    {
                        new global::RulesEngine.Models.Rule()
                        {
                            RuleName = "RegisterStudent",
                            ErrorMessage = "Too kids",
                            Enabled = true,
                            SuccessEvent = "RegisterStudent" ,
                            Expression = "mamad.Age > 7"
                        }
                    }
                }
            };
            var engine = new RulesEngine(workflows.ToArray());
            return engine;
        }
        public void RegisterStudent()
        {

        }
    }


  


}
