using Dominio;


namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();
            sistema.PrecargarClientes();
            sistema.PrecargarArticulos();
            sistema.PrecargarAdministradores();
            Validaciones validacion = new Validaciones(); 

            Console.WriteLine("¡Bienvenido al programa!\n");

            string seleccion = "-1";
            while (seleccion != "0")
            {
                Console.WriteLine("Seleccione una opción: \n" +
                    "-------------------------------------\n" +
                    "PRESIONE 1 PARA LISTAR LOS CLIENTES: \n" +
                    "--------------------------------------\n" +
                    "PRESIONE 2 PARA FILTRAR LOS ARTÍCULOS SEGÚN LA CATEGORÍA:\n" +
                    "--------------------------------------\n" +
                    "PRESIONE 3 PARA FILTRAR LAS PUBLICACIONES SEGÚN DOS FECHAS:\n" +
                    "--------------------------------------\n" +
                    "PRESIONE 4 PARA DAR DE ALTA UN ARTÍCULO:\n" +
                    "--------------------------------------\n" +
                    "PRESIONE 0 PARA SALIR.\n" +
                    "--------------------------------------");

                seleccion = (Console.ReadLine()); 
                try
                {
                    validacion.ValidarNumericoEntero(seleccion); 

                    switch (seleccion)
                    {
                        case "0":
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Presione cualquier tecla para mostrar el listado de clientes.");
                            Console.ReadLine();
                            sistema.ListarClientes();
                            Console.WriteLine("Presione cualquier tecla para volver, 0 para salir del programa.");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Indique la categoría...");
                            string categoriaSelected = Console.ReadLine();
                            int counterCase2 = 1;
                            foreach (Articulo art in sistema.filtrarArticulos(categoriaSelected))
                            {
                                Console.WriteLine("Articulo numero: " + counterCase2++);
                                Console.WriteLine(art.ToString()); 
                            }
                            break;

                            case "3":   

                                break;

                        default:
                            Console.WriteLine("No se encontró la opción seleccionada.");
                            break;
                    }

                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message); 
                }

               
            }
        }
    }

}

