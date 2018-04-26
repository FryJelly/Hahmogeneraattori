using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hahmogeneraattori;

namespace Hahmogeneraattori.Views
{
    /// <summary>
    /// Interaction logic for CharCreation.xaml
    /// </summary>
    public partial class CharCreation : UserControl
    {
        Stats stats = new Stats();
        Stats stats2 = new Stats();
        int RaceStr, RaceDex, RaceCon, RaceInt, RaceWis, RaceCha;
        int StrModifier = 0, DexModifier = 0, ConModifier = 0, IntModifier = 0, WisModifier = 0, ChaModifier = 0;
        int SkillRank = 0;
        bool taken;

        //Adding stat bonuses to human, half-elf or half-orc
        private void Strength_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void Dexterity_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Constitution_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Intelligence_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Wisdom_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Charisma_Selected(object sender, RoutedEventArgs e)
        {

        }
        // Classes
        private void Barbarian_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AcrobaticsCheck.IsChecked = true;
            ClimbCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            KnowNatureRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            HandleAnimalRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Barbarian.Name;
        }

        private void Bard_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AcrobaticsCheck.IsChecked = true;
            AppraiseCheck.IsChecked = true;
            BluffCheck.IsChecked = true;
            ClimbCheck.IsChecked = true;
            DiplomacyCheck.IsChecked = true;
            DisguiseCheck.IsChecked = true;
            EscapeArtistCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowArcanaCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowEngineeringCheck.IsChecked = true;
            KnowGeographyCheck.IsChecked = true;
            KnowHistoryCheck.IsChecked = true;
            KnowLocalCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            KnowNobilityCheck.IsChecked = true;
            KnowPlanesCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            LinguisticsCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            SleightOfHandCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;
            StealthCheck.IsChecked = true;
            UseMagicDeviseCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            SleightOfHandRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowEngineeringRank.Text = SkillRank.ToString();
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowLocalRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowPlanesRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            BluffRank.Text = SkillRank.ToString();
            DiplomacyRank.Text = SkillRank.ToString();
            DisguiseRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();
            UseMagicDeviseRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Bard.Name;
        }

        private void Cleric_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AppraiseCheck.IsChecked = true;
            DiplomacyCheck.IsChecked = true;
            HealCheck.IsChecked = true;
            KnowArcanaCheck.IsChecked = true;
            KnowHistoryCheck.IsChecked = true;
            KnowNobilityCheck.IsChecked = true;
            KnowPlanesCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            LinguisticsCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;

            SkillRank = IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowPlanesRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();
            
            SkillRank = WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            DiplomacyRank.Text = SkillRank.ToString();
            

            // Update character sheet class
            CharacterClass.Content = Cleric.Name;
        }

        private void Druid_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            ClimbCheck.IsChecked = true;
            FlyCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            HealCheck.IsChecked = true;
            KnowGeographyCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            FlyRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            PerceptionRank.Text = SkillRank.ToString();
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            HandleAnimalRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Druid.Name;
        }

        private void Fighter_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            ClimbCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowEngineeringCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            RideRank.Text = SkillRank.ToString();
            
            SkillRank = IntModifier + 3;
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowEngineeringRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            SurvivalRank.Text = SkillRank.ToString();
            
            SkillRank = ChaModifier + 3;
            HandleAnimalRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Fighter.Name;
        }

        private void Monk_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AcrobaticsCheck.IsChecked = true;
            ClimbCheck.IsChecked = true;
            EscapeArtistCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowHistoryCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            StealthCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            EscapeArtistRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            IntimidateRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Monk.Name;
        }

        private void Paladin_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            DiplomacyCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            HealCheck.IsChecked = true;
            KnowNobilityCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;

            SkillRank = DexModifier + 3;
            RideRank.Text = SkillRank.ToString();
            
            SkillRank = IntModifier + 3;
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            DiplomacyRank.Text = SkillRank.ToString();
            HandleAnimalRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Paladin.Name;
        }

        private void Ranger_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            ClimbCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            HealCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowGeographyCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;
            StealthCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            RideRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            PerceptionRank.Text = SkillRank.ToString();
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            HandleAnimalRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();


            // Update character sheet class
            CharacterClass.Content = Rogue.Name;

        }
        private void Rogue_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AcrobaticsCheck.IsChecked = true;
            AppraiseCheck.IsChecked = true;
            BluffCheck.IsChecked = true;
            ClimbCheck.IsChecked = true;
            DiplomacyCheck.IsChecked = true;
            DisableDeviceCheck.IsChecked = true;
            DisguiseCheck.IsChecked = true;
            EscapeArtistCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowLocalCheck.IsChecked = true;
            LinguisticsCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            SleightOfHandCheck.IsChecked = true;
            StealthCheck.IsChecked = true;
            SwimCheck.IsChecked = true;
            UseMagicDeviseCheck.IsChecked = true;

            SkillRank = StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            EscapeArtistRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowLocalRank.Text = SkillRank.ToString();

            SkillRank = WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            BluffRank.Text = SkillRank.ToString();
            DiplomacyRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();
            UseMagicDeviseRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Rogue.Name;
        }

        private void Sorcerer_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AppraiseCheck.IsChecked = true;
            BluffCheck.IsChecked = true;
            FlyCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowArcanaCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;
            UseMagicDeviseCheck.IsChecked = true;

            SkillRank = IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = ChaModifier + 3;
            BluffRank.Text = SkillRank.ToString();
            UseMagicDeviseRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            FlyRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Sorcerer.Name;
        }

        private void Wizard_Selected(object sender, RoutedEventArgs e)
        {
            ClearSkills();

            AppraiseCheck.IsChecked = true;
            FlyCheck.IsChecked = true;
            KnowArcanaCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowEngineeringCheck.IsChecked = true;
            KnowGeographyCheck.IsChecked = true;
            KnowHistoryCheck.IsChecked = true;
            KnowLocalCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            KnowNobilityCheck.IsChecked = true;
            KnowPlanesCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            LinguisticsCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;

            SkillRank = IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowEngineeringRank.Text = SkillRank.ToString();
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowLocalRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowPlanesRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = DexModifier + 3;
            FlyRank.Text = SkillRank.ToString();

            // Update character sheet class
            CharacterClass.Content = Wizard.Name;
        }
        // Character Sheet

        private void CharacterName_Selected(object sender, RoutedEventArgs e)
        {
            // Input box for char name
            InputBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // YesButton Clicked! Let's hide our InputBox and handle the input text.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Do something with the Input
            string input = InputTextBox.Text;
            CharacterName.Content = input;

            // Clear InputBox.
            InputTextBox.Text = String.Empty;
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            // NoButton Clicked! Let's hide our InputBox.
            InputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Clear InputBox.
            InputTextBox.Text = String.Empty;
        }

        private void AcrobaticsBox_Selected(object sender, RoutedEventArgs e)
        {
            if(AcrobaticsCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                AcrobaticsRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                AcrobaticsRank.Text = SkillRank.ToString();
            }
        }

        private void AppraiseBox_Selected(object sender, RoutedEventArgs e)
        {
            if (AppraiseCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                AppraiseRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                AppraiseRank.Text = SkillRank.ToString();
            }
        }

        private void BluffBox_Selected(object sender, RoutedEventArgs e)
        {
            if (BluffCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                BluffRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                BluffRank.Text = SkillRank.ToString();
            }
        }

        private void ClimbBox_Selected(object sender, RoutedEventArgs e)
        {
            if (ClimbCheck.IsChecked == true)
            {
                SkillRank = StrModifier + 4;
                ClimbRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = StrModifier + 1;
                ClimbRank.Text = SkillRank.ToString();
            }
        }

        private void DiplomacyBox_Selected(object sender, RoutedEventArgs e)
        {
            if (DiplomacyCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                DiplomacyRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                DiplomacyRank.Text = SkillRank.ToString();
            }
        }

        private void DisableDeviceBox_Selected(object sender, RoutedEventArgs e)
        {
            if (DisableDeviceCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                DisableDeviceRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                DisableDeviceRank.Text = SkillRank.ToString();
            }
        }

        private void DisguiseBox_Selected(object sender, RoutedEventArgs e)
        {
            if (DisguiseCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                DisguiseRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                DisguiseRank.Text = SkillRank.ToString();
            }
        }

        private void EscapeArtistBox_Selected(object sender, RoutedEventArgs e)
        {
            if (EscapeArtistCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                EscapeArtistRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                EscapeArtistRank.Text = SkillRank.ToString();
            }
        }

        private void FlyBox_Selected(object sender, RoutedEventArgs e)
        {
            if (FlyCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                FlyRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                FlyRank.Text = SkillRank.ToString();
            }
        }

        private void HandleAnimalBox_Selected(object sender, RoutedEventArgs e)
        {
            if (HandleAnimalCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                HandleAnimalRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                HandleAnimalRank.Text = SkillRank.ToString();
            }
        }

        private void HealBox_Selected(object sender, RoutedEventArgs e)
        {
            if (HealCheck.IsChecked == true)
            {
                SkillRank = WisModifier + 4;
                HealRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = WisModifier + 1;
                HealRank.Text = SkillRank.ToString();
            }
        }

        private void IntimidateBox_Selected(object sender, RoutedEventArgs e)
        {
            if (IntimidateCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                IntimidateRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                IntimidateRank.Text = SkillRank.ToString();
            }
        }

        private void KnowArcanaBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowArcanaCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowArcanaRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowArcanaRank.Text = SkillRank.ToString();
            }
        }

        private void KnowDungeoneeringBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowDungeoneeringCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowDungeoneeringRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowDungeoneeringRank.Text = SkillRank.ToString();
            }
        }

        private void KnowEngineeringBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowEngineeringCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowEngineeringRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowEngineeringRank.Text = SkillRank.ToString();
            }
        }

        private void KnowGeographyBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowGeographyCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowGeographyRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowGeographyRank.Text = SkillRank.ToString();
            }
        }

        private void KnowHistoryBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowHistoryCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowHistoryRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowHistoryRank.Text = SkillRank.ToString();
            }
        }

        private void KnowLocalBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowLocalCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowLocalRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowLocalRank.Text = SkillRank.ToString();
            }
        }

        private void KnowNatureBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowNatureCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowNatureRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowNatureRank.Text = SkillRank.ToString();
            }
        }

        private void KnowNobilityBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowNobilityCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowNobilityRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowNobilityRank.Text = SkillRank.ToString();
            }
        }

        private void KnowPlanesBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowPlanesCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowPlanesRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowPlanesRank.Text = SkillRank.ToString();
            }
        }

        private void KnowReligionBox_Selected(object sender, RoutedEventArgs e)
        {
            if (KnowReligionCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                KnowReligionRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                KnowReligionRank.Text = SkillRank.ToString();
            }
        }

        private void LinguisticsBox_Selected(object sender, RoutedEventArgs e)
        {
            if (LinguisticsCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                LinguisticsRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                LinguisticsRank.Text = SkillRank.ToString();
            }
        }

        private void PerceptionBox_Selected(object sender, RoutedEventArgs e)
        {
            if (PerceptionCheck.IsChecked == true)
            {
                SkillRank = WisModifier + 4;
                PerceptionRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = WisModifier + 1;
                PerceptionRank.Text = SkillRank.ToString();
            }
        }

        private void RideBox_Selected(object sender, RoutedEventArgs e)
        {
            if (RideCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                RideRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                RideRank.Text = SkillRank.ToString();
            }
        }

        private void SenseMotiveBox_Selected(object sender, RoutedEventArgs e)
        {
            if (SenseMotiveCheck.IsChecked == true)
            {
                SkillRank = WisModifier + 4;
                SenseMotiveRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = WisModifier + 1;
                SenseMotiveRank.Text = SkillRank.ToString();
            }
        }

        private void SleightOfHandBox_Selected(object sender, RoutedEventArgs e)
        {
            if (SleightOfHandCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                SleightOfHandRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                SleightOfHandRank.Text = SkillRank.ToString();
            }
        }

        private void SpellcraftBox_Selected(object sender, RoutedEventArgs e)
        {
            if (SpellcraftCheck.IsChecked == true)
            {
                SkillRank = IntModifier + 4;
                SpellcraftRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = IntModifier + 1;
                SpellcraftRank.Text = SkillRank.ToString();
            }
        }

        private void StealthBox_Selected(object sender, RoutedEventArgs e)
        {
            if (StealthCheck.IsChecked == true)
            {
                SkillRank = DexModifier + 4;
                StealthRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = DexModifier + 1;
                StealthRank.Text = SkillRank.ToString();
            }
        }

        private void SurvivalBox_Selected(object sender, RoutedEventArgs e)
        {
            if (SurvivalCheck.IsChecked == true)
            {
                SkillRank = WisModifier + 4;
                SurvivalRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = WisModifier + 1;
                SurvivalRank.Text = SkillRank.ToString();
            }
        }

        private void SwimBox_Selected(object sender, RoutedEventArgs e)
        {
            if (SwimCheck.IsChecked == true)
            {
                SkillRank = StrModifier + 4;
                SwimRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = StrModifier + 1;
                SwimRank.Text = SkillRank.ToString();
            }
        }

        private void UseMagicDeviseBox_Selected(object sender, RoutedEventArgs e)
        {
            if (UseMagicDeviseCheck.IsChecked == true)
            {
                SkillRank = ChaModifier + 4;
                UseMagicDeviseRank.Text = SkillRank.ToString();
            }

            else
            {
                SkillRank = ChaModifier + 1;
                UseMagicDeviseRank.Text = SkillRank.ToString();
            }
        }

        private void CloseApplicationButton_Click(object sender, RoutedEventArgs e)
        {
            // Close Application button clicked -> show confirmation box
            CloseApplicationBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void CloseApplicationYesButton_Click(object sender, RoutedEventArgs e)
        {
            // Yes clicked - close application
            System.Windows.Application.Current.Shutdown();
        }

        private void CloseApplicationNoButton_Click(object sender, RoutedEventArgs e)
        {
            // No clicked, close confirmation box
            CloseApplicationBox.Visibility = System.Windows.Visibility.Collapsed;
        }
        public CharCreation()
        {
            InitializeComponent();
        }

        //Rolls stats and modifiers
        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            stats = Stats.RollStats();
            stats2 = stats;

            StrScore.Text = stats.Str.ToString();
            DexScore.Text = stats.Dex.ToString();
            ConScore.Text = stats.Con.ToString();
            IntScore.Text = stats.Int.ToString();
            WisScore.Text = stats.Wis.ToString();
            ChaScore.Text = stats.Cha.ToString();

            StrModifier = stats.Str / 2 - 5;
            DexModifier = stats.Dex / 2 - 5;
            ConModifier = stats.Con / 2 - 5;
            IntModifier = stats.Int / 2 - 5;
            WisModifier = stats.Wis / 2 - 5;
            ChaModifier = stats.Cha / 2 - 5;

            StrMod.Text = StrModifier.ToString();
            DexMod.Text = DexModifier.ToString();
            ConMod.Text = ConModifier.ToString();
            IntMod.Text = IntModifier.ToString();
            WisMod.Text = WisModifier.ToString();
            ChaMod.Text = ChaModifier.ToString();

            //update stats to char sheet
            CharacterStrength.Content = stats.Str;
            CharacterDexterity.Content = stats.Dex;
            CharacterConstitution.Content = stats.Con;
            CharacterIntelligence.Content = stats.Int;
            CharacterWisdom.Content = stats.Wis;
            CharacterCharisma.Content = stats.Cha;
            // update char sheet modifiers
            CharStrMod.Content = StrMod.Text;
            CharDexMod.Content = DexMod.Text;
            CharConMod.Content = ConMod.Text;
            CharIntMod.Content = IntMod.Text;
            CharWisMod.Content = WisMod.Text;
            CharChaMod.Content = ChaMod.Text;
        }

        private void ListBox_SelectionChanged()
        {

        }
        // Races
        private void Dwarf_Selected(object sender, RoutedEventArgs e)
        {
            stats = stats2;

            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con + 2;
            RaceInt = stats.Int;
            RaceWis = stats.Wis + 2;
            RaceCha = stats.Cha - 2;

            StrScore.Text = RaceStr.ToString();
            DexScore.Text = RaceDex.ToString();
            ConScore.Text = RaceCon.ToString();
            IntScore.Text = RaceInt.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Dwarf.Name;

            UpdateCharSheet();
        }

        private void Elf_Selected(object sender, RoutedEventArgs e)
        {
            stats = stats2;

            RaceStr = stats.Str;
            RaceDex = stats.Dex + 2;
            RaceCon = stats.Con - 2;
            RaceInt = stats.Int + 2;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;
            
            StrScore.Text = RaceStr.ToString();
            DexScore.Text = RaceDex.ToString();
            ConScore.Text = RaceCon.ToString();
            IntScore.Text = RaceInt.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Elf.Name;

            UpdateCharSheet();
        }

        private void Gnome_Selected(object sender, RoutedEventArgs e)
        {
            stats = stats2;

            RaceStr = stats.Str - 2;
            RaceDex = stats.Dex;
            RaceCon = stats.Con + 2;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha + 2;
            
            StrScore.Text = RaceStr.ToString();
            DexScore.Text = RaceDex.ToString();
            ConScore.Text = RaceCon.ToString();
            IntScore.Text = RaceInt.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Gnome.Name;

            UpdateCharSheet();
        }

        private void HalfElf_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = HalfElf.Name;

            UpdateCharSheet();
        }

        private void HalfOrc_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = HalfOrc.Name;

            UpdateCharSheet();
        }

        private void Halfling_Selected(object sender, RoutedEventArgs e)
        {
            stats = stats2;

            RaceStr = stats.Str - 2;
            RaceDex = stats.Dex + 2;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha + 2;
            
            StrScore.Text = RaceStr.ToString();
            DexScore.Text = RaceDex.ToString();
            ConScore.Text = RaceCon.ToString();
            IntScore.Text = RaceInt.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Halfling.Name;

            UpdateCharSheet();
        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = Human.Name;

            UpdateCharSheet();
        }
        public void ClearSkills ()
        {
            AcrobaticsCheck.IsChecked = false;
            AppraiseCheck.IsChecked = false;
            BluffCheck.IsChecked = false;
            ClimbCheck.IsChecked = false;
            DiplomacyCheck.IsChecked = false;
            DisableDeviceCheck.IsChecked = false;
            DisguiseCheck.IsChecked = false;
            EscapeArtistCheck.IsChecked = false;
            FlyCheck.IsChecked = false;
            HandleAnimalCheck.IsChecked = false;
            HealCheck.IsChecked = false;
            IntimidateCheck.IsChecked = false;
            KnowArcanaCheck.IsChecked = false;
            KnowDungeoneeringCheck.IsChecked = false;
            KnowEngineeringCheck.IsChecked = false;
            KnowGeographyCheck.IsChecked = false;
            KnowHistoryCheck.IsChecked = false;
            KnowLocalCheck.IsChecked = false;
            KnowNatureCheck.IsChecked = false;
            KnowNobilityCheck.IsChecked = false;
            KnowPlanesCheck.IsChecked = false;
            KnowReligionCheck.IsChecked = false;
            LinguisticsCheck.IsChecked = false;
            PerceptionCheck.IsChecked = false;
            RideCheck.IsChecked = false;
            SenseMotiveCheck.IsChecked = false;
            SleightOfHandCheck.IsChecked = false;
            SpellcraftCheck.IsChecked = false;
            StealthCheck.IsChecked = false;
            SurvivalCheck.IsChecked = false;
            SwimCheck.IsChecked = false;
            UseMagicDeviseCheck.IsChecked = false;

            AcrobaticsRank.Text = "0";
            AppraiseRank.Text = "0";
            BluffRank.Text = "0";
            ClimbRank.Text = "0";
            DiplomacyRank.Text = "0";
            DisableDeviceRank.Text = "0";
            DisguiseRank.Text = "0";
            EscapeArtistRank.Text = "0";
            FlyRank.Text = "0";
            HandleAnimalRank.Text = "0";
            HealRank.Text = "0";
            IntimidateRank.Text = "0";
            KnowArcanaRank.Text = "0";
            KnowDungeoneeringRank.Text = "0";
            KnowEngineeringRank.Text = "0";
            KnowGeographyRank.Text = "0";
            KnowHistoryRank.Text = "0";
            KnowLocalRank.Text = "0";
            KnowNatureRank.Text = "0";
            KnowNobilityRank.Text = "0";
            KnowPlanesRank.Text = "0";
            KnowReligionRank.Text = "0";
            LinguisticsRank.Text = "0";
            PerceptionRank.Text = "0";
            RideRank.Text = "0";
            SenseMotiveRank.Text = "0";
            SleightOfHandRank.Text = "0";
            SpellcraftRank.Text = "0";
            StealthRank.Text = "0";
            SurvivalRank.Text = "0";
            SwimRank.Text = "0";
            UseMagicDeviseRank.Text = "0";
        }

        public void AssignModifiers ()
        {
            StrModifier = RaceStr / 2 - 5;
            DexModifier = RaceDex / 2 - 5;
            ConModifier = RaceCon / 2 - 5;
            IntModifier = RaceInt / 2 - 5;
            WisModifier = RaceWis / 2 - 5;
            ChaModifier = RaceCha / 2 - 5;


            StrMod.Text = StrModifier.ToString();
            DexMod.Text = DexModifier.ToString();
            ConMod.Text = ConModifier.ToString();
            IntMod.Text = IntModifier.ToString();
            WisMod.Text = WisModifier.ToString();
            ChaMod.Text = ChaModifier.ToString();
        }

        public void UpdateCharSheet()
        {
            //update stats to char sheet
            CharacterStrength.Content = RaceStr;
            CharacterDexterity.Content = RaceDex;
            CharacterConstitution.Content = RaceCon;
            CharacterIntelligence.Content = RaceInt;
            CharacterWisdom.Content = RaceWis;
            CharacterCharisma.Content = RaceCha;
            // update char sheet modifiers
            CharStrMod.Content = StrMod.Text;
            CharDexMod.Content = DexMod.Text;
            CharConMod.Content = ConMod.Text;
            CharIntMod.Content = IntMod.Text;
            CharWisMod.Content = WisMod.Text;
            CharChaMod.Content = ChaMod.Text;
        }
    }
}
