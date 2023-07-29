using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalL2MagicDmgCalculator.Stats
{
    public class BuffStats : SkillStats
    {
        protected readonly string BuffFullName1;
        protected readonly string BuffFullName2;
        protected readonly string BuffFullName3;
        protected readonly string BuffFullName4;
        protected readonly string BuffFullName5;
        protected readonly string BuffFullName6;
        protected readonly ushort BuffMAtkBoost1;
        protected readonly ushort BuffMAtkBoost;
        protected readonly ushort BuffMAtkBoost3;
        protected readonly ushort BuffMAtkBoost4;
        protected readonly ushort BuffMAtkBoost5;
        protected readonly ushort BuffMAtkBoost6;
        protected readonly uint HeroicBerserkerMAtkBoost;

        public BuffStats(string buffFullName1, string buffFullName2, string buffFullName3, string buffFullName4, string buffFullName5, string buffFullName6, ushort buffMAtkBoost1, ushort buffMAtkBoost, ushort buffMAtkBoost3, ushort buffMAtkBoost4, ushort buffMAtkBoost5, ushort buffMAtkBoost6, uint heroicBerserkerMAtkBoost,
            string nukeType, ushort nukeLevel, ushort nukePower, string nukeEnchantType, sbyte weaponMasteryLevel, bool nukeElementMatches, sbyte nukeEnchantPower, uint weaponMAtk, bool sigilEquiped, bool valakasEquiped, uint augmentationBoost, ushort characterLevel, ushort characterInt, ushort characterWit, ushort characterMen, uint characterTotalMatk, string characterClass, ushort characterTotalAttribute)
            : base(nukeType, nukeLevel, nukePower, nukeEnchantType, weaponMasteryLevel, nukeElementMatches, nukeEnchantPower, weaponMAtk, sigilEquiped, valakasEquiped, augmentationBoost, characterLevel, characterInt, characterWit, characterMen, characterTotalMatk, characterClass, characterTotalAttribute)
        {
            BuffFullName1 = buffFullName1;
            BuffFullName2 = buffFullName2;
            BuffFullName3 = buffFullName3;
            BuffFullName4 = buffFullName4;
            BuffFullName5 = buffFullName5;
            BuffFullName6 = buffFullName6;
            BuffMAtkBoost1 = buffMAtkBoost1;
            BuffMAtkBoost = buffMAtkBoost;
            BuffMAtkBoost3 = buffMAtkBoost3;
            BuffMAtkBoost4 = buffMAtkBoost4;
            BuffMAtkBoost5 = buffMAtkBoost5;
            BuffMAtkBoost6 = buffMAtkBoost6;
            HeroicBerserkerMAtkBoost = heroicBerserkerMAtkBoost;
        }
    }
}
