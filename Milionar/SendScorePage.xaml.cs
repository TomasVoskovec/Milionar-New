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
    /// Interakční logika pro SendScorePage.xaml
    /// </summary>
    public partial class SendScorePage : Page
    {
        public SendScorePage()
        {
            InitializeComponent();
        }

        Frame mainFrame = new Frame();
        WinPage winPage = new WinPage();
        GamePage gamePage = new GamePage();

        public SendScorePage(Frame frame, WinPage win, GamePage game) : this()
        {
            mainFrame = frame;
            winPage = win;
            gamePage = game;
        }

        public string SendName;

        private void sendScore_click(object sender, RoutedEventArgs e)
        {
            SendName = nameInput.Text;

            mainFrame.Navigate(new WinPage(gamePage, mainFrame, this));
        }
    }
}
