using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalL2MagicDmgCalculator.Stats
{
    public class EquipmentStats : CharacterStats
    {
        protected readonly uint WeaponMAtk;
        protected readonly bool SigilEquiped;
        protected readonly bool ValakasEquiped;
        protected readonly uint AugmentationBoost;

        public EquipmentStats(uint weaponMAtk, bool sigilEquiped, bool valakasEquiped, uint augmentationBoost,
            ushort characterLevel, ushort characterInt, ushort characterWit, ushort characterMen, uint characterTotalMatk, string characterClass, ushort characterTotalAttribute)
            : base(characterLevel, characterInt, characterWit, characterMen, characterTotalMatk, characterClass, characterTotalAttribute)
        {
            WeaponMAtk = weaponMAtk;
            SigilEquiped = sigilEquiped;
            ValakasEquiped = valakasEquiped;
            AugmentationBoost = augmentationBoost;
        }

        public EquipmentStats(uint weaponMAtk, bool sigilEquiped, bool valakasEquiped, uint augmentationBoost, CharacterStats characterStats) : base (characterStats)
        {
            WeaponMAtk = weaponMAtk;
            SigilEquiped = sigilEquiped;
            ValakasEquiped = valakasEquiped;
            AugmentationBoost = augmentationBoost;
        }


        public EquipmentStats(EquipmentStats equipmentStats, CharacterStats characterStats) : base(characterStats)
        {
            WeaponMAtk = equipmentStats.WeaponMAtk;
            SigilEquiped = equipmentStats.SigilEquiped;
            ValakasEquiped = equipmentStats.ValakasEquiped;
            AugmentationBoost = equipmentStats.AugmentationBoost;
        }

        public EquipmentStats(EquipmentStats equipmentStats)
            : base (equipmentStats)
        {
            WeaponMAtk = equipmentStats.WeaponMAtk;
            SigilEquiped = equipmentStats.SigilEquiped;
            ValakasEquiped = equipmentStats.ValakasEquiped;
            AugmentationBoost = equipmentStats.AugmentationBoost;
        }
    }
}
