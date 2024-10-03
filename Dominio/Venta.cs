namespace Dominio
{
    public class Venta
    {
        //NO DECLARO NI ULTIMO ID NI ID, PUESTO QUE LOS HEREDA DE LA CLASE PUBLICACIÓN. 

        public bool _esOfertaRelampago;
        public float _precioVenta;

        public bool EsOfertaRelampago
        {
            get { return _esOfertaRelampago; }
            set { _esOfertaRelampago = value; }
        }

        public float PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public Venta() { }

        public Venta(bool esOfertaRelampago, float precioVenta)
        {
            EsOfertaRelampago = esOfertaRelampago;
            PrecioVenta = precioVenta;
        }

        public float AplicarDescuento()
        {
            float  descuento = 0.20f;
            PrecioVenta*= (1- descuento);
            return PrecioVenta; 
        }
    }
}
