using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaPOO
{
    public class Inventario
    {
        // Atributos
        private List<Medicamento> inventarioMedicamentos;

        // Constructores
        public Inventario(List<Medicamento> inventarioMedicamentos)
        {
            this.InventarioMedicamentos = inventarioMedicamentos;
        }

        public Inventario() { }

        // Get y Set
        public List<Medicamento> InventarioMedicamentos { get => inventarioMedicamentos; set => inventarioMedicamentos = value; }


        // Metodos
        public List<Medicamento> cargarInventario()
        {
            {
                StreamReader reader = new
                StreamReader("medicamentos.csv");

                string linea = reader.ReadLine();
                while (linea != null)
                {
                    string[] parts = linea.Split(',');
                    InventarioMedicamentos.Add(new Medicamento(int.Parse(parts[0]), parts[1], parts[2], parts[3],
                    float.Parse(parts[4]), int.Parse(parts[5])));
                    linea = reader.ReadLine();
                }
                reader.Close();

                return InventarioMedicamentos;
            }
        }

        public void guardarInventario()
        {
            // se crea un arreglo vacío de strings
            string[] lineas = new string[InventarioMedicamentos.Count];


            //ciclo para convertir todos datos de los objetos en string separa por comas

            for (int i = 0; i < InventarioMedicamentos.Count; i++)
            {
                lineas[i] =

                string.Join(",",
                InventarioMedicamentos[i].CodigoMedicamento, InventarioMedicamentos[i].NombreMedicamento,
                InventarioMedicamentos[i].Concentracion, InventarioMedicamentos[i].FormaPresentacion,
                InventarioMedicamentos[i].Precio, InventarioMedicamentos[i].CantidadExistencia);

            }
            File.Delete("medicamentos.csv");
            File.WriteAllLines("medicamentos.csv", lineas);
        }

        public List<Medicamento> mostrarInventario()
        {
            return this.InventarioMedicamentos;
        }
    }
}