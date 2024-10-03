using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {

        public void CerrarSubasta() { }

        public void FinalizarVenta() { }

        public override string ToString() 
        {
            return $"-------------------------------\n" +
                $"Nombre del administrador: {Nombre}\n" +
                $"Apellido del administrador: {Apellido}\n" +
                $"Email del administrador: {Email}.\n" +
                $"-------------------------------"
        }
    }
}
