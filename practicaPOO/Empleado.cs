using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPOO
{
    public class Empleado
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string telefono;
        private string experiencia;

        // Getters and Setters
        // Podría cambiarse el nombre, el telefono y/o aumentar su experiencia
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Experiencia { get => experiencia; set => experiencia = value; }

        // Constructor
        public Empleado(string nombre, string apellido, string telefono, string experiencia)
        {
            this.apellido = apellido;
            Nombre = nombre;
            Telefono = telefono;
            Experiencia = experiencia;
        }

        // Metodos
        public Medicamento buscarPorNombre(List<Medicamento> InventarioMedicamentos, string nombreMedicamento)
        {
            Medicamento medicamentoEncontrado = null;
            foreach (Medicamento medicamento in InventarioMedicamentos)
            {
                if (medicamento.NombreMedicamento == nombreMedicamento)
                {
                    medicamentoEncontrado = medicamento;
                    break;
                }
            }
            return medicamentoEncontrado;
        }

        public Medicamento buscarPorCodigo(List<Medicamento> InventarioMedicamentos, int codigoMedicamento, int opc)
        {
            Medicamento medicamentoEncontrado = null;
            foreach (Medicamento medicamento in InventarioMedicamentos)
            {
                if (medicamento.CodigoMedicamento == codigoMedicamento)
                {
                    medicamentoEncontrado = medicamento;
                    break;
                }
            }
            return medicamentoEncontrado;
        }

        public string realizarVenta(List<Medicamento> InventarioMedicamentos, string nombreMedicamento, int cantidad)
        {
            Medicamento medicamentoEncontrado = buscarPorNombre(InventarioMedicamentos, nombreMedicamento);
            if (medicamentoEncontrado.CantidadExistencia >= cantidad)
            {
                medicamentoEncontrado.CantidadExistencia = medicamentoEncontrado.CantidadExistencia - cantidad;
                return "Medicamento vendido y actualizado en el inventario";
            }
            else
            {
                return "Cantidad mayor a la existencia del inventario";
            }
        }
    }
}