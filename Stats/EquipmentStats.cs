using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalL2MagicDmgCalculator.Stats
{
    public class EquipmentStats : CharacterStats
    {
        protected readonly string NukeType;
        protected readonly ushort NukeLevel;
        protected readonly ushort NukePower;
        protected readonly string NukeEnchantType;
        protected readonly sbyte WeaponMasteryLevel;
        protected readonly bool NukeElementMatches;
        protected readonly sbyte NukeEnchantPower;

        public EquipmentStats(string nukeType, ushort nukeLevel, ushort nukePower, string nukeEnchantType, sbyte weaponMasteryLevel, bool nukeElementMatches, sbyte nukeEnchantPower,
            ushort characterLevel, ushort characterInt, ushort characterWit, ushort characterMen, uint characterTotalMatk, string characterClass, ushort characterTotalAttribute) 
            : base(characterLevel, characterInt, characterWit, characterMen, characterTotalMatk, characterClass, characterTotalAttribute)
        {
            NukeType = nukeType;
            NukeLevel = nukeLevel;
            NukePower = nukePower;
            NukeEnchantType = nukeEnchantType;
            WeaponMasteryLevel = weaponMasteryLevel;
            NukeElementMatches = nukeElementMatches;
            NukeEnchantPower = nukeEnchantPower;
        }
    }
}
