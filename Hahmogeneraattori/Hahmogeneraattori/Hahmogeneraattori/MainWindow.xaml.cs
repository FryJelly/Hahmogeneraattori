using Hahmogeneraattori.ViewModels;
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

namespace Hahmogeneraattori
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Character> chars = new List<Character>();
        public MainWindow()
        {
            InitializeComponent();
            //
        }

        private void CreateNewCharacter_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new CharCreationViewModel();
        }

        // Database functionality test
        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           /* try
            {
                chars = Hahmogeneraattori.DBCharacters.GetCharacterDataFromMysql();
                CharacterList.ItemsSource = chars;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }
    }
}
