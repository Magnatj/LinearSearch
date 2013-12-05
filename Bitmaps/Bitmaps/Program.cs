using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el valor a buscar en nuestro arreglo de datos");
            try
            {
                byte input = byte.Parse(Console.ReadLine());
                string mira = Convert.ToString(input, 2).PadLeft(8, '0');
                byte[] losBytes = new byte[15]
                {
                    10,3,2,3,6,8,3,6,5,1,2,5,7,9,10
                };
                string[] elBitmap = losBytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
                bool igualito = false;

                int counter = 0;
                foreach (string elementos in elBitmap)
                {
                    if (elementos.ToString() == mira.ToString())
                    {
                        igualito = true;
                    }

                    else
                    {
                        igualito = false;
                    }

                    if (igualito)
                    {
                        Console.WriteLine("Se encontro el numero " + input + " en la posicion " + counter);
                    }
                    counter++;
                }
                Console.Read();
            }

            catch
            {
                Console.WriteLine("Why u trollin?");
                Console.Read();
            }
        }
    }
}
