using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalL2MagicDmgCalculator.Stats
{
    public class CharacterStats
    {
        protected readonly ushort CharacterLevel;
        protected readonly ushort CharacterInt;
        protected readonly ushort CharacterWit;
        protected readonly ushort CharacterMen;
        protected readonly uint CharacterTotalMatk;
        protected readonly string CharacterClass;
        protected readonly ushort CharacterTotalAttribute;

        public CharacterStats(ushort characterLevel, ushort characterInt, ushort characterWit, ushort characterMen, uint characterTotalMatk, string characterClass, ushort characterTotalAttribute)
        {
            CharacterLevel = characterLevel;
            CharacterInt = characterInt;
            CharacterWit = characterWit;
            CharacterMen = characterMen;
            CharacterTotalMatk = characterTotalMatk;
            CharacterClass = characterClass;
            CharacterTotalAttribute = characterTotalAttribute;
        }

        public CharacterStats(CharacterStats characterStats)
        {
            CharacterLevel = characterStats.CharacterLevel;
            CharacterInt = characterStats.CharacterInt;
            CharacterWit = characterStats.CharacterWit;
            CharacterMen = characterStats.CharacterMen;
            CharacterTotalMatk = characterStats.CharacterTotalMatk;
            CharacterClass = characterStats.CharacterClass;
            CharacterTotalAttribute = characterStats.CharacterTotalAttribute;
        }
    }
}
