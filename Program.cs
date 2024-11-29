namespace _08._5Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Teil1

            //Lottozahlen
            //Erstellen Sie ein int[] lottozahlen mit der Länge 49.
            //Schreiben Sie dann einen Code der dieses Array automatisch mit den Zahlen 1 - 49 befüllt.

            //Teil2

            //Ziehung der Lottozahlen
            //Aus dem Array unserer Lottozahlen sollen nun sechs Zahlen zufällig gezogen werden.
            //Diese sechs Zahlen müssen in einem neuen Array abgelegt werden. 
            //Verwenden Sie auch wieder Random für die Zufällige Ziehung.
            //Bei den gezogenen Zahlen darf es zu keiner Dopplung kommen.

            //Teil3

            //User-Eingabe und Gewinnausgabe
            //Der User soll in der Lage sein, sechs Zahlen einzugeben.
            //Diese werden in einem Array abgelegt.
            //Danach soll überprüft werden, wieviele Zahlen der User im Vergleich zu den gezogenen Lottozahlen richtig getippt hat.
            //Geben Sie in der Konsole aus, wieviele Richtige getippt wurden.

            //Sollten Sie in der vorherigen Aufgabe zu keiner Lösung gekommen sein, schreiben Sie von Hand ein Array mit gezogenen Zahlen.
           
            
            // Teil1
            
            
            int[] LottoZahlen = new int[49];
          

            for (int i = 0; i < LottoZahlen.Length; i++)
            {   
               
                LottoZahlen[i] = i + 1;
            }
            // foreach (int j in LottoZahlen) // Zur Überprüfung
            //{
            //    Console.WriteLine(j);
            //}

           
            // Teil2 
            
            Random Gezogen = new Random();
            int[] sechsGezogen = new int[6];
            int k = 0;

            while (true)
            {
                
                int GezogeneZahl = Gezogen.Next(0, 50);

                bool gefunden = false;

                foreach (int q in sechsGezogen)
                {
                    if (GezogeneZahl == q)
                    {
                        gefunden = true;
                    }
                }

                if (!gefunden)
                {
                    sechsGezogen[k] = GezogeneZahl;
                    k++;
                }

                gefunden = false;

                if (k > 5)
                {
                    break;
                }

                

            }

            Console.WriteLine(string.Join(",", sechsGezogen));

            //Ziehung User Teil3

            int[] BenutzerZahlen = new int[6];
            Console.WriteLine("Geben Sie 6 unterschiedliche Zahlen von 1 - 49 an");
            BenutzerZahlen[0] = Convert.ToInt32(Console.ReadLine());
            BenutzerZahlen[1] = Convert.ToInt32(Console.ReadLine());
            BenutzerZahlen[2] = Convert.ToInt32(Console.ReadLine());
            BenutzerZahlen[3] = Convert.ToInt32(Console.ReadLine());
            BenutzerZahlen[4] = Convert.ToInt32(Console.ReadLine());
            BenutzerZahlen[5] = Convert.ToInt32(Console.ReadLine());

            foreach (int w in BenutzerZahlen)
            {
                Console.WriteLine($"Ihre Zahlen sind: {w}");
            }

            Console.WriteLine("Die gezogenene Zahlen sind folgende: ");
            Console.WriteLine(string.Join(",", sechsGezogen));

            int richtige = 0;

            foreach (int p in BenutzerZahlen)
            {
                foreach  (int r in sechsGezogen)
                {
                    if (p == r)
                        richtige++;
                }
            }


            Console.WriteLine($"Sie haben {richtige} richtige Zahlen getippt!");

            if (richtige == 0)
            {
                Console.WriteLine("Leider kein Gewinn");
            }
            if (richtige == 1)
            {
                Console.WriteLine("Leider kein Gewinn");
            }
            if (richtige == 2)
            {
                Console.WriteLine("Ihr Gewinn beträgt 10 Euro");
            }
            if (richtige == 3)
            {
                Console.WriteLine("Ihr Gewinn beträgt 1000 Euro");
            }
            if (richtige == 4)
            {
                Console.WriteLine("Ihr Gewinn beträgt 10.000 Euro");
            }
            if (richtige == 5)
            {
                Console.WriteLine("Ihr Gewinn beträgt 100.000 Euro");
            }
            if (richtige == 6)
            {
                Console.WriteLine("Ihr Gewinn beträgt 10.000.000 €");
            }
        }
    }
}
