﻿using System;
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
using System.IO;

namespace Hahmogeneraattori.Views
{
    /// <summary>
    /// Interaction logic for CharCreation.xaml
    /// </summary>
    public partial class CharCreation : UserControl
    {
        
        Stats stats = new Stats();
        int RaceStr, RaceDex, RaceCon, RaceInt, RaceWis, RaceCha;
        int str;
        int SkillRank = 0;

        //Rolls stats and modifiers
        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            stats = Stats.RollStats();

            str = stats.Str;
            StrScore.Text = stats.Str.ToString();
            DexScore.Text = stats.Dex.ToString();
            ConScore.Text = stats.Con.ToString();
            IntScore.Text = stats.Int.ToString();
            WisScore.Text = stats.Wis.ToString();
            ChaScore.Text = stats.Cha.ToString();

            StrMod.Text = stats.StrModifier.ToString();
            DexMod.Text = stats.DexModifier.ToString();
            ConMod.Text = stats.ConModifier.ToString();
            IntMod.Text = stats.IntModifier.ToString();
            WisMod.Text = stats.WisModifier.ToString();
            ChaMod.Text = stats.ChaModifier.ToString();

            
        }

        // Races
        private void Dwarf_Selected(object sender, RoutedEventArgs e)
        {
            
            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con + 2;
            RaceInt = stats.Int;
            RaceWis = stats.Wis + 2;
            RaceCha = stats.Cha - 2;

            AssignStats();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Dwarf.Name;

        }

        
        private void Elf_Selected(object sender, RoutedEventArgs e)
        {
            
            RaceStr = stats.Str;
            RaceDex = stats.Dex + 2;
            RaceCon = stats.Con - 2;
            RaceInt = stats.Int + 2;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Elf.Name;

        }

        private void Gnome_Selected(object sender, RoutedEventArgs e)
        {

            RaceStr = stats.Str - 2;
            RaceDex = stats.Dex;
            RaceCon = stats.Con + 2;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha + 2;

            AssignStats();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Gnome.Name;

        }

        private void HalfElf_Selected(object sender, RoutedEventArgs e)
        {
            
            // Update character sheet race
            CharacterRace.Content = HalfElf.Name;

        }

        private void HalfOrc_Selected(object sender, RoutedEventArgs e)
        {
            
            // Update character sheet race
            CharacterRace.Content = HalfOrc.Name;

        }

        private void Halfling_Selected(object sender, RoutedEventArgs e)
        {
            
            RaceStr = stats.Str - 2;
            RaceDex = stats.Dex + 2;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha + 2;

            AssignStats();

            AssignModifiers();

            // Update character sheet race
            CharacterRace.Content = Halfling.Name;

        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            
            // Update character sheet race
            CharacterRace.Content = Human.Name;

        }

        //Adding stat bonuses to human, half-elf or half-orc
        private void Strength_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str + 2;
            RaceDex = stats.Dex;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();
        }

        private void Dexterity_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str;
            RaceDex = stats.Dex + 2;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();
        }

        private void Constitution_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con + 2;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();
        }

        private void Intelligence_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con;
            RaceInt = stats.Int + 2;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();
        }

        private void Wisdom_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis + 2;
            RaceCha = stats.Cha;

            AssignStats();

            AssignModifiers();
        }

        private void Charisma_Selected(object sender, RoutedEventArgs e)
        {
            RaceStr = stats.Str;
            RaceDex = stats.Dex;
            RaceCon = stats.Con;
            RaceInt = stats.Int;
            RaceWis = stats.Wis;
            RaceCha = stats.Cha + 2;

            AssignStats();

            AssignModifiers();
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowNatureRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            SleightOfHandRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
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

            SkillRank = stats.WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowPlanesRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            FlyRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            PerceptionRank.Text = SkillRank.ToString();
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            RideRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowEngineeringRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            EscapeArtistRank.Text = SkillRank.ToString();
            RideRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowHistoryRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.DexModifier + 3;
            RideRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowNobilityRank.Text = SkillRank.ToString();
            KnowReligionRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            RideRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowGeographyRank.Text = SkillRank.ToString();
            KnowNatureRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            HealRank.Text = SkillRank.ToString();
            PerceptionRank.Text = SkillRank.ToString();
            SurvivalRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
            HandleAnimalRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();


            // Update character sheet class
            CharacterClass.Content = Ranger.Name;

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

            SkillRank = stats.StrModifier + 3;
            ClimbRank.Text = SkillRank.ToString();
            SwimRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
            AcrobaticsRank.Text = SkillRank.ToString();
            EscapeArtistRank.Text = SkillRank.ToString();
            StealthRank.Text = SkillRank.ToString();

            SkillRank = stats.IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            LinguisticsRank.Text = SkillRank.ToString();
            KnowDungeoneeringRank.Text = SkillRank.ToString();
            KnowLocalRank.Text = SkillRank.ToString();

            SkillRank = stats.WisModifier + 3;
            PerceptionRank.Text = SkillRank.ToString();
            SenseMotiveRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
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

            SkillRank = stats.IntModifier + 3;
            AppraiseRank.Text = SkillRank.ToString();
            KnowArcanaRank.Text = SkillRank.ToString();
            SpellcraftRank.Text = SkillRank.ToString();

            SkillRank = stats.ChaModifier + 3;
            BluffRank.Text = SkillRank.ToString();
            UseMagicDeviseRank.Text = SkillRank.ToString();
            IntimidateRank.Text = SkillRank.ToString();

            SkillRank = stats.DexModifier + 3;
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

            SkillRank = stats.IntModifier + 3;
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

            SkillRank = stats.DexModifier + 3;
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



        private void ListBox_SelectionChanged()
        {

        }

        public void ClearSkills()
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

        public void AssignModifiers()
        {
            stats.StrModifier = RaceStr / 2 - 5;
            stats.DexModifier = RaceDex / 2 - 5;
            stats.ConModifier = RaceCon / 2 - 5;
            stats.IntModifier = RaceInt / 2 - 5;
            stats.WisModifier = RaceWis / 2 - 5;
            stats.ChaModifier = RaceCha / 2 - 5;


            StrMod.Text = stats.StrModifier.ToString();
            DexMod.Text = stats.DexModifier.ToString();
            ConMod.Text = stats.ConModifier.ToString();
            IntMod.Text = stats.IntModifier.ToString();
            WisMod.Text = stats.WisModifier.ToString();
            ChaMod.Text = stats.ChaModifier.ToString();
        }

        public void AssignStats()
        {
            StrScore.Text = RaceStr.ToString();
            DexScore.Text = RaceDex.ToString();
            ConScore.Text = RaceCon.ToString();
            IntScore.Text = RaceInt.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();
        }

        
        private void SaveToFileButton_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        public void SaveToFile()
        {
            string path = @"char.txt";
            string filetext = CharacterName.Content.ToString() + "," + CharacterRace.Content.ToString()  + "," + CharacterClass.Content.ToString()
                + "," + CharacterStrength.Content.ToString() + "," + CharacterDexterity.Content.ToString() + "," + CharacterConstitution.Content.ToString() + "," + CharacterIntelligence.Content.ToString()
                 + "," + CharacterWisdom.Content.ToString() + "," + CharacterCharisma.Content.ToString();
            File.WriteAllText(path, filetext);
            string showtext = "Character has been saved!";
            MessageBox.Show(showtext);
        }

    }
}
