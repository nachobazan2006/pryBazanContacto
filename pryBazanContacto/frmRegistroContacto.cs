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

            string contacto = txtContacto.Text;
            string telefono = txtTelefono.Text;

            
            if (string.IsNullOrWhiteSpace(contacto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Debe ingresar un contacto y un telefono");
                btnGrabar.Enabled = false;
                return;
            }

            // Verificar si el contacto ya existe en el vector (ignorando mayúsculas/minúsculas)
            for (int i = 0; i < vecContacto.Length; i++)
            {
                if (!string.IsNullOrEmpty(vecContacto[i]) && vecContacto[i] == contacto)
                {
                    MessageBox.Show("El contacto ya existe");
                    
                    return;
                }
            }

            // Verificar espacio en los vectores
            if (indice >= vecContacto.Length)
            {
                MessageBox.Show("No se pueden agregar más contactos (vector lleno)");
                btnGrabar.Enabled = false;
                return;
            }

            // Agregar nuevo contacto
            vContador++;
            vContacto = contacto;
            vTelefono = telefono;
            string vResultado = vContador + " - " + vContacto + " - " + vTelefono;
            lstResultado.Items.Add(vResultado);

            // Guardar en vectores
            vecContacto[indice] = vContacto;
            vecTelefono[indice] = vTelefono;
            indice++;

            btnGrabar.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistroContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
