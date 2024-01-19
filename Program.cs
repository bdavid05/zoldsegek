using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Hány ágyást szeretnél? ");
        if (int.TryParse(Console.ReadLine(), out int numberOfRectangles))
        {
            for (int i = 0; i < numberOfRectangles; i++)
            {
                DrawRectangleWithX();
            }
        }
        else
        {
            Console.WriteLine("Érvénytelen számot adtál meg.");
        }
        Console.WriteLine("Nyomj egy billentyűt a kilépéshez...");
        Console.ReadKey();
    }

    static void DrawRectangleWithX()
    {
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XX                            XX");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine();
    }
}
