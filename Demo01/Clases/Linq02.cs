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
                Age = 17,
                IdStandard = 1
            },
            new Student()
            {
                Id = 124,
                Name = "Juan",
                Age = 34,
                IdStandard = 2
            },
            new Student()
            {
                Id = 125,
                Name = "Felipe",
                Age = 51,
                IdStandard = 3
            }
        };

        List<Standard> StandardList = new List<Standard>()
        {
            new Standard(){ Id = 1, StandardName = "Standard1"},
            new Standard(){ Id = 2, StandardName = "Standard2"},
            new Standard(){ Id = 3, StandardName = "Standard3"}
        };


        public void FuncJoin()
        {
            var innerJoin = _student.Join(
                StandardList,
                student => student.IdStandard,
                standard => standard.Id,
                (student, standard) =>  new 
                {
                    Name=student.Name,
                    StandardName = standard.StandardName
                }).ToList();
                innerJoin.ForEach(e => Console.WriteLine($"Student name: {e.Name} - StandardName: {e.StandardName}"));
/*                 foreach (var item in innerJoin)
                {
                    Console.WriteLine($"NameStudent: {item.Name} - NameStandard: {item.StandardName}");
                } */
        }
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
                                x.Id,x.Name
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
        public void FilterData()
        {
            var filterResult = _student.Where((s, i) => {
                if (i % 2 == 0)
                    return true;
                return false;
            }).ToList();
            filterResult.ForEach(a => Console.WriteLine(a.Name));
/* 
            foreach (var std in filterResult)
                Console.WriteLine(std.Name); */
        }

        public void AgeAscendent()
        {
            var orderResult = from s in _student
                              orderby s.Age
                              select s;

            foreach (var item in orderResult)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void AgeDescendent()
        {
            var orderResult = from s in _student
                              orderby s.Age descending
                              select s;

            foreach (var item in orderResult)
            {
                Console.WriteLine(item.Name);
            }
        }
        public List<Student> Order(string letter)
        {
            List<Student> result;
            switch (letter)
            {
                case "A":
                    result = _student.OrderBy(s => s.Name).ToList();
                    break;
                case "B":  
                    result = _student.OrderByDescending(s => s.Name).ToList();
                    break;
                default:
                    Console.WriteLine("No se especifico tipo de ordenamiento valido");
                    return result = new List<Student>();
            }
            return result;
        }
    }
}