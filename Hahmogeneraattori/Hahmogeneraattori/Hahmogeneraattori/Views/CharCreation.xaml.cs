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
        int StrModifier, DexModifier, ConModifier, IntModifier, WisModifier, ChaModifier;
        int SkillRank;

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

            AcrobaticsCheck.IsChecked = true;
            ClimbCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowNatureCheck.IsChecked = true;
            PerceptionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;

            // Update character sheet class
            CharacterClass.Content = Barbarian.Name;
        }

        private void Bard_Selected(object sender, RoutedEventArgs e)
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
            // Update character sheet class
            CharacterClass.Content = Bard.Name;
        }

        private void Cleric_Selected(object sender, RoutedEventArgs e)
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

            // Update character sheet class
            CharacterClass.Content = Cleric.Name;
        }

        private void Druid_Selected(object sender, RoutedEventArgs e)
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

            // Update character sheet class
            CharacterClass.Content = Druid.Name;
        }

        private void Fighter_Selected(object sender, RoutedEventArgs e)
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

            ClimbCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowDungeoneeringCheck.IsChecked = true;
            KnowEngineeringCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SurvivalCheck.IsChecked = true;
            SwimCheck.IsChecked = true;
            // Update character sheet class
            CharacterClass.Content = Fighter.Name;
        }

        private void Monk_Selected(object sender, RoutedEventArgs e)
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

            // Update character sheet class
            CharacterClass.Content = Monk.Name;
        }

        private void Paladin_Selected(object sender, RoutedEventArgs e)
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

            DiplomacyCheck.IsChecked = true;
            HandleAnimalCheck.IsChecked = true;
            HealCheck.IsChecked = true;
            KnowNobilityCheck.IsChecked = true;
            KnowReligionCheck.IsChecked = true;
            RideCheck.IsChecked = true;
            SenseMotiveCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;

            // Update character sheet class
            CharacterClass.Content = Paladin.Name;
        }

        private void Ranger_Selected(object sender, RoutedEventArgs e)
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
            // Update character sheet class
            CharacterClass.Content = Rogue.Name;

        }
        private void Rogue_Selected(object sender, RoutedEventArgs e)
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
            // Update character sheet class
            CharacterClass.Content = Rogue.Name;
        }

        private void Sorcerer_Selected(object sender, RoutedEventArgs e)
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

            AppraiseCheck.IsChecked = true;
            BluffCheck.IsChecked = true;
            FlyCheck.IsChecked = true;
            IntimidateCheck.IsChecked = true;
            KnowArcanaCheck.IsChecked = true;
            SpellcraftCheck.IsChecked = true;
            UseMagicDeviseCheck.IsChecked = true;
            // Update character sheet class
            CharacterClass.Content = Sorcerer.Name;
        }

        private void Wizard_Selected(object sender, RoutedEventArgs e)
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
            // Update character sheet class
            CharacterClass.Content = Wizard.Name;
        }
        // Character Sheet

        private void CharacterName_Selected(object sender, RoutedEventArgs e)
        {
            // Input box for char name
            NameInputBox.Visibility = System.Windows.Visibility.Visible;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // YesButton Clicked! Let's hide our InputBox and handle the input text.
            NameInputBox.Visibility = System.Windows.Visibility.Collapsed;

            // Do something with the Input
            string input = InputTextBox.Text;
            CharacterName.Content = input;

            // Clear InputBox.
            InputTextBox.Text = String.Empty;
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            // NoButton Clicked! Let's hide our InputBox.
            NameInputBox.Visibility = System.Windows.Visibility.Collapsed;

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

            // Update character sheet race
            CharacterRace.Content = Dwarf.Name;
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

            // Update character sheet race
            CharacterRace.Content = Elf.Name;
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

            // Update character sheet race
            CharacterRace.Content = Gnome.Name;
        }

        private void HalfElf_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = HalfElf.Name;
        }

        private void HalfOrc_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = HalfOrc.Name;
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

            // Update character sheet race
            CharacterRace.Content = Halfling.Name;
        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

            // Update character sheet race
            CharacterRace.Content = Human.Name;
        }
    }
}
