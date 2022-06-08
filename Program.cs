using System;

namespace ISBN;

class Programm
{
    public static void Main(string[] args)
    {
        string eingabe;

        Console.WriteLine("ISBN: Internationale Standard Buch Nummer");
        Console.Write("Eingabe der 9-stelligen ISBN-Nummer: ");
        eingabe = Console.ReadLine();

        while (eingabe.Length > 9)
        {
            Console.WriteLine("Du kannst nicht richtig zählen! Gibt die Zahl erneut ein.");

            Console.Write("Eingabe der 9-stelligen ISBN-Nummer: ");
            eingabe = Console.ReadLine();
        }

        int[] ISBN = new int[9];
        int rechnung = 0;

        for (int i = 0; i < ISBN.Length; i++)
        {
            //Console.WriteLine("{0}: Wert:",i+1); //zum Testen
            ISBN[i] = Convert.ToInt32(eingabe.Substring(i, 1));
            //Console.WriteLine(ISBN[i]); //Test-Ausgabe der Zellen im Array
        }
        for (int i = 0; i < ISBN.Length; i++)
        {
            rechnung += (i+1) * ISBN[i];
            //Console.WriteLine("{0}",rechnung); //zum Testen
        }

        //Console.WriteLine("{0}\n",rechnung); //zum Testen

        rechnung %= 11;

        //Console.WriteLine("{0}\n",rechnung); //zum Testen

        string pruefziffer;
        if(rechnung == 10)
        {
            pruefziffer = "X";
            Console.WriteLine("Die Prüfziffer lautet {0}", pruefziffer);
        }
        else
        {
            pruefziffer =""+rechnung;
            Console.WriteLine("Die Prüfziffer lautet {0}", pruefziffer);
        }

        Console.Write("DIe komplette ISBN-Nummer lautet: {0}-", ISBN[0]);
        for(int i = 1; i < ISBN.Length; i++)
        {
            if(i == 4)
            {
                Console.Write("-");
            }
            Console.Write("{0}",ISBN[i]);
        }
        Console.WriteLine("-{0}",pruefziffer);

        
    }
}

