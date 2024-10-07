namespace Consola
{
    public  class Validaciones
    {
        public static void ValidarNumericoEntero(string valor)
        {
            try
            {

                if (int.Parse(valor) < 0)
                {
                    throw new Exception("Verifique que el valor numérico ingresado sea positivo.");
                }
            }
            catch (FormatException ex)
            {
                throw new Exception("Verifique que el valor ingresado sea numérico.", ex); 
            }
        }

        public static void ValidarFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
            }
            catch (FormatException ex)
            {
                throw new Exception("Verifique que el valor ingresado sea una fecha.", ex);
            }
        }

    }


}
