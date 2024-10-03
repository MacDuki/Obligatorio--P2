namespace Dominio
{
    public class Cliente : Usuario
    {
        private float _saldoDisponible;


        public float SaldoCliente
        {
            get { return _saldoDisponible; }
        }

        public Cliente() { }

        public Cliente(float saldoCliente)
        {
            _saldoDisponible = saldoCliente;
        }

        public void RealizarOfertaSubasta() { }

        public void RealizarCompra() { }

        public override string ToString() 
        {
            return $"--------------------------------\n" +
                $"Nombre del cliente: {Nombre}\n" +
                $"Apellido del cliente: {Apellido}\n" +
                $"Email del cliente: {Email}\n" +
                $"Saldo disponible: {SaldoCliente}.\n" +
                $"----------------------------------";
        }
    }
}
