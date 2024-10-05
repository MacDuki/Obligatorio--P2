namespace Dominio
{
    public class Cliente : Usuario
    {
        private decimal _saldoDisponible;


        public decimal SaldoDisponible
        {
            get { return _saldoDisponible; }
        }

        public Cliente() { }

        public Cliente(string nombre, string apellido, string email, string contrasenia, decimal saldoCliente) : base(nombre, apellido, email, contrasenia)
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
                $"Saldo disponible: {SaldoDisponible}.\n" +
                $"----------------------------------";
        }

        public void ValidarCliente() 
        {
            ValidarLargo(); 
            ValidarSaldo(); 
        }

        private void ValidarSaldo() 
        {
            if (SaldoDisponible < 0) 
            {
                throw new Exception("Verifique que el SALDO ingresado sea superior a 0."); 
            }
        }

        //MÉTODO PARA VALIDAR QUE UNA CADENA DE CARACTERES CUMPLA CON EL MÍNIMO DE 5.
        private void ValidarLargo()
        {
            if (Nombre.Length < 5) 
            {
                throw new Exception("El largo del NOMBRE del cliente debe contar con un mínimo de 5 caracteres."); 
            }
            if (Apellido.Length < 5) 
            {
                throw new Exception("El largo del APELLIDO del cliente debe contar con al menos 5 caracteres."); 
            }
            if (Email.Length < 5) 
            {
                throw new Exception("El largo del EMAIL del cliente no puede ser inferior al mínimo de 5 caracteres.");
            }
            if (Contrasenia.Length < 5) 
            {
                throw new Exception("El largo de la CONTRASEÑA del cliente no puede ser inferior a 5 caracteres."); 
            }
        }

 
    }
}
