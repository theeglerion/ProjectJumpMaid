using System;
using System.IO;


namespace JumpMaid
{
    class Saves
    {
        // String der den Pfad zu "c:\users\..\Dokumente\" und den Unterordnern "JumpGirl\Saves" enthält.
        static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\JumpGirl\Saves";
        static string savefile = path + @"\save.txt";
        Entity charakter;

        public void CreateFolder()  // Methode erstellt einen Ordner. 
        {
            try
            {
                if (Directory.Exists(path)) // Check ob Directory schon existiert.
                {
                    Console.WriteLine("That path allready exists!");
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(path); // Versucht Directory zu erstellen. 
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path)); // Ausgabe, dass Pfad erfolgrich xx:xx Uhr erstell wurde. 

            }
            catch (Exception e) // Fängt Fehler.
            {
                Console.WriteLine("The process failed: {0}", e.ToString()); // Ausgabe d. Fehlers.
            }
        }

        public void SaveCharakter(Entity c) // Methode speichert Daten einer Entität in einer Datei
        {
            charakter = c;
            FileStream file;    // Stream in und/oder aus Datei.

            try     // Versucht Datei zu erstellen.
            {
                if (File.Exists(savefile))  // Check ob Save-File schon existiert.
                {
                    Console.WriteLine("That file allready exists!"); // Wenn ja, gib diesen Text auf die Konsole aus.
                    //return; // Redunant > Fürs Testen, wenn "else" feht.
                }
                else
                {
                    file = File.Create(savefile); // Erstellt Datei.
                    Console.WriteLine("The directory was created successfully at {0}.", File.GetCreationTime(savefile)); // Ausgabe, dass Daei erfolgrich xx:xx Uhr erstell wurde.
                    file.Close();   // Schießt Datei. Kann sonnst nichz in Datei schreiben.
                }
            }
            catch (Exception e) // Fängt Fehler.
            {
                Console.WriteLine("The process failed: {0}", e.ToString()); // Gibt Fehler auf Konsole aus.
            }

            using (StreamWriter sw = new StreamWriter(savefile))    // Ersellt und benutzt Objek von Klasse "StreamWriter" (system.IO).  
            {
                sw.WriteLine(c.asString());  // Schreibt Entität-Daten als String in Datei.
                sw.Close();
            }
        }

        public Entity LoadSave()    // Methode läd Entität-Daten aus Datei und schreibt sie in ein Objekt von Entity.
        {
            Entity entity;
            string load;
            string[] splitter;  // Das ist ein Array! 

            using (StreamReader sr = new StreamReader(savefile))  // Ersellt und benutzt Objek von Klasse "StreamReader" (system.IO).
            {
                load = sr.ReadLine();   // Liest String aus Datei.
                sr.Close();
            }

            Console.WriteLine(load); // test

            splitter = load.Split(';'); // Teilt Sring bei einem ";" und schreibt  

            int life;
            bool b = int.TryParse(splitter[0], out life);   // Versucht "Lebens-Wert" aus Sting-Arrayzu lesen und in Int zu übergeben.

            if (b)
                Console.WriteLine("Leben gelesen!");
            else
                Console.WriteLine("Leben konnte nicht gelesen werden!");

            int loot;
            bool bb = int.TryParse(splitter[3], out loot);  // Versucht "Loot-Wert" aus Sting-Arrayzu lesen und in Int zu übergeben.

            if (bb)
                Console.WriteLine("Loot gelesen!");
            else
                Console.WriteLine("Loot konnte nicht gelesen werden!");


            entity = new Entity(life, splitter[1], splitter[2], loot); // Erstellt neues Objekt von Entity

            return entity;
        }

    }
}

