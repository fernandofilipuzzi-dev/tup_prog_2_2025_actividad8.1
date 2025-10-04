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

            //cuentas.Add(nuevo);

            //agregando lo propio para cumplir el punto 7

            cuentas.Sort();
            int idx = cuentas.BinarySearch(nuevo);
            if (idx >= 0)
            {
                //actualizo el registro
                cuentas[idx].Nombre = nuevo.Nombre;
                cuentas[idx].Importe += nuevo.Importe;  //acumulo 
            }
            else
            {
                cuentas.Add(nuevo);
            }

            btnActualizar.PerformClick(); //llama al evento onclick del botón Actualizar

            //fin de la modificación

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lsbVer.Items.Clear();
            foreach (Cuenta cuenta in cuentas)
            {
                lsbVer.Items.Add(cuenta);
            }

        }

        private void lsbVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta selectedCuenta = lsbVer.SelectedItem as Cuenta;

            if (selectedCuenta != null)
            {
                tbDNI.Text = selectedCuenta.DNI.ToString();
                tbNombre.Text = selectedCuenta.Nombre;
                tbImporte.Text = selectedCuenta.Importe.ToString("0.00");
            }

        }
    }
}
