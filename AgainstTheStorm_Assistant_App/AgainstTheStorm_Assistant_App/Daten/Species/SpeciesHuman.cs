
using System.Collections.Generic;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class SpeciesHuman : Species
    {
        public string Name
        {
            get { return species.Human.ToString(); }
        }
        public List<string> Needs
        {
            get { return new List<string> { Food.Biscuits.ToString(), Food.Pie.ToString(), Food.Porridge.ToString(), ConsumableItems.Coats.ToString(), Activities.Leisure.ToString(), Activities.Religion.ToString() }; }
        }
    }
}
