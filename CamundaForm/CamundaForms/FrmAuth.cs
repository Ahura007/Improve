using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using CamundaForm.CamundaApi.Auth;
using CamundaForm.CamundaModel;
using Newtonsoft.Json;

namespace CamundaForm.CamundaForms;

public partial class FrmAuth : Form
{
    private readonly string _camundaBaseUrl;

    public FrmAuth(string camundaBaseUrl)
    {
        _camundaBaseUrl = camundaBaseUrl;
        InitializeComponent();
    }

    private async void BtnAuthPost_Click(object sender, EventArgs e)
    {
        await PostService.GenerateToken(_camundaBaseUrl);
    }

    private async void BtnGetToken_Click(object sender, EventArgs e)
    {
        var result = await CamundaForm.CamundaApi.Auth.GetService.GetToken(_camundaBaseUrl);
        var re = new FrmResult(result);
        re.ShowDialog();
    }
}