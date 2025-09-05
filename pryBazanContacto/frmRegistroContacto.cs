namespace pryBazanContacto
{
    public partial class frmRegistroContacto : Form
    {
        public frmRegistroContacto()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vTelefono = "";
        int    vContador = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContador++;
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;   
            string vResultado= vContador + " - " + vContacto + " - " + vTelefono;
            lstResultado.Items.Add(vResultado);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
