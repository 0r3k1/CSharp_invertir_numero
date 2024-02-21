using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numero_alreves {
    class Program {
        static void Main(string[] args) {
            int num, count;
            string linea, aux = "";

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();

            count = linea.Length;

            for (int i = 0; i < count; i++) {
                num = int.Parse(linea) / int.Parse(Math.Pow(10, linea.Length - 1).ToString());
                linea = (int.Parse(linea) % int.Parse(Math.Pow(10, linea.Length - 1).ToString())).ToString();
                aux = num + aux;
            }

            Console.WriteLine(aux);
        }
    }
}
