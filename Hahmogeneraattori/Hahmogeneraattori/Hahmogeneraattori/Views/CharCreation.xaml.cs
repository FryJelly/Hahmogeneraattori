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
        public CharCreation()
        {
            InitializeComponent();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            stats = Stats.RollStats();
            ScoreList.DataContext = stats;
            
        }

        private void ListBox_SelectionChanged()
        {

        }

        private void Dwarf_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;
            stats2.Con = stats.Con + 2;
            stats2.Wis = stats.Wis + 2;
            stats2.Cha = stats.Cha - 2;
            ScoreList.DataContext = stats2;
        }

        private void Elf_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

        }

        private void Gnome_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

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
            stats2 = stats;

        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {
            stats2 = stats;

        }
    }
}
