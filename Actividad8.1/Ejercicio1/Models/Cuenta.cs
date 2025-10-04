namespace Ejercicio1.Models
{

    public class Cuenta : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public double Importe { get; set; }

        public Cuenta(int dni, string nombre, double importe)
        {
            this.DNI = dni;
            this.Nombre = nombre;
            this.Importe = importe;
        }

        override public string ToString()
        {
            return $"{ Nombre} ({ DNI})  { Importe: f2}";
        }

        public int CompareTo(object otherObject)
        {
            Cuenta other = otherObject as Cuenta;
            if (other != null)
                return this.DNI.CompareTo(other.DNI);
            return -1;
        }
    }
}
