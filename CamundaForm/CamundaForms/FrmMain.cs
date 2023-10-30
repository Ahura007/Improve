using CamundaForm.CamundaApi.DeleteProcess;
using CamundaForm.CamundaApi.LoadProcess;
using CamundaForm.CamundaApi.StartInstance;
using CamundaForm.CamundaApi.WorkflowList;

namespace CamundaForm.CamundaForms;

public partial class FrmMain : Form
{
    private readonly string _camundaBaseUrl;
    private string processDefinitionId = string.Empty;
    private string processId = string.Empty;

    public FrmMain()
    {
        _camundaBaseUrl = "http://localhost:8080/engine-rest";
        InitializeComponent();
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        processId = string.Empty;
        processDefinitionId = string.Empty;
        listBox1.Items.Clear();
        LoadProcess();
    }

    private async void LoadProcess()
    {
        var workFlow = await GetAllProcess.Loader(_camundaBaseUrl);
        foreach (var item in workFlow) listBox1.Items.Add(item);
    }

    private async void BtnGetAllWorkFlow_Click(object sender, EventArgs e)
    {
        var result = await WorkFlowList.GetAllWorkflowList(_camundaBaseUrl);
        var dialog = new FrmResult(result);
        dialog.ShowDialog();
        RefreshGrid();
    }

    private void BtnAuth_Click(object sender, EventArgs e)
    {
        var auth = new FrmAuth(_camundaBaseUrl);
        auth.ShowDialog();
        RefreshGrid();
    }

    private async void BtnStartNewInstance_Click(object sender, EventArgs e)
    {
        Service.StartProcess(_camundaBaseUrl);
        RefreshGrid();
    }

    private void BtnNextStep_Click(object sender, EventArgs e)
    {
        CheckProcessId();
        var auth = new FrmNextStep(_camundaBaseUrl, processId);
        auth.ShowDialog();
        RefreshGrid();
    }


    private void CheckProcessId()
    {
        if (string.IsNullOrEmpty(processId))
            throw new Exception("پردازشی برای به جریان انداختن انتاخب نشده است ");
    }

    private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        SetVariable();
    }

    private void listBox1_MouseClick(object sender, MouseEventArgs e)
    {
        SetVariable();
    }

    private void SetVariable()
    {
        var data = listBox1.SelectedItem.ToString().Split("__*__");
        processId = data[0];
        processDefinitionId = data[1];
    }

    private async void BtnDelete_Click(object sender, EventArgs e)
    {
        CheckProcessId();
        Delete.DeleteProcess(_camundaBaseUrl, processDefinitionId);
        RefreshGrid();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        RefreshGrid();
    }
}