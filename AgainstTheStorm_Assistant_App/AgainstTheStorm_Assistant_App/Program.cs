using AgainstTheStorm_Assistant_App.Daten.Species;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgainstTheStorm_Assistant_App
{
    internal class Program
    {
        static public bool ReportsOn = true;
        Dictionary<string, int> SpeciesRating = new Dictionary<string, int>();
        Dictionary<string, int> BuildingRating = new Dictionary<string, int>();
        Dictionary<string, int> GoodRating = new Dictionary<string, int>();
        Dictionary<string, int> CornerstoneRating = new Dictionary<string, int>();
        static void Main()
        {
            //Beste Rassen aus vorraussetzungen bestimmen.
            ///Todo

            string[] Rassen = RassenEingeben();
            List<string> NeedsRassen = NeedsAuslesen(Rassen);

            ///Todo: Gebäudevalues bestimmen

            //EndMock
            Console.WriteLine("Enter to End");
            Console.ReadLine();
        }

        static string[] RassenEingeben()
        {
            string[] Rassen = { "", "", "" };

            //Welche Rassen werden gespielt?
            Console.WriteLine("Bitte die drei Rassen eingeben: Human,Beaver,Harpy,Lizard,Fox");
            
            int i = 0;
            bool EingabeValid = false;
            foreach (string Rasse in Rassen)
            {
                Console.WriteLine("Rasse "+i.ToString()+":");
                while (EingabeValid == false)
                {
                    Rassen[i] = Console.ReadLine();
                    if (Rassen[i] == "Human" | Rassen[i] == "Beaver" | Rassen[i] == "Harpy" | Rassen[i] == "Lizard" | Rassen[i] == "Fox") EingabeValid = true;
                    if (EingabeValid == false) Console.WriteLine("Invalide Eingabe: Bitte eine der Oben genannten Rassen eingeben");
                }
                i++;
                EingabeValid = false;
            }
            return Rassen;
        }
        
        static List<string> NeedsAuslesen(string[] Rassen)
        {
            List<string> NeedsRasse;
            List<string> NeedsRassen = new List<string> {}; ;

            if (ReportsOn) Console.WriteLine("Needs:");
            foreach (string Rasse in Rassen)
            {
                switch (Rasse)
                {
                    case "Human":
                        NeedsRasse = NeedsHuman.GetNeeds();
                        break;
                    case "Beaver":
                        NeedsRasse = NeedsBeaver.GetNeeds();
                        break;
                    case "Harpy":
                        NeedsRasse = NeedsHarpy.GetNeeds();
                        break;
                    case "Lizard":
                        NeedsRasse = NeedsLizard.GetNeeds();
                        break;
                    case "Fox":
                        NeedsRasse = NeedsFox.GetNeeds();
                        break;
                    default:
                        NeedsRasse = null;
                        break;

                }
                if (ReportsOn) Console.WriteLine("");
                if (ReportsOn) Console.WriteLine(Rasse);
                foreach (string need in NeedsRasse)
                {
                    if (!NeedsRassen.Contains(need))
                    {
                        NeedsRassen.Add(need);
                        if (ReportsOn) Console.WriteLine(need.ToString());
                    }
                    else
                    {
                        ///Todo: Need value up
                    }
                }
            }
            if (ReportsOn) Console.WriteLine("");
            if (ReportsOn) Console.WriteLine("Ganze Liste");
            foreach (string need in NeedsRassen)
            {
                if(ReportsOn)Console.WriteLine(need);
            }
            return NeedsRassen;
        }
    }
}
