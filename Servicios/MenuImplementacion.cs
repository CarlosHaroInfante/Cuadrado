using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuadrado.Servicios
{
    /// <summary>
    /// Menú implementación donde crearemos lo que hay dentro del método del menú interfaz
    /// 241023 - chi
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz //Conecto los Servicios
    {
        
        public int numero()
        {
            int numero; 
            Console.WriteLine("Elige un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }


    }
}
