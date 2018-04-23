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
        List<Stats> stats = new List<Stats>();
        public CharCreation()
        {
            InitializeComponent();
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            dgStats.ItemsSource = Stats.RollStats();
        }

        private void ListBox_SelectionChanged()
        {

        }

        private void Dwarf_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void Elf_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Gnome_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void HalfElf_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void HalfOrc_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Halfling_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Human_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
