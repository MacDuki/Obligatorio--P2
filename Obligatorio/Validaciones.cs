namespace Consola
{
    public  class Validaciones
    {
        public void ValidarNumericoEntero(string valor)
        {
            try
            {
                int.Parse(valor);
                int valorParseado = int.Parse(valor); 

                if (valorParseado < 0)
                {
                    throw new Exception("Verifique que el valor ingresado sea un numérico positivo.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El valor ingresado no es numérico."); 
            }
        }


    }


}
