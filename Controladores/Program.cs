namespace cuadrado;

using cuadrado.Servicios;


/// <summary>
/// Clase principal del programa
/// 241023 - chi 
/// </summary>
class Program
{
    /// <summary>
    /// Main nuestro programa
    /// 241023 - chi 
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        MenuInterfaz num = new MenuImplementacion(); // creo un objeto del método del menú interfaz

        int numero1 = num.numero(); //igualo el objeto al int numero creado en el menu implementación.
        int numero2 = num.numero();
         
        Console.WriteLine(numero1 * numero1 == numero2); //Imprimo por pantalla la operación pedida.


    }
}

