using AgainstTheStorm_Assistant_App.Daten.Species;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgainstTheStorm_Assistant_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welche Rassen werden gespielt?
            

            string[] Rassen = {"","",""};
            Enum[] NeedsRasse;

            Console.WriteLine("Bitte die Drei Rassen eingeben: Human,Beaver,Harpy,Lizard,Fox");
            Console.WriteLine("Rasse 1:");
            Rassen[0] = Console.ReadLine();
            Console.WriteLine("Rasse 2:");
            Rassen[1] = Console.ReadLine();
            Console.WriteLine("Rasse 3:");
            Rassen[2] = Console.ReadLine();

            Console.WriteLine("Needs:");
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
                Console.WriteLine("");
                Console.WriteLine(Rasse);
                foreach (Enum need in NeedsRasse)
                {
                    Console.WriteLine(need.ToString());

                    //If noch nicht in Liste --> Zu Needliste Hinzufügen
                }
            }


            Console.WriteLine("Enter to End");
            Console.ReadLine();
        }
    }
}
