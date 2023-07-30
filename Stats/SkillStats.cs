using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalL2MagicDmgCalculator.Stats
{
    public class SkillStats : EquipmentStats
    {
        protected readonly string NukeType;
        protected readonly ushort NukeLevel;
        protected readonly ushort NukePower;
        protected readonly string NukeEnchantType;
        protected readonly sbyte WeaponMasteryLevel;
        protected readonly bool NukeElementMatches;
        protected readonly sbyte NukeEnchantPower;

        public SkillStats(string nukeType, ushort nukeLevel, ushort nukePower, string nukeEnchantType, sbyte weaponMasteryLevel, bool nukeElementMatches, sbyte nukeEnchantPower,
            uint weaponMAtk, bool sigilEquiped, bool valakasEquiped, uint augmentationBoost, ushort characterLevel, ushort characterInt, ushort characterWit, ushort characterMen, uint characterTotalMatk, string characterClass, ushort characterTotalAttribute)
            : base(weaponMAtk, sigilEquiped, valakasEquiped, augmentationBoost, characterLevel, characterInt, characterWit, characterMen, characterTotalMatk, characterClass, characterTotalAttribute)
        {
            NukeType = nukeType;
            NukeLevel = nukeLevel;
            NukePower = nukePower;
            NukeEnchantType = nukeEnchantType;
            WeaponMasteryLevel = weaponMasteryLevel;
            NukeElementMatches = nukeElementMatches;
            NukeEnchantPower = nukeEnchantPower;
        }

        public SkillStats(string nukeType, ushort nukeLevel, ushort nukePower, string nukeEnchantType, sbyte weaponMasteryLevel, bool nukeElementMatches, sbyte nukeEnchantPower, 
            EquipmentStats equipmentStats) : base (equipmentStats)
        {
            NukeType = nukeType;
            NukeLevel = nukeLevel;
            NukePower = nukePower;
            NukeEnchantType = nukeEnchantType;
            WeaponMasteryLevel = weaponMasteryLevel;
            NukeElementMatches = nukeElementMatches;
            NukeEnchantPower = nukeEnchantPower;
        }

        public SkillStats(SkillStats skillStats) : base(skillStats)
        {
            NukeType = skillStats.NukeType;
            NukeLevel = skillStats.NukeLevel;
            NukePower = skillStats.NukePower;
            NukeEnchantType = skillStats.NukeEnchantType;
            WeaponMasteryLevel = skillStats.WeaponMasteryLevel;
            NukeElementMatches = skillStats.NukeElementMatches;
            NukeEnchantPower = skillStats.NukeEnchantPower;
        }
    }
}
