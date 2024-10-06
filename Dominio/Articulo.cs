namespace Dominio
{
    public class Articulo
    {


        private int _id;
        private static int _ultimoId;
        private string _nombre;
        private string _categoria;
        private float _precio;


        public int Id
        {
            get { return _id; }
        }

        public int UltimoId
        {
            get { return _ultimoId; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public Articulo()
        {
        }

        public Articulo(string nombre, string categoria, float precio)
        {
            _ultimoId++;
            _id = UltimoId;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }


        public void ValidarArticulo(string nombreArticulo, string categoriaArticulo, string precioArticulo)
        {
            ValidarNombre(nombreArticulo);
            ValidarCategoria(categoriaArticulo);
            ValidarPrecio(precioArticulo);
        }

        private static void ValidarNombre(string nombreArticulo)
        {
            if (nombreArticulo.Length < 5)
            {
                throw new Exception("Verifique que el nombre del artículo tenga por lo menos 5 caracteres.");
            }
        }

        private static void ValidarCategoria(string categoriaArticulo)
        {
            if (categoriaArticulo.Length < 5)
            {
                throw new Exception("Verifique que la categoría tenga un largo de por lo menos 5 caracteres.");
            }
        }

        private static void ValidarPrecio(string precioArticulo)
        {
            try
            {
                if (int.Parse(precioArticulo) <= 0) 
                {
                    throw new Exception("Verifique que el valor ingresado sea mayor a 0."); 
                }
            }
            catch (FormatException ex) 
            {
                throw new Exception("Verifique que el valor ingresado sea un número.", ex); 
            }
        }

        public void ActualizarPrecio(float nuevoPrecio)
        {
            Precio = nuevoPrecio;
        }

        public static void AgregarArticulo(string nombre, string categoria, float precio)
        {
            Articulo unArticulo = new Articulo(nombre, categoria, precio);
            Sistema.listaArticulos.Add(unArticulo);
        }


        public override string ToString()
        {
            return
                "------------------------------------\n" +
                $"Nombre del artículo: {Nombre}.\n" +
                $"Categoría: {Categoria}.\n" +
                $"Precio: {Precio}.\n" +
                "------------------------------------"
                ;
        }

    }

}