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
        //Stats
        private void Strength_Selected(object sender, RoutedEventArgs e)
        {
            //Human_Selected
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

        }

        private void Bard_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Cleric_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Druid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Fighter_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Monk_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Paladin_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Ranger_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void Rogue_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Sorcerer_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Wizard_Selected(object sender, RoutedEventArgs e)
        {

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


        public CharCreation()
        {
            InitializeComponent();
        }

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
        }

        private void HalfElf_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

        }

        private void HalfOrc_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

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
        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

        }
    }
}
