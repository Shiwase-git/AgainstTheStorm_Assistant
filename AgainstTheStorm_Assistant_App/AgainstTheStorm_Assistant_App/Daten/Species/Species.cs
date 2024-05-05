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
        static string Need1 = Food.Biscuits.ToString();
        static string Need2 = Food.Pie.ToString();
        static string Need3 = Food.Porridge.ToString();
        static string Need4 = ConsumableItems.Coats.ToString();
        static string Need5 = Activities.Leisure.ToString();
        static string Need6 = Activities.Religion.ToString();
        static public List<string> GetNeeds()
        {
            List<string> needs = new List<string> { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsBeaver
    {
        static string Need1 = Food.Biscuits.ToString();
        static string Need2 = Food.PickledGoods.ToString();
        static string Need3 = ConsumableItems.Coats.ToString();
        static string Need4 = Activities.Leisure.ToString();
        static string Need5 = Activities.Education.ToString();
        static string Need6 = Activities.Luxury.ToString();
        static public List<string> GetNeeds()
        {
            List<string> needs = new List<string> { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsHarpy
    {
        static string Need1 = Food.Jerky.ToString();
        static string Need2 = Food.Biscuits.ToString();
        static string Need3 = Food.Pie.ToString();
        static string Need4 = ConsumableItems.Coats.ToString();
        static string Need5 = Activities.Education.ToString();
        static string Need6 = Activities.Treatment.ToString();
        static public List<string> GetNeeds()
        {
            List<string> needs = new List<string> { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsLizard
    {
        static string Need1 = Food.Jerky.ToString();
        static string Need2 = Food.Skewers.ToString();
        static string Need3 = Food.Pie.ToString();
        static string Need4 = Food.PickledGoods.ToString();
        static string Need5 = Activities.Brawling.ToString();
        static string Need6 = Activities.Religion.ToString();
        static public List<string> GetNeeds()
        {
            List<string> needs = new List<string> { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }
    public class NeedsFox
    {
        static string Need1 = Food.Skewers.ToString();
        static string Need2 = Food.PickledGoods.ToString();
        static string Need3 = Food.Porridge.ToString();
        static string Need4 = Activities.Brawling.ToString();
        static string Need5 = Activities.Luxury.ToString();
        static string Need6 = Activities.Treatment.ToString();
        static public List<string> GetNeeds()
        {
            List<string> needs = new List<string> { Need1, Need2, Need3, Need4, Need5, Need6 };
            return needs;
        }
    }

    
}
