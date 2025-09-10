namespace pryBazanContacto
{
    public partial class frmRegistroContacto : Form
    {
        public frmRegistroContacto()
        {
            InitializeComponent();
        }

        //Variables globales
        string vContacto = "";
        string vTelefono = "";
        int vContador = 0;
        //Declaracion de vectores
        string[] vecContacto = new string[5];
        string[] vecTelefono = new string[5];
        int indice = 0;



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "") ;
            btnGrabar.Enabled = true;
            vContador++;
            vContacto = txtContacto.Text;
            vTelefono = txtTelefono.Text;
            string vResultado = vContador + " - " + vContacto + " - " + vTelefono;
            lstResultado.Items.Add(vResultado);

            //Declaracion de vectores
            vecContacto[indice] = vContacto;
            vecTelefono[indice] = vTelefono;

            indice++;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistroContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
