using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace praktilinetoopohikonstruktsioonid
{
    public class Alamfunktsioonid
    {
        public static void KytuseKalkulaator()
        {
            double teepikkus = 0;
            double kütusekulu = 0;
            double liitrihind = 0;
            while (true)
            {
                Console.WriteLine("Sisesta läbitud teepikkus(km): ");
                try
                {
                    teepikkus = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true)
            {
                Console.WriteLine("Sisesta kütusekulu 100km kohta (liitrit): ");
                try
                {
                    kütusekulu = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            while (true)
            {
                Console.WriteLine("Sisesta kütuse liitri hind (€): ");
                try
                {
                    liitrihind = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            double kütustkulus = ((kütusekulu/100) * teepikkus);
            double reisimaksumus = (kütustkulus * liitrihind);

            Console.WriteLine($""" 
            {kütustkulus} liitrit kütust kulus reisi peale kokku.
            Reisi maksumus on: {reisimaksumus}.
            """);
        }

        public static void HindaIsikukood()
        {
            long ik = 0;
            string ikstring;
            while (true)
            {
                try
                {
                    Console.Write("Sisesta isikukood: ");
                    ik = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Vale andmetüüp: {e}");
                }
            }
            ikstring = ik.ToString();

            if (ikstring.Length != 11)
            {
                Console.WriteLine("Viga! Isikukood peab olema 11-kohaline.");
                return;
            }
            string sugu;
            char esimene = ikstring[0];

            if (esimene == '1' || esimene == '3' || esimene == '5')
                sugu = "Mees";
            else if (esimene == '2' || esimene == '4' || esimene == '6')
                sugu = "Naine";
            else
                sugu = "Tundmatu";

            string aasta = ikstring.Substring(1, 2);
            string kuu = ikstring.Substring(3, 2);
            string paev = ikstring.Substring(5, 2);

            Console.WriteLine($"Oled {sugu}, sündinud {paev}.{kuu}.{aasta}");
        }

        public static void TaringuMang()
        {
            Random rnd = new Random();
            List<int> summad = new List<int>();

            int duublid = 0;
            int kogusumma = 0;

            for (int i = 0; i < 10; i++)
            {
                int t1 = rnd.Next(1, 7);
                int t2 = rnd.Next(1, 7);
                Console.WriteLine($"{t1} + {t2}; ");

                if (t1 == t2)
                    duublid++;

                int summa = t1 + t2;
                summad.Add(summa);
                kogusumma += summa;

            }

            Console.WriteLine("Kõik viskad:");
            foreach (int s in summad)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Duubleid visati: {duublid}");
            Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}");
        }

        public static Tuple<double, double> ArvutaPalk(double brutopalk)
        {
            double tulumaks = 0;
            double maksuvaba = 0;
            double töötuskindlustus = 0;
            double kogumispension = 0;
            if (brutopalk < 1200)
            {
                maksuvaba = 654;
            }
            tulumaks = brutopalk - maksuvaba;
            if (tulumaks <0)
            {
                tulumaks = 0;
            }
            tulumaks = (brutopalk / 100) * 20;
            töötuskindlustus = (brutopalk / 100) * 1.6;
            kogumispension = (brutopalk / 100) * 2;

            double netto = brutopalk - tulumaks - töötuskindlustus - kogumispension;
            return Tuple.Create(netto, maksuvaba);
        }
    }
}
