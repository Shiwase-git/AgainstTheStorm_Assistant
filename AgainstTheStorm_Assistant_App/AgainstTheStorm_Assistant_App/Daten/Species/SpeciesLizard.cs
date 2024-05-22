
using System.Collections.Generic;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class SpeciesLizard : Species
    {
        public string Name
        {
            get { return species.Lizard.ToString(); }
        }
        public List<string> Needs
        {
            get { return new List<string> { Food.Jerky.ToString(), Food.Skewers.ToString(), Food.Pie.ToString(), Food.PickledGoods.ToString(), Activities.Brawling.ToString(), Activities.Religion.ToString() }; }
        }
    }
}
