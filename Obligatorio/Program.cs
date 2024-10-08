using Dominio;


namespace Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();
            sistema.PrecargaDeDatos();


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
                    Validaciones.ValidarNumericoEntero(seleccion);

                    switch (seleccion)
                    {
                        case "0":
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Presione cualquier tecla para mostrar el listado de clientes.");
                            Console.ReadLine();

                            foreach (Cliente cliente in sistema.ListarClientes())
                            {
                                Console.WriteLine(cliente.ToString()); 
                            }


                            Console.WriteLine("Presione cualquier tecla para volver, 0 para salir del programa.");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Indique la categoría...");
                            string categoriaSelected = Console.ReadLine();
                            int counterCase2 = 1;
                            foreach (Articulo art in sistema.FiltrarArticulos(categoriaSelected))
                            {
                                Console.WriteLine("Articulo numero: " + counterCase2++);
                                Console.WriteLine(art.ToString());
                            }

                            Console.WriteLine("Presione cualquier tecla para volver, 0 para salir del programa.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("--------------------------\n" +
                                               "FORMATO DE FECHA:\n" +
                                               "MM/dd/yyyy\n" +
                                               "--------------------------");


                            Console.WriteLine("Indique desde que fecha quiere buscar..");
                            string dateStart = Console.ReadLine();

                            Console.WriteLine("Indique hasta que fecha quiere buscar..");
                            string dateFinish = Console.ReadLine();
                            int counterCase3 = 1;
                            Validaciones.ValidarFecha(dateStart);
                            Validaciones.ValidarFecha(dateFinish);
                            List<Publicacion> publicacionesFinded = sistema.ListarPublicaciones(dateStart, dateFinish);

                            if (publicacionesFinded.Count == 0)
                            {
                                Console.WriteLine("No se encontraron publicaciones en el rango de fechas especificado.");
                            }
                            else
                            {
                                Console.Clear();
                                foreach (Publicacion art in publicacionesFinded)
                                {
                                    Console.WriteLine("Publicacion numero: " + counterCase3++);
                                    Console.WriteLine("----------------------------------------");
                                    Console.WriteLine(art.ToString());
                                    Console.WriteLine("----------------------------------------");
                                }
                            }

                            Console.WriteLine("Presione cualquier tecla para volver, 0 para salir del programa.");
                            Console.ReadLine();
                            Console.Clear();


                            break;


                        case "4":
                            Console.Clear();
                            string nombreArticulo;
                            string categoriaArticulo;
                            float precioArticulo;
                            try
                            {
                                Console.WriteLine("Ingrese el nombre del artículo: ");
                                nombreArticulo = Console.ReadLine();

                                Console.WriteLine("Ingrese la categoría del artículo: ");
                                categoriaArticulo = Console.ReadLine();

                                Console.WriteLine("Ingrese el precio del artículo: ");
                                precioArticulo = float.Parse(Console.ReadLine()); 

                                Articulo unArticulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo);
                                sistema.AgregarArticulo(unArticulo); 


                                Console.WriteLine("Producto agregado con éxito. Presione cualquier tecla para continuar o 0 para salir del programa.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }


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

