using Newtonsoft.Json;
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

namespace Milionar
{
    /// <summary>
    /// Interakční logika pro HighScoresPage.xaml
    /// </summary>
    public partial class HighScoresPage : Page
    {
        public HighScoresPage()
        {
            InitializeComponent();

            WriteHighScores();
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

        void WriteHighScores()
        {
            List<Score> scores = jsonReadScore();
            List<Score> SortedScore = scores.OrderBy(o => o.RightAnswers).Reverse().ToList();

            if (SortedScore.Count < 10)
            {
                for (int i = SortedScore.Count(); i <= 10; i++)
                {
                    SortedScore.Add(new Score(0, 0));
                }
            }

            score1.Content = SortedScore[0].Money + "Kč";
            score2.Content = SortedScore[1].Money + "Kč";
            score3.Content = SortedScore[2].Money + "Kč";
            score4.Content = SortedScore[3].Money + "Kč";
            score5.Content = SortedScore[4].Money + "Kč";
            score6.Content = SortedScore[5].Money + "Kč";
            score7.Content = SortedScore[6].Money + "Kč";
            score8.Content = SortedScore[7].Money + "Kč";
            score9.Content = SortedScore[8].Money + "Kč";
            score10.Content = SortedScore[9].Money + "Kč";
        }
    }
}
