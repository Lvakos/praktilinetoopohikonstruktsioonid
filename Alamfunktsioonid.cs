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
            Console.WriteLine("Sisesta läbitud teepikkus(km): ");
            try
            {
                teepikkus = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Sisesta kütusekulu 100km kohta (liitrit): ");
            try
            {
                kütusekulu = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Sisesta kütuse liitri hind (€): ");
            try
            {
                liitrihind = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            double kütustkulus = ((kütusekulu/100) * teepikkus);
            double reisimaksumus = (kütustkulus * liitrihind);

            Console.WriteLine($""" 
            {kütustkulus} liitrit kütust kulus reisi peale kokku.
            Reisi maksumus on: {reisimaksumus}.
            """);
        }

        private static Tuple<double, double> ourdouble(double bruttopalk, double tulumaks, double töötuskindlustus, double kogumispension)
        {
            double maksuvabatulu = tulumaks + töötuskindlustus + kogumispension;
            double netto = bruttopalk - tulumaks;
            return Tuple.Create(maksuvabatulu, tulumaks);
        }
        public static void CalculateSalary(double bruttopalk)
        {
            double tulumaks = 0;
            double töötuskindlustus = 0;
            double kogumispension = 0;
            if (bruttopalk < 1200)
            {
                tulumaks = (bruttopalk / 100) * 20;
            }
            töötuskindlustus = (bruttopalk / 100) * 1.6;
            kogumispension = (bruttopalk / 100) * 2;
            var ourdouble = Alamfunktsioonid.ourdouble(bruttopalk, tulumaks, töötuskindlustus, kogumispension);
            Console.WriteLine($"{ourdouble.Item1}, {ourdouble.Item2}");
        }
    }
}
