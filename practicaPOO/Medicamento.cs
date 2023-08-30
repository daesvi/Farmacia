using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPOO
{
    public class Medicamento
    {
        // Atributos
        private int codigoMedicamento;
        private string nombreMedicamento;
        private string concentracion;
        private string formaPresentacion;
        private double precio;
        private int cantidadExistencia;

        // Getters and Setters
        public string Concentracion { get => concentracion; set => concentracion = value; }
        public string FormaPresentacion { get => formaPresentacion; set => formaPresentacion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int CantidadExistencia { get => cantidadExistencia; set => cantidadExistencia = value; }
        public int CodigoMedicamento { get => codigoMedicamento; set => codigoMedicamento = value; }
        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = value; }

        // Constructor
        public Medicamento(int codigoMedicamento, string nombreMedicamento, string concentracion, string formaPresentacion, double precio, int cantidadExistencia)
        {
            this.CodigoMedicamento = codigoMedicamento;
            this.NombreMedicamento = nombreMedicamento;
            Concentracion = concentracion;
            FormaPresentacion = formaPresentacion;
            Precio = precio;
            CantidadExistencia = cantidadExistencia;
        }
    }
}
