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
        public CharCreation()
        {
            InitializeComponent();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            stats = Stats.RollStats();
            ScoreList.DataContext = stats;
            stats2 = stats;
            StrScore.Text = stats.Str.ToString();
            DexScore.Text = stats.Dex.ToString();
            ConScore.Text = stats.Con.ToString();
            IntScore.Text = stats.Int.ToString();
            WisScore.Text = stats.Wis.ToString();
            ChaScore.Text = stats.Cha.ToString();


        }

        private void ListBox_SelectionChanged()
        {

        }

        private void Dwarf_Selected(object sender, RoutedEventArgs e)
        {
            RaceCon = stats.Con + 2;
            RaceWis = stats.Wis + 2;
            RaceCha = stats.Cha - 2;

            ConScore.Text = RaceCon.ToString();
            WisScore.Text = RaceWis.ToString();
            ChaScore.Text = RaceCha.ToString();
        }

        private void Elf_Selected(object sender, RoutedEventArgs e)
        {
            RaceDex = stats.Dex + 2;
            RaceInt = stats.Int + 2;
            RaceCon = stats.Con - 2;

            DexScore.Text = RaceDex.ToString();
            IntScore.Text = RaceInt.ToString();
            ConScore.Text = RaceCon.ToString();

        }

        private void Gnome_Selected(object sender, RoutedEventArgs e)
        {
            RaceCon = stats.Con + 2;
            RaceCha = stats.Cha + 2;
            RaceStr = stats.Str - 2;

            ConScore.Text = RaceCon.ToString();
            ChaScore.Text = RaceCha.ToString();
            StrScore.Text = RaceStr.ToString();

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
            RaceDex = stats.Dex + 2;
            RaceCha = stats.Cha + 2;
            RaceStr = stats.Str - 2;

            DexScore.Text = RaceDex.ToString();
            ChaScore.Text = RaceCha.ToString();
            StrScore.Text = RaceStr.ToString();

        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

        }
    }
}
