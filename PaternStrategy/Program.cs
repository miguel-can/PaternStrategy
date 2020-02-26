using PaternStrategy.Bussines.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            string cNombre = string.Empty, cRespuesta = string.Empty;
            int iOpcion = 0;
            GuardadoFormatoStrategy svrGuardadoStrategy = new GuardadoFormatoStrategy();

            Console.WriteLine("**** Sistema de almacenamiento de Imagenes *****");
            Console.WriteLine("Proporcione el nombre de la Imagen");
            cNombre = Console.ReadLine();
            
            Console.WriteLine("Proporcione el NÚMERO que corresponde al formato que desee:");
            Console.WriteLine("PNG: 1");
            Console.WriteLine("JPEG: 2");
            Console.WriteLine("BMP: 3");
            Console.WriteLine("GIF: 4");

            int.TryParse(Console.ReadLine(), out iOpcion);

            switch (iOpcion)
            {
                case 1:
                    svrGuardadoStrategy.SetStrategy(new GuardadoFormatoPNG());
                    break;
                case 2:
                    svrGuardadoStrategy.SetStrategy(new GuardadoFormatoJPEG());
                    break;
                case 3:
                    svrGuardadoStrategy.SetStrategy(new GuardadoFormatoBMP());
                    break;
                case 4:
                    svrGuardadoStrategy.SetStrategy(new GuardadoFormatoGIF());
                    break;
                default:
                    Console.WriteLine("Indique un Formato correcto");
                    break;
            }

            if (iOpcion >= 1 && iOpcion <= 4)
            {
                cRespuesta = svrGuardadoStrategy.GuardaFormato(cNombre);
                Console.WriteLine(cRespuesta);
            }

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();
        }
    }
}
