using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainstTheStorm_Assistant_App.Daten.Goods
{
    public class Good
    {
        public enum BuildingMaterials
        {
            Bricks,
            Fabric,
            Parts,
            Planks,
            WildfireEssence
        }
        public enum ConsumableItems
        {
            Ale,
            Coats,
            Cosmetics,
            Incense,
            Scrolls,
            TrainingGear,
            Wine
        }
        public enum Activities
        {
            Leisure,
            Brawling,
            Religion,
            Education,
            Luxury,
            Treatment
        }
        public enum CraftingRessources
        {
            Barrels,
            Clay,
            CopperBar,
            CopperOre,
            CrystalizedDew,
            Flour,
            Grain,
            Herbs,
            Leather,
            Pigment,
            PlantFiber,
            Pottery,
            Reed,
            Resin,
            Sparkdew,
            Stone,
            Waterskins
        }
        public enum Food
        {
            Berries,
            Biscuits,
            Eggs,
            Insects,
            Jerky,
            Meat,
            Muschrooms,
            PickledGoods,
            Pie,
            Porridge,
            Roots,
            Skewers,
            Vegetables
        }
        public enum Fuel
        {
            Coal,
            InfusedTools,
            Oil,
            PurgingFire,
            SeaMarrow,
            SimpleTools,
            Wood
        }
        public enum TradeGoods
        {
            Amber,
            AncientTablet,
            Artifacts,
            FoodStockpiles,
            Machinery,
            PackOfBuildingMaterials,
            PackOfCrops,
            PackOfLuxuryGoods,
            PackOfProvisions,
            PackOfTradeGoods
        }
    }
}
