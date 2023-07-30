using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OriginalL2MagicDmgCalculator.Stats;

namespace OriginalL2MagicDmgCalculator
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Does whatever testing needs it to do
        /// </summary>
        /// <param name="sender">
        /// Sending object
        /// </param>
        /// <param name="e">
        /// Event's argument
        /// </param>
        private async void TEST_BUTTON_Click(object sender, EventArgs e)
        {
             // This works nicely, spaces are not actually part of the string- except for null, that's still a problem
            string test = LEVEL_MTEXTBOX.Text;
            Trace.WriteLine("Recognized length: " + test.Length);

            int content = Convert.ToInt32(LEVEL_MTEXTBOX.Text);
            Trace.WriteLine("Content: " + content);

            int contentBy2 = content / 2;
            Trace.WriteLine("Content by 2: " + contentBy2);
        }

        private async void SAVE_TO_BASE_BUTTON_Click(object sender, EventArgs e)
        {

        }

        private async Task<BuffStats> CollectDataFromUser()
        {
           return await Task.Run(async () =>
           {
               CharacterStats characterStats = CollectCharacterStats();
               EquipmentStats equipmentStats = CollectEquipmentStats(ref characterStats);
               SkillStats skillStats = CollectSkillsStats(ref equipmentStats);
               return CollectBuffStats(ref skillStats);
           });
        }

        /// <summary>
        /// Collects base character stats and encapsulates them to an object
        /// </summary>
        /// <throws>Fuck it, it will just throw exception if something goes wrong</throws>
        /// <returns>
        /// Character base stats
        /// </returns>
        private CharacterStats CollectCharacterStats()
        {
            // We could call not awaited background convertion check with cancellation token maybe?
            ushort characterLevel, characterInt, characterWit, characterMen, characterTotalAttribute;
            uint characterTotalMAtk;
            string characterClass;

            // We could make another function that accepts array and checks for null in it, but that would require additional memory for the array, so maybe this is better overall
            characterLevel = ushort.Parse(LEVEL_MTEXTBOX.Text);
            characterInt = ushort.Parse(INT_MTEXTBOX.Text);
            characterWit = ushort.Parse(WIT_MTEXTBOX.Text);
            characterMen = ushort.Parse(MEN_MTEXTBOX.Text);
            characterTotalAttribute = ushort.Parse(ATTRIBUTE_MTEXTBOX.Text);
            characterTotalMAtk = uint.Parse(MATK_MTEXTBOX.Text);
            characterClass = CLASS_TEXTBOX.Text;

            return new CharacterStats(characterLevel, characterInt, characterWit, characterMen, characterTotalMAtk, characterClass, characterTotalAttribute);
        }

        private EquipmentStats CollectEquipmentStats(ref CharacterStats characterStats)
        {
            uint weaponMatk, augmentationBoost;
            bool sigilEquiped, valakasEquiped;

            weaponMatk = uint.Parse(WEAPON_MASTERY_LV_MTEXTBOX.Text);
            augmentationBoost = uint.Parse(AUGMENTATION_BOOST_MTEXTBOX.Text);
            sigilEquiped = SIGIL_EQUIPED_CHECKBOX.Checked;
            valakasEquiped = VALAKAS_EQUIPED_CHECKBOX.Checked;

            return new EquipmentStats(weaponMatk, sigilEquiped, valakasEquiped, augmentationBoost, characterStats);
        }

        private SkillStats CollectSkillsStats(ref EquipmentStats equipmentStats)
        {
            string nukeType, nukeEnchantType;
            ushort nukeLevel, nukePower;
            sbyte weaponMasteryLevel, nukeEnchantPower;
            bool nukeElementMatches;

            nukeType = NUKTE_TYPE_TEXTBOX.Text;
            nukeLevel = ushort.Parse(NUKE_LEVEL_MTEXTBOX.Text);
            nukePower = ushort.Parse(NUKE_POWER_MTEXTBOX.Text);
            nukeEnchantType = NUKE_ENCHANT_TYPE_TEXTBOX.Text;
            weaponMasteryLevel = sbyte.Parse(WEAPON_MASTERY_LV_MTEXTBOX.Text);
            nukeElementMatches = NUKE_ELE_ALIGN_CHECKBOX.Checked;
            nukeEnchantPower = sbyte.Parse(NUKE_ENCHANT_POWER_MTEXTBOX.Text);

            return new SkillStats(nukeType, nukeLevel, nukePower, nukeEnchantType, weaponMasteryLevel, nukeElementMatches, nukeEnchantPower, equipmentStats);
        }

        private BuffStats CollectBuffStats(ref SkillStats skillStats)
        {
            string buffFullName1, buffFullName2, buffFullName3, buffFullName4, buffFullName5, buffFullName6;
            ushort buffMAtkBoost1, buffMAtkBoost2, buffMAtkBoost3, buffMAtkBoost4, buffMAtkBoost5, buffMAtkBoost6;
            uint HeroicBerserkerMAtkBoost;

            buffFullName1 = BUFF_NAME_LABEL1.Text;
            buffFullName2 = BUFF_NAME_LABEL2.Text;
            buffFullName3 = BUFF_NAME_LABEL3.Text;
            buffFullName4 = BUFF_NAME_LABEL4.Text;
            buffFullName5 = BUFF_NAME_LABEL5.Text;
            buffFullName6 = BUFF_NAME_LABEL6.Text;

            buffMAtkBoost1 = ushort.Parse(BUFF_POWER_LABEL1.Text);
            buffMAtkBoost2 = ushort.Parse(BUFF_POWER_LABEL2.Text);
            buffMAtkBoost3 = ushort.Parse(BUFF_POWER_LABEL3.Text);
            buffMAtkBoost4 = ushort.Parse(BUFF_POWER_LABEL4.Text);
            buffMAtkBoost5 = ushort.Parse(BUFF_POWER_LABEL5.Text);
            buffMAtkBoost6 = ushort.Parse(BUFF_POWER_LABEL6.Text);
            HeroicBerserkerMAtkBoost = uint.Parse(HERO_BERS_MTEXTBOX.Text);

            return new BuffStats(buffFullName1, buffFullName2, buffFullName3, buffFullName4, buffFullName5, buffFullName6, buffMAtkBoost1, buffMAtkBoost2, buffMAtkBoost3, buffMAtkBoost4, buffMAtkBoost5, buffMAtkBoost6, HeroicBerserkerMAtkBoost, skillStats);
        }
    }
}
