using PudelkoLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            List<Pudelko> pudelka = new List<Pudelko>();
            pudelka.Add(new Pudelko(5, 9, 7, UnitOfMeasure.meter));
            pudelka.Add(new Pudelko(33.22, 71.211, 532.12, UnitOfMeasure.centimeter));
            pudelka.Add(new Pudelko(1522, 9215, 5221, UnitOfMeasure.milimeter));
            pudelka.Add(new Pudelko(8, 9, 8, UnitOfMeasure.meter));
            pudelka.Add(new Pudelko(5.541, 2.521));
            pudelka.Add(new Pudelko(2.4215, null, 9.12));
            pudelka.Add(new Pudelko(null, 2.12, null));
            pudelka.Add(new Pudelko(1.45));
            pudelka.Add(new Pudelko());
            pudelka.Add(
                new Pudelko(444, 123, 215, UnitOfMeasure.centimeter).Kompresuj()
            );

            pudelka.Sort();

            pudelka.ForEach(
                (pudelko) => {
                    Console.WriteLine(pudelko);
                }
            );
            Console.WriteLine((new Pudelko(2.5, 9.321, 0.1)).ToString("mm"));
        }
    }
}
