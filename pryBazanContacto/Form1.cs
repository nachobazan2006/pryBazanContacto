namespace pryBazanContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string vContacto= "";
        string vTelefono= "";
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add(vContacto + " - " + vTelefono);
        }
    }
}
