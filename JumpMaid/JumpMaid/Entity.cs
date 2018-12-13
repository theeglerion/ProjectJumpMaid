using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpMaid
{
    public class Entity // ehemals Charakter
    {
        public string Name;
        public string Aussehen;
        //public string Ausrüstung;
        public int Loot;
        public int Leben_Charakter;





        //Parameterisierter Konstruktor
        public Entity(int Leben_Charakter, string Name, string Aussehen, int Loot)
        {
            this.Leben_Charakter = Leben_Charakter;
            this.Name = Name;
            this.Aussehen = Aussehen;
            this.Loot = Loot;

            /*
            Hallo();
            Optik();
            Schaden();
            Leben_schaden(Leben_Charakter);
            */
        }
        // Methode 
        void Hallo()
        {
            Name = Console.ReadLine(); // Name selber Wählbar erstmal alles erlaubt

            Console.WriteLine("Hallo ich heiße " + Name + " und ich habe " + Leben_Charakter + " Leben.");

        }
        // Methode
        int Schaden()
        {

            Console.WriteLine("Ich lasse " + Loot + " Gold fallen wenn ich sterbe.");

            return Loot;
        }
        // Methode
        string Optik()
        {

            Console.WriteLine("Ich sehe aus wie " + Aussehen + ".");

            return Aussehen;
        }
        // Wenn Leben auf 0 fällt bist du tod (Platzhalter)
        int Leben_schaden(int Leben_Charakter)
        {

            if (Leben_Charakter < 1)
            {
                Console.WriteLine("Du bist Tod.");
            }
            else
            {
                Console.WriteLine("Weiter so.");
            }
            return 0;
        }

        public string asString()
        {
            string ausgabe = Leben_Charakter.ToString() + ";" + Name + ";" + Aussehen + ";" + Loot;

            return ausgabe;
        }


    }
}

