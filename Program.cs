using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) feladat

            List<string> nevek = new List<string>() { "Ábel", "Abigél", "Ádám", "Adél", "Adrián", "Ákos", "Alex", "Alexander", "Alexandra", "Alíz", "Amira", "András", "Anna", "Ármin", "Áron", "Attila", "Balázs", "Bálint", "Barbara", "Barnabás", "Bella", "Bence", "Bende", "Bendegúz", "Benedek", "Benett", "Benjamin", "Benjámin", "Bertalan", "Bianka", "Bíborka", "Blanka", "Boglárka", "Boldizsár", "Borbála", "Boróka", "Botond", "Brájen", "Brendon", "Csaba", "Csenge", "Csongor", "Dalma", "Dániel", "Dávid", "Dénes", "Denisz", "Diána", "Dominik", "Donát", "Dóra", "Dorián", "Dorina", "Dorka", "Dorottya", "Elena", "Eliza", "Elizabet", "Emese", "Emili", "Emília", "Emma", "Enikő", "Erik", "Eszter", "Fanni", "Félix", "Ferenc", "Flóra", "Fruzsina", "Gábor", "Gellért", "Gergely", "Gergő", "Gréta", "György", "Gyula", "Hanga", "Hanna", "Hédi", "Hunor", "Imre", "István", "Izabella", "Janka", "János", "Jázmin", "Johanna", "József", "Júlia", "Kamilla", "Károly", "Kende", "Kevin", "Kiara", "Kincső", "Kinga", "Kornél", "Kristóf", "Krisztián", "Krisztofer", "Lajos", "Lara", "László", "Laura", "Léna", "Letícia", "Levente", "Lia", "Lili", "Liliána", "Lilien", "Lilla", "Linett", "Liza", "Lora", "Lotti", "Luca", "Lujza", "Maja", "Marcell", "Márk", "Martin", "Márton", "Máté", "Mátyás", "Mia", "Mihály", "Miklós", "Milán", "Milla", "Mira", "Mirella", "Mirkó", "Nándor", "Nara", "Natália", "Natasa", "Nikolasz", "Nimród", "Noé", "Noel", "Noémi", "Nolen", "Nóra", "Norbert", "Norina", "Olivér", "Olívia", "Panka", "Panna", "Patrik", "Péter", "Petra", "Rebeka", "Regina", "Réka", "Richárd", "Róbert", "Roland", "Róza", "Rozina", "Sámuel", "Sándor", "Sára", "Simon", "Soma", "Szabolcs", "Szofi", "Szofia", "Szófia", "Szonja", "Tamara", "Tamás", "Tibor", "Tímea", "Vanda", "Vanessza", "Vencel", "Vendel", "Veronika", "Viktor", "Viktória", "Vilmos", "Vince", "Virág", "Vivien", "Zalán", "Zara", "Zénó", "Zente", "Zétény", "Zita", "Zoé", "Zoltán", "Zorka", "Zselyke", "Zsófia", "Zsolt", "Zsombor" };

            //a) Listázza ki a 7 karakteről hosszabb neveket!
            string hetKarakter = "";
            foreach (string nev in nevek)
            {
                if (nev.Length > 7)
                {
                    hetKarakter += nev;
                }
            }
            //b) Hozzon létre egy másik listát és másolja bele az 'e' betűre végződő neveket!

            /*
            2) feladat
            Hozzon létre egy double számokat tartalmazó listát!Kérjen be 5 számot, amit tároljon a listába!
            Ezután írja ki a számok átlagát, a beírt legkisebb, legnagyobb számot!
            Rendezze növekvő sorba a számokat és így írja ki egymás alá őket!
    
            Megjegyzés: Használhatja az új eszközöket!(Min, stb.)

            3) feladat
            Készítse el a lottószám húzó programot úgy, hogy ne lehessen u.azt a számot kihúzni.
            */
            List<int> kihuzhatoSzamok = new List<int>();
            for (int huzas = 1; huzas < 91; huzas++)
            {
                kihuzhatoSzamok.Add(huzas);
            }
            /*
            foreach (int szam in kihuzhatoSzamok)
            {
                Console.WriteLine(szam);
            }
            */
            Random var = new Random();
            List<int> kihuzottSzamok = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int rnd = var.Next(kihuzhatoSzamok[0], kihuzhatoSzamok.Count);
                kihuzottSzamok.Add(rnd);
                kihuzhatoSzamok.Remove(rnd);
            }
            foreach (int szam in kihuzottSzamok)
            {
                Console.Write(szam+';');
            }
            Console.ReadKey();
        }
    }
}
