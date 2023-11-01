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
        demoLinq02.AnotherNameAndId();

        
    }
}