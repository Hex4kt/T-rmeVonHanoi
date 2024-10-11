using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TürmeVonHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lösungsalgorithmus für die Türme von Hanoi\n" +
                               "Wie viele Spielsteine gibt es?");

            if (int.TryParse(Console.ReadLine(), out int spielsteine))
            {
                Console.WriteLine($"Die Lösung für {spielsteine} Spielsteine ist:");
                TürmeVerschieben(spielsteine, 'L', 'M', 'R');
            }

            Console.ReadLine();
        }

        static void TürmeVerschieben(int spielsteinZuVerschieben, char von, char über, char nach)
        {
            if (spielsteinZuVerschieben > 0)
            {
                TürmeVerschieben(spielsteinZuVerschieben - 1, von, nach, über);
                Console.WriteLine($"Schiebe {spielsteinZuVerschieben} von {von} nach {nach}");
                TürmeVerschieben(spielsteinZuVerschieben - 1, über, von, nach);
            }
        }
    }
}
