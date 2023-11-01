using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01.Clases
{
    public class Linq02
    {
        List<Student> _student = new List<Student>(){
            new Student()
            {
                Id = 123,
                Name = "Pedro",
                Age = 14
            },
            new Student()
            {
                Id = 124,
                Name = "Juan",
                Age = 18
            },
            new Student()
            {
                Id = 125,
                Name = "Felipe",
                Age = 17
            }
        };

        public void PrintData()
        {
            var teenPerson = _student.Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
            teenPerson.ForEach(tp => Console.WriteLine($"{tp.Name}")); 
            // Imprime el nombre de el/los estudiante(s) con más de 12 años y menos de 20        
        }
    
        public void PrintDataByNameAndId()
        {
            var expresion = from x in _student 
                            select new{
                                x.Id,x.Name,x.Age
                            };

            foreach (var item in expresion)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
        }
        public void AnotherNameAndId()
        {
            var expresion = (from x in _student 
                            select (
                                x.Id,x.Name
                            )).ToList();
            expresion.ForEach(x => Console.WriteLine($"Nombre: {x.Name} - Id: {x.Id}"));
/*             foreach (var item in expresion)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            } */
        }
    }
}