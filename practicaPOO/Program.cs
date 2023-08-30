using practicaPOO;
public class Program
{
    static void Main(String[] args)
    {
        List<Medicamento> inventarioMedicamentos = new List<Medicamento>();
        Inventario inventario = new Inventario(inventarioMedicamentos);
        inventario.cargarInventario();
        Empleado empleado = new Empleado("Daniel", "Villegas", "3017547116", "3 años");
        
        Console.WriteLine("**********************************");
        Console.WriteLine("*SISTEMA DE VENTA DE MEDICAMENTOS*");
        Console.WriteLine("**********************************");
        int opc;
        do
        {
            Console.WriteLine("Seleccione una opción.");
            Console.WriteLine("1. Mostrar información\n2. Buscar medicamento por nombre\n3. Buscar medicamento por código\n4. Realizar venta de medicamento\n5. Guardar inventario\n0. Salir");
            opc = int.Parse(Console.ReadLine());
            List<Medicamento> listaMedicamentos = inventario.InventarioMedicamentos;

            switch (opc)
            {
                case 1:
                    Console.WriteLine("***************************************");
                    foreach (Medicamento medicamento in listaMedicamentos)
                    {
                        Console.WriteLine("Nombre: " + medicamento.NombreMedicamento + "\nCodigo medicamento: " + medicamento.CodigoMedicamento + "\nConcentracion: " + medicamento.Concentracion + "\nForma presentacion: " + medicamento.FormaPresentacion + "\nPrecio: " + medicamento.Precio + "\nCantidad en existencia: " + medicamento.CantidadExistencia);
                        Console.WriteLine("---------------------------------------------------------");
                    }
                    break;
                case 2:
                    Medicamento medicamentoEncontrado = null;
                    Console.WriteLine("Ingrese el nombre del medicamento que desea buscar");
                    String nombreMedicamento = Console.ReadLine();
                    medicamentoEncontrado = empleado.buscarPorNombre(listaMedicamentos, nombreMedicamento);
                    Console.WriteLine("Medicamento encontrado: " + medicamentoEncontrado.NombreMedicamento);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 0:
                    break;
            }
        } while (opc != 0);
    }
}