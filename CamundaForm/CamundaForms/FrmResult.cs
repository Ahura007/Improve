namespace CamundaForm.CamundaForms
{
    public partial class FrmResult : Form
    {

        public FrmResult(List<string> list)
        {
            InitializeComponent();
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
