namespace Dominio;
public class Sistema
{
    public  List<Administrador> listaAdministradores = new List<Administrador>();
    public  List<Cliente> listaClientes = new List<Cliente>();
    public  List<Articulo> listaArticulos = new List<Articulo>();
    public  List<Publicacion> listaPublicaciones = new List<Publicacion>();

    // PRECARGA DE DATOS.
    public void PrecargarClientes()
    {
        listaClientes.AddRange(new List<Cliente>
        {
            new Cliente("Pedro", "García", "pedro.garcia@email.com", "pass1234", 1500.75m),
            new Cliente("Laura", "López", "laura.lopez@email.com", "laura2021", 3200.50m),
            new Cliente("Juan", "Martínez", "juan.martinez@email.com", "jm2345", 500.00m),
            new Cliente("Ana", "Fernández", "ana.fernandez@email.com", "anafern", 1000.00m),
            new Cliente("Luis", "Sánchez", "luis.sanchez@email.com", "luis2022", 2200.30m),
            new Cliente("María", "González", "maria.gonzalez@email.com", "mgonzalez", 1800.80m),
            new Cliente("Carlos", "Pérez", "carlos.perez@email.com", "carlitos", 2750.10m),
            new Cliente("Elena", "Díaz", "elena.diaz@email.com", "elenadiaz", 1250.75m),
            new Cliente("Javier", "Molina", "javier.molina@email.com", "javimolina", 3500.00m),
            new Cliente("Carmen", "Ruiz", "carmen.ruiz@email.com", "carmen123", 950.50m)
        });
    }
    public void PrecargarArticulos()
    {
        listaArticulos.AddRange(new List<Articulo>
        {
            new Articulo("Teclado Mecanico", "Electronica", 79.99f),
            new Articulo("Mouse Gamer", "Electronica", 49.99f),
            new Articulo("Monitor 24 pulgadas", "Electronica", 159.99f),
            new Articulo("Silla ergonomica", "Mobiliario", 299.99f),
            new Articulo("Escritorio", "Mobiliario", 199.99f),
            new Articulo("Auriculares Bluetooth", "Electronica", 89.99f),
            new Articulo("Laptop", "Electronica", 1200.00f),
            new Articulo("Smartphone", "Electronica", 699.99f),
            new Articulo("Tablet", "Electronica", 499.99f),
            new Articulo("Lampara de escritorio", "Mobiliario", 39.99f),
            new Articulo("Impresora", "Electronica", 150.00f),
            new Articulo("Router Wi-Fi", "Electronica", 59.99f),
            new Articulo("Disco duro externo", "Electronica", 89.99f),
            new Articulo("Memoria USB", "Electronica", 19.99f),
            new Articulo("Camara Web", "Electronica", 79.99f),
            new Articulo("Microfono", "Electronica", 49.99f),
            new Articulo("Cargador portatil", "Accesorios", 25.99f),
            new Articulo("Ventilador de escritorio", "Mobiliario", 45.99f),
            new Articulo("Cafetera", "Electrodomesticos", 99.99f),
            new Articulo("Cargador inalambrico", "Electronica", 29.99f),
            new Articulo("Smartwatch", "Electronica", 199.99f),
            new Articulo("Bateria externa", "Accesorios", 49.99f),
            new Articulo("Altavoces Bluetooth", "Electronica", 129.99f),
            new Articulo("Reloj de pared", "Mobiliario", 19.99f),
            new Articulo("Taza termica", "Accesorios", 15.99f),
            new Articulo("Libreta de notas", "Papeleria", 9.99f),
            new Articulo("Boligrafo", "Papeleria", 1.99f),
            new Articulo("Mousepad", "Accesorios", 12.99f),
            new Articulo("Camara de seguridad", "Electronica", 99.99f),
            new Articulo("Enrutador", "Electronica", 79.99f),
            new Articulo("Proyector", "Electronica", 259.99f),
            new Articulo("Parlante portatil", "Electronica", 89.99f),
            new Articulo("Linterna LED", "Accesorios", 19.99f),
            new Articulo("Ventilador de techo", "Mobiliario", 150.00f),
            new Articulo("Refrigerador", "Electrodomesticos", 799.99f),
            new Articulo("Licuadora", "Electrodomesticos", 49.99f),
            new Articulo("Aspiradora", "Electrodomesticos", 199.99f),
            new Articulo("Plancha", "Electrodomesticos", 35.99f),
            new Articulo("Planchita de cabello", "Electrodomesticos", 29.99f),
            new Articulo("Estuche de celular", "Accesorios", 9.99f),
            new Articulo("Protector de pantalla", "Accesorios", 4.99f),
            new Articulo("Cuchillo de chef", "Cocina", 24.99f),
            new Articulo("Juego de ollas", "Cocina", 129.99f),
            new Articulo("Tostadora", "Electrodomesticos", 29.99f),
            new Articulo("Parrilla electrica", "Electrodomesticos", 69.99f),
            new Articulo("Termo", "Accesorios", 19.99f),
            new Articulo("Botella de agua", "Accesorios", 15.99f),
            new Articulo("Audifonos deportivos", "Accesorios", 29.99f),
            new Articulo("Bicicleta", "Deportes", 499.99f)

        });
    }
    public void PrecargarAdministradores()
    {
        listaAdministradores.AddRange(new List<Administrador>
        {
            new Administrador("Carlos", "Ramírez", "carlos.ramirez@email.com", "admin1234"),
            new Administrador("Lucía", "Castro", "lucia.castro@email.com", "admin5678")
        });
    }
    public void PrecargarPublicaciones()
    {
        listaPublicaciones.AddRange(new List<Publicacion>
        {
            new Venta("Venta de Teclados", "venta", true, 69.99f),
            new Venta("Venta de Laptops", "venta", false, 1199.99f),
            new Venta("Venta de Sillas", "venta", false, 249.99f),
            new Venta("Venta de Monitores", "venta", true, 149.99f),
            new Venta("Venta de Smartphones", "venta", false, 699.99f),
            new Venta("Venta de Auriculares", "venta", true, 79.99f),
            new Venta("Venta de Impresoras", "venta", false, 129.99f),
            new Venta("Venta de Cafeteras", "venta", true, 99.99f),
            new Venta("Venta de Ventiladores", "venta", false, 45.99f),
            new Venta("Venta de Licuadoras", "venta", true, 49.99f),
            new Subasta("Subasta de Auriculares", "subasta", 50.00f),
            new Subasta("Subasta de Teclados", "subasta", 30.00f),
            new Subasta("Subasta de Sillas Ergonómicas", "subasta", 80.00f),
            new Subasta("Subasta de Monitores", "subasta", 100.00f),
            new Subasta("Subasta de Laptops", "subasta", 600.00f),
            new Subasta("Subasta de Smartphones", "subasta", 300.00f),
            new Subasta("Subasta de Impresoras", "subasta", 70.00f),
            new Subasta("Subasta de Cafeteras", "subasta", 40.00f),
            new Subasta("Subasta de Ventiladores", "subasta", 20.00f),
            new Subasta("Subasta de Licuadoras", "subasta", 25.00f),
        });
        
    }
    public Sistema() { }


    public void ListarClientes() 
    {
        //VERIFICA QUE HAYA POR LO MENOS UN CLIENTE REGISTRADO PARA MOSTRAR LA LISTA. 
        if (listaClientes.Count > 0)
        {
            foreach (Cliente unCliente in listaClientes)
            {
                Console.WriteLine(unCliente.ToString());
            } 
        }
        else 
        {
            throw new Exception("No se encuentran clientes agregados."); 
        }
        
    }

    public List <Articulo> filtrarArticulos (string categoriaSelected)
    {
       List <Articulo> articulosFinded = new List <Articulo>();
        foreach (Articulo art in listaArticulos)
        {
            if (string.Equals(art.Categoria, categoriaSelected, StringComparison.OrdinalIgnoreCase))

            {
                articulosFinded.Add(art);
            }
        }
        return articulosFinded;
    }

}
