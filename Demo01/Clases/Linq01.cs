using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Clases
{
    public class Linq01
    {
        List<string> libros = new List<string>(){
            "Vb.Net Tutorial",
            "C# Tutorial",
            "TypeScript e-book"
        };

        public IEnumerable<string> ListLibrosByNombre(string criterio)
        {
            return libros.Where(x => x.Contains(criterio));                     
        }

        public void PrintData()
        {
            Console.WriteLine("Ingrese el criterio de busqueda: ");

            string criterio = Console.ReadLine();

            IEnumerable<string> data = ListLibrosByNombre(criterio);

            Console.Clear();

            foreach (string item in data)
            {
                Console.WriteLine($"Se encontro : {item}");
            }
        }

        public void PrintQuery() 
        { 
            Console.WriteLine("Ingrese el criterio de busqueda: ");

            string criterio = Console.ReadLine();

            var expresion = (from x in libros 
                            where x.Contains(criterio)
                            select x).ToList<string>();

            /* expresion.ForEach(x => Console.WriteLine) */

            foreach (string item in expresion)
            {
                Console.WriteLine($"Se ecntro el libro {item}");
            }
        }
    }
}