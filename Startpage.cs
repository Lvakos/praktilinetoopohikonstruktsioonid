using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace praktilinetoopohikonstruktsioonid
{
    public class Startpage
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("""
                    Sisesta valik:
                    1. Kytusekalkulaator
                    2. Isikukood hindamine
                    3. Taringumäng
                    4. Arvutapalk
                    """);
                int valik = int.Parse(Console.ReadLine());
                switch (valik)
                {
                    case 1:
                        Alamfunktsioonid.KytuseKalkulaator();
                        break;
                    case 2:
                        Alamfunktsioonid.HindaIsikukood();
                        break;
                    case 3:
                        Alamfunktsioonid.TaringuMang();
                        break;
                    case 4:
                        Console.WriteLine("Sisesta sinu brutopalk: ");
                        double palk = double.Parse(Console.ReadLine());
                        var funk = Alamfunktsioonid.ArvutaPalk(palk);
                        Console.WriteLine($"Sinu maksuvaba on: {funk.Item2}, ja netopalk on: {funk.Item1} ");
                        break;
                }
            }
        }
    }
}
