using CamundaForm.CamundaApi.ProcessWorkFlow;
using CamundaForm.CamundaModel;

namespace CamundaForm.CamundaForms
{
    public partial class FrmNextStep : Form
    {
        private readonly string _camundaBaseUrl;
        private readonly string _processInstanceId;
        private GetActivityInstanceResponse _processInfo = null;
        private GetActivityInstanceResponse _currentChildActivityInstances = null;

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

            _currentChildActivityInstances = _processInfo.ChildActivityInstances.OrderByDescending(c=>c.ActivityName).FirstOrDefault(c => c.ProcessInstanceId == Guid.Parse(_processInstanceId));

            if (_currentChildActivityInstances.Name == WorkFlowStep.A.ToString())
            {
                SetButtonEnable(WorkFlowStep.A);
            }
            else if (_currentChildActivityInstances.Name == WorkFlowStep.B.ToString())
            {
                SetButtonEnable(WorkFlowStep.B);
            }
            else if (_currentChildActivityInstances.Name == WorkFlowStep.C.ToString())
            {
                SetButtonEnable(WorkFlowStep.C);
            }
            else
            {
                SetButtonEnable(WorkFlowStep.D);
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

        private void BtnStepA_Click(object sender, EventArgs e)
        {
            WorkFlow();
        }

        private void BtnStepB_Click(object sender, EventArgs e)
        {
            WorkFlow();
        }

        private void BtnStepC_Click(object sender, EventArgs e)
        {
            WorkFlow();
        }

        private void BtnStepD_Click(object sender, EventArgs e)
        {
            WorkFlow();
        }

        private async void WorkFlow()
        {
            if (_currentChildActivityInstances.Name == WorkFlowStep.A.ToString())
            {
                await StepAService.StepA(_camundaBaseUrl, _processInstanceId, _currentChildActivityInstances);
            }
            else if (_currentChildActivityInstances.Name == WorkFlowStep.B.ToString())
            {
                await StepAService.StepA(_camundaBaseUrl, _processInstanceId, _currentChildActivityInstances);
            }
            else if (_currentChildActivityInstances.Name == WorkFlowStep.C.ToString())
            {
                await StepAService.StepA(_camundaBaseUrl, _processInstanceId, _currentChildActivityInstances);
            }
            else
            {
                await StepAService.StepA(_camundaBaseUrl, _processInstanceId, _currentChildActivityInstances);
            }
            this.Close();

        }
    }
}
