using CamundaForm.CamundaApi.ProcessWorkFlow;
using CamundaForm.CamundaModel;

namespace CamundaForm.CamundaForms
{
    public partial class FrmNextStep : Form
    {
        private readonly string _camundaBaseUrl;
        private readonly string _processInstanceId;
        private GetActivityInstanceResponse _processInfo = null;
        private List<GetActivityInstanceResponse> _childActivityInstances = null;

        public FrmNextStep(string camundaBaseUrl, string processInstanceId)
        {
            _processInstanceId = processInstanceId;
            _camundaBaseUrl = camundaBaseUrl;
            InitializeComponent();
            LoadProcess();
        }

        private async void LoadProcess()
        {
            _processInfo = await ProcessInfo.GetProcessInfo(_camundaBaseUrl, _processInstanceId);
            if (!_processInfo.ChildActivityInstances.Any())
                return;

            _childActivityInstances = _processInfo.ChildActivityInstances.ToList();


            foreach (var activityInstance in _childActivityInstances)
            {
                if (activityInstance.Name == WorkFlowStep.A.ToString())
                {
                    SetButtonEnable(WorkFlowStep.A);
                }
                else if (activityInstance.Name == WorkFlowStep.B.ToString())
                {
                    SetButtonEnable(WorkFlowStep.B);
                }
                else if (activityInstance.Name == WorkFlowStep.C.ToString())
                {
                    SetButtonEnable(WorkFlowStep.C);
                }
                else
                {
                    SetButtonEnable(WorkFlowStep.D);
                }
            }
        }

        private async void BtnStepA_Click(object sender, EventArgs e)
        {
            foreach (var activityInstance in _childActivityInstances)
            {
                if (activityInstance.Name == WorkFlowStep.A.ToString())
                {
                    await StepAService.StepA(_camundaBaseUrl, _processInstanceId, activityInstance);
                }
                if (activityInstance.Name == WorkFlowStep.B.ToString())
                {
                    await StepAService.StepA(_camundaBaseUrl, _processInstanceId, activityInstance);
                }
                if (activityInstance.Name == WorkFlowStep.C.ToString())
                {
                    await StepAService.StepA(_camundaBaseUrl, _processInstanceId, activityInstance);
                }
                if (activityInstance.Name == WorkFlowStep.D.ToString())
                {
                    await StepAService.StepA(_camundaBaseUrl, _processInstanceId, activityInstance);
                }
            }
        }


        private void SetButtonEnable(WorkFlowStep btn)
        {
            BtnStepA.Enabled = false;
            BtnStepB.Enabled = false;
            BtnStepC.Enabled = false;
            BtnStepD.Enabled = false;
            switch (btn)
            {
                case WorkFlowStep.A:
                    BtnStepA.Enabled = true;

                    break;
                case WorkFlowStep.B:
                    BtnStepB.Enabled = true;

                    break;
                case WorkFlowStep.C:
                    BtnStepC.Enabled = true;

                    break;
                case WorkFlowStep.D:
                    BtnStepD.Enabled = true;

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(btn), btn, null);
            }
        }
    }
}
