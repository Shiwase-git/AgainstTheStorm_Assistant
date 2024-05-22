
using System.Collections.Generic;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class SpeciesHarpy : Species
    {
        public string Name
        {
            get { return species.Harpy.ToString(); }
        }
        public List<string> Needs
        {
            get { return new List<string> { Food.Jerky.ToString(), Food.Biscuits.ToString(), Food.Pie.ToString(), ConsumableItems.Coats.ToString(), Activities.Education.ToString(), Activities.Treatment.ToString() }; }
        }
    }
}    

