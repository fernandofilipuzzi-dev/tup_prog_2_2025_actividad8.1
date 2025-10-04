using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        List<Cuenta> cuentas = new List<Cuenta>();
        public FormPrincipal()
        {


            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            #region parseo
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);
            #endregion

            Cuenta nuevo = new Cuenta(dni, nombre, importe);
            cuentas.Add(nuevo);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbVer.Items.Add(cuenta);
            }

        }
    }
}
