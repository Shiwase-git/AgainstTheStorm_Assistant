using AgainstTheStorm_Assistant_App.Daten.Buildings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static AgainstTheStorm_Assistant_App.Daten.Cornerstones.Cornerstone;

namespace AgainstTheStorm_Assistant_App.Daten.Cornerstones
{
    internal class Cornerstone
    { 
        public enum Cornerstones
        {
            AdvancedFuel,
            AdvancedHerbalism,
            AlarmBells,
            AncientArtifact,
            AncientPact,
            BacktoNature,
            BaptismofFire,
            BarrelDeliveryLine,
            BedandBreakfast,
            BiscuitDiet,
            BlightExtractor,
            BloodPriceContract,
            BoneTools,
            BreadPeels,
            BurnttoaCrisp,
            CalmingtheForest,
            Cannibalism,
            CheapConstruction,
            ClayDeliveryLine,
            CookingSteam,
            CopperExtractor,
            CosmeticSpecialization,
            CrowdedCaravan,
            CrowdedHouses,
            DeepPockets,
            DesertedCaravans,
            DyeExtractor,
            EconomicMigration,
            ExplorationContract,
            ExplorationExpedition,
            ExplorationTraining,
            ExportSpecialization,
            ExtractionTools,
            FamilyGratitude,
            FiberDelivery,
            FieryWrath,
            FirekeepersArmor,
            FirekeepersPrayer,
            FirelinkRitual,
            FlameAmulets,
            ForceofNature,
            ForgeTripHammer,
            FrequentCaravansBoosts,
            FrequentPatrols,
            FriendlyRelationsBoosts,
            FromTheAshes,
            FungalGuide,
            GenerousGifts,
            GenerousRations,
            GiantVegetables,
            GoldenMarrow,
            GrainBags,
            GrainDeliveryLine,
            GuildCatalogue,
            HiddenfromtheQueen,
            HiddenReward,
            HunterGatherers,
            ImprovisedTools,
            IndustrializedAgriculture,
            LargeBaskets,
            LeatherGloves,
            LeftoverCrops,
            LocalTaxes,
            LostintheWilds,
            LostSupplies,
            LumberTax,
            MeatSpecialization,
            MetallurgicProficiency,
            MistPiercers,
            MoldyGrain,
            MossBroccoli,
            MushroomSeedlings,
            NoQualityControl,
            OldFedoraHat,
            OverDiligentWoodworkers,
            Overexploitation,
            PeasantSupplies,
            PrayerBook,
            ProsperousArchaeology,
            ProsperousSettlement,
            ProtectedTrade,
            QueensGift,
            RainPumps,
            RebelliousSpirit,
            ReinforcedAxes,
            ReinforcedTools,
            ReligiousSettlement,
            RichGlades,
            RootDeliveryLine,
            RootyGround,
            RoyalGuardTraining,
            SafeHaven,
            SahildasSecretCookbook,
            SaltedJerky,
            SecureTrail,
            SharpSickles,
            SilentLooting,
            SmallDistillery,
            SmallPress,
            SmugglersVisi,
            Spices,
            SteelMattocks,
            SteelPickaxes,
            StormwalkerTraining,
            SurpriseChild,
            SurvivorBonding,
            TanningRacks,
            TightenedBelt,
            TradeHub,
            TradeLogs,
            TradeNegotiations,
            TrainingGrounds,
            UrbanPlanning,
            ValueAddedTax,
            VineyardTown,
            WellRestedWorkers,
            WithoutRestrictions,
            WoodcuttersPrayer,
            WoodcuttersSong,
            WoodpeckerTechnique,
            WorkSafetyGuide,
            WorkersRations,
            ZhorgsSecretIngredient   
        }
    }
}
