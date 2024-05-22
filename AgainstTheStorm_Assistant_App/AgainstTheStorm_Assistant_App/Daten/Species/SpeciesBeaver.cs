
using System.Collections.Generic;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class SpeciesBeaver : Species
    {
        public string Name
        {
            get { return species.Beaver.ToString(); }
        }
        public List<string> Needs
        {
            get { return new List<string> { Food.Biscuits.ToString(), Food.PickledGoods.ToString(), ConsumableItems.Coats.ToString(), Activities.Leisure.ToString(), Activities.Education.ToString(), Activities.Luxury.ToString()}; }
        }
    }    
}
