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

namespace Milionar
{
    /// <summary>
    /// Interakční logika pro MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        Frame mainFrame = new Frame();
        public MenuPage(Frame frame) : this()
        {
            mainFrame = frame;
        }

        private void highScores_click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HighScoresPage(mainFrame));
        }

        private void newGame_click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new GamePage(mainFrame));
        }
    }
}
