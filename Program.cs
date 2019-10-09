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



                ColorYellow();
                Console.WriteLine("wyświetl wydarzenia wpisz: K");
                Console.WriteLine("Jeśli chcesz wykasować jakieś wydarzenia wpisz: D");
                Console.WriteLine("Jeśli chcesz zakończyć: E");
                Console.WriteLine("dodaj kolejne-naciśnij ENTER");
                String d = Console.ReadLine();
                ColorWhite();
                if (d == "K")
                {
                    ColorGreen();
                    Console.WriteLine("###########################Wydarzenia############################");
                    ColorWhite();
                    for (int z = 0; z < titles.Length; z++)
                    {
                        if (titles[z] != null)
                        {
                            Console.WriteLine("Wydarzenie Nr " + idies[z]);
                            Console.WriteLine(titles[z]);
                            Console.WriteLine(events[z]);
                            Console.WriteLine(" ");
                        }
                    }
                    ColorGreen();
                    Console.WriteLine("##################################################################");
                    ColorWhite();
                    Console.WriteLine("Jeśli chcesz zakończyć: E");
                    Console.WriteLine("dodaj kolejne-naciśnij ENTER");
                    string e = Console.ReadLine();
                    if (e == "E")
                    {
                        x = false;
                    }
                }
                if (d == "D")
                {
                    bool kas = true;
                    while (kas == true)
                    {
                        Console.WriteLine("wprowadź numer wydarzenia do skasowania");
                        string del = Console.ReadLine();
                        int del_id = Convert.ToInt32(del) - 1;
                        titles[del_id] = null;
                        events[del_id] = null;
                        ColorYellow();
                        Console.WriteLine("Jeśli chcesz zakończyć: E");
                        Console.WriteLine("dodaj kolejne-wpisz:N");
                        Console.WriteLine("Chcesz skasować kolejne wydarzenie wciśnij: ENTER");
                        string e = Console.ReadLine();
                        ColorWhite();
                        if (e == "E")
                        {
                            kas = false;
                            x = false;
                        }
                        if (e == "N")
                        {
                            kas = false;
                        }
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
            Console.WriteLine("ver 1.2(beta)");
            Console.WriteLine();

        }
        
        static void ColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void ColorWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ColorYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

    }
}
