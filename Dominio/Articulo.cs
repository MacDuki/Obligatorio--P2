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

        public void ActualizarPrecio(float nuevoPrecio)
        {
            Precio = nuevoPrecio; 
        }


        public override string ToString()
        {
            return $"Nombre del artículo: {Nombre}.\n" +
                $"Categoría: {Categoria}.\n" +
                $"Precio: {Precio}. ";
        }

    }
}
