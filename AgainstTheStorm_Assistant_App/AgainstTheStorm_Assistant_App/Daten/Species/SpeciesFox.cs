
using System.Collections.Generic;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class SpeciesFox : Species
    {
        public string Name
        {
            get { return species.Fox.ToString(); }
        }
        public List<string> Needs
        {
            get { return new List<string> { Food.Skewers.ToString(), Food.PickledGoods.ToString(), Food.Porridge.ToString(), Activities.Brawling.ToString(), Activities.Luxury.ToString(), Activities.Treatment.ToString()}; }
        }
    }
}
