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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                while (sr.EndOfStream == false)
                {
                    #region parseo
                    string linea = sr.ReadLine();

                    string dni = linea.Substring(0, 9).Trim();
                    string nombre = linea.Substring(9, 10).Trim();
                    string importe = linea.Substring(19, 9).Trim();
                    #endregion

                    Cuenta nueva = new Cuenta(Convert.ToInt32(dni), nombre, Convert.ToDouble(importe));

                    cuentas.Add(nueva);

                    //usar el código del btnConfirmar para agregar a la lista o actualizar según caso
                }
                sr.Close();
                fs.Close();
            }

            btnActualizar.PerformClick();

        }
    }
}
