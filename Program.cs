using System;

namespace day_planer
{
    class Program
    {
        static void Main(string[] args)
        {


            bool x = true;
            int[] idies = { };
            string[] titles = { };
            string[] events = { };
            Day_Elements day1 = new Day_Elements();
            day1.Id = 0;
            First();
            while (x == true)
            {


                Console.WriteLine("Podaj tytuł wydarzenia:");
                string a = Console.ReadLine();
                day1.Title = a;
                Console.WriteLine("Opisz Wydarzenie:");
                string b = Console.ReadLine();
                day1.Content = b;

                day1.Id++;


                Array.Resize(ref events, events.Length + 1);
                events[events.GetUpperBound(0)] = day1.Content;
                Array.Resize(ref idies, idies.Length + 1);
                idies[idies.GetUpperBound(0)] = day1.Id;
                Array.Resize(ref titles, titles.Length + 1);
                titles[titles.GetUpperBound(0)] = day1.Title;




                Console.WriteLine("wyświetl wydarzenia wpisz: K");
                Console.WriteLine("Jeśli chcesz zakończyć: E");
                Console.WriteLine("dodaj kolejne-naciśnij ENTER");
                String d = Console.ReadLine();
                if (d == "K")
                {

                    for (int z = 0; z < titles.Length; z++)
                    {
                        Console.WriteLine(idies[z]);
                        Console.WriteLine(titles[z]);
                        Console.WriteLine(events[z]);
                    }
                    Console.WriteLine("Jeśli chcesz zakończyć: E");
                    Console.WriteLine("dodaj kolejne-naciśnij ENTER");
                    string e = Console.ReadLine();
                    if (e == "E")
                    {
                        x = false;
                    }
                }
                if (d == "E")
                {
                    x = false;
                }
            }
        }
        static void First()
        {
            Console.WriteLine("Day Planer");
            Console.WriteLine("ver 1.0(beta)");
            Console.WriteLine();

        }

    }
}
