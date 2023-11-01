using Demo01.Clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Linq01 demoLinq01 = new Linq01();
        Linq02 demoLinq02 = new Linq02();
        /* demoLinq01.PrintData(); */
        /* demoLinq01.PrintQuery(); */

        /* demoLinq02.PrintData(); */
        /* demoLinq02.PrintDataByNameAndId(); */
        /* demoLinq02.AnotherNameAndId(); */
        /* demoLinq02.FilterData(); */
        /* demoLinq02.AgeAscendent();
        demoLinq02.AgeDescendent(); */

        demoLinq02.FuncJoin();

/*         string letter;
        Console.WriteLine("Ingrese la letra del tipo de ordenamiento que quiere\nA -> Ascendente\nB -> Descendente");
        letter = Console.ReadLine();
        var list = demoLinq02.Order(letter.ToUpper());
        foreach (var item in list)
        {
            Console.WriteLine($"{item.Name}");
        } */

        
    }
}