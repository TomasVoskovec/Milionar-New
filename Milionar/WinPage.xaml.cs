using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Milionar
{
    /// <summary>
    /// Interakční logika pro WinPage.xaml
    /// </summary>
    public partial class WinPage : Page
    {
        public WinPage()
        {
            InitializeComponent();
        }

        Frame main = new Frame();
        GamePage game = new GamePage();
        SendScorePage sendScore = new SendScorePage();

        Score score = new Score(0,0);
        List<Score> scores = new List<Score>();

        public WinPage(GamePage gamePage, Frame mainFrame, SendScorePage sendScorePage) : this()
        {
            game = gamePage;
            main = mainFrame;
            sendScore = sendScorePage;

            writePrice();

            List<int> scoreList = game.GetScore();
            score = new Score(scoreList[0], scoreList[1]);

            scores = jsonReadScore();
            if(scores != null)
            {
                scores.Add(score);
            }
        }

        List<Score> jsonReadScore()
        {
            using (StreamReader r = new StreamReader(@"../../Json/score.json"))
            {
                string json = r.ReadToEnd();
                List<Score> scores = JsonConvert.DeserializeObject<List<Score>>(json);

                return scores;
            }
        }

        void jsonWriteScore(List<Score> score)
        {
            string json = JsonConvert.SerializeObject(score);

            File.WriteAllText(@"../../Json/score.json", json);
        }

        void writePrice()
        {
            List<int> gameScore = game.GetScore();

            price.Content = "Konec hry, vyhrál jste " + gameScore[0].ToString() + "Kč";
        }

        private void save_click(object sender, RoutedEventArgs e)
        {
            main.Navigate(new SendScorePage(main, this, game));

            List<int> scoreList = game.GetScore();
            List<Score> scores = new List<Score>();
            if(jsonReadScore() != null)
            {
                scores = jsonReadScore();
            }

            Score newScore = new Score(scoreList[1], scoreList[0]);
            newScore.Name = sendScore.SendName;
            scores.Add(newScore);

            jsonWriteScore(scores);

            main.Navigate(new HighScoresPage());
        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            main.Navigate(new MenuPage(main));
        }
    }
}
