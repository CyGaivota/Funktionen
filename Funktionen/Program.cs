using System.ComponentModel.Design;

namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                string s = ReadSelection();
                if (s == "e");

                { 
                    Console.WriteLine("Programm wird beendet");
                    break;
                }
                int a = ReadInt();
                int b = ReadInt();
                switch (s)
                {
                    case "ggT":
                        int ggT = MyMath.Calc_ggT(a, b);
                        ShowResult(s, a, b, ggT);
                        break;

                    case "kgV":
                        int kgV = MyMath.Calc_ggT(a, b);
                        ShowResult(s, a, b, kgV);
                        break;

                    case "ggTr":
                        int ggTr = MyMath.Calc_ggTr(a, b);
                        ShowResult(s, a, b, ggTr);
                        break;
                }
                
            }
            static int ReadInt()
            {
              
                {
                    int x;
                    do
                    {
                        Console.WriteLine("Gib eine Zahl ein");

                        string s = Console.ReadLine();
                        int.TryParse(s, out x);

                    } while (x <= 0);

                    Console.WriteLine("Danke");
                    return x;

                }
            }

            static void ShowResult(string operation, int a, int b, int result)
            {
                Console.WriteLine(operation + $" von {a} und {b} ist {result}");

            }

        }
        static void ShowMenu()
        {
            Console.WriteLine("Bitte Operation eingeben");
            Console.WriteLine("\t ggT für gemeinsamer Teiler");
            Console.WriteLine("\t ggTr für rekursiven gemeinsamen Teiler");
            Console.WriteLine("\t kgV für gemeinsames Vielfaches");
            Console.WriteLine("\t e für Ende");


        }

        static string ReadSelection()
        {
            string s;
            do
            {
                s = Console.ReadLine();
            } while (s != "ggT" && s != "kgV" && s != "e" && s != "ggTr");

            Console.WriteLine("Danke");
            return s;

        }
    }

}   

