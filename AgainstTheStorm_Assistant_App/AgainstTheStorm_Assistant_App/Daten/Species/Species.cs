using AgainstTheStorm_Assistant_App.Daten.Goods;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AgainstTheStorm_Assistant_App.Daten.Goods.Good;

namespace AgainstTheStorm_Assistant_App.Daten.Species
{
    public class Species
    {
        public enum species
        {
            Human,
            Beaver,
            Harpy,
            Lizard,
            Fox
        }
    }
    
    public class NeedsHuman
    {
        static readonly Food Need1 = Food.Biscuits;
        static readonly Food Need2 = Food.Pie;
        static readonly Food Need3 = Food.Porridge;
        static readonly ConsumableItems Need4 = ConsumableItems.Coats;
        static readonly Activities Need5 = Activities.Leisure;
        static readonly Activities Need6 = Activities.Religion;
        static public Enum[] GetNeeds()
        {
            Enum[] needs = {Need1,Need2,Need3,Need4,Need5,Need6};
            return needs;
        }
    }
    public class NeedsBeaver
    {
        static readonly Food Need1 = Food.Biscuits;
        static readonly Food Need2 = Food.PickledGoods;
        static readonly ConsumableItems Need3 = ConsumableItems.Coats;
        static readonly Activities Need4 = Activities.Leisure;
        static readonly Activities Need5 = Activities.Education;
        static readonly Activities Need6 = Activities.Luxury;
        static public Enum[] GetNeeds()
        {
            Enum[] needs = { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsHarpy
    {
        static readonly Food Need1 = Food.Jerky;
        static readonly Food Need2 = Food.Biscuits;
        static readonly Food Need3 = Food.Pie;
        static readonly ConsumableItems Need4 = ConsumableItems.Coats;
        static readonly Activities Need5 = Activities.Education;
        static readonly Activities Need6 = Activities.Treatment;
        static public Enum[] GetNeeds()
        {
            Enum[] needs = { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsLizard
    {
        static readonly Food Need1 = Food.Jerky;
        static readonly Food Need2 = Food.Skewers;
        static readonly Food Need3 = Food.Pie;
        static readonly Food Need4 = Food.PickledGoods;
        static readonly Activities Need5 = Activities.Brawling;
        static readonly Activities Need6 = Activities.Religion;
        static public Enum[] GetNeeds()
        {
            Enum[] needs = { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsFox
    {
        static readonly Food Need1 = Food.Skewers;
        static readonly Food Need2 = Food.PickledGoods;
        static readonly Food Need3 = Food.Porridge;
        static readonly Activities Need4 = Activities.Brawling;
        static readonly Activities Need5 = Activities.Luxury;
        static readonly Activities Need6 = Activities.Treatment;
        static public Enum[] GetNeeds()
        {
            Enum[] needs = { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }

    
}
