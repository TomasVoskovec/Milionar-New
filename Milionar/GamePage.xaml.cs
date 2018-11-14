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
    /// Interakční logika pro GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
            createQuestions();
            checkAward();
            nextQuestion();
        }

        Frame mainFrame = new Frame();

        public GamePage(Frame frame) : this()
        {
            mainFrame = frame;
        }

        Random rn = new Random();

        List<Question> questions = new List<Question>();
        Question currentQuestion = null;

        int rightAnsweres;

        void nextQuestion()
        {
            int questionIndex = rn.Next(0, questions.Count());

            loadQuestion(questionIndex);

            generateQuestion();
        }

        public List<int> GetScore()
        {
            List<int> score = new List<int>();

            if (rightAnsweres == 1)
            {
                score.Add(1000);
            }
            else if (rightAnsweres == 2)
            {
                score.Add(2000);
            }
            else if (rightAnsweres == 3)
            {
                score.Add(3000);
            }
            else if (rightAnsweres == 4)
            {
                score.Add(5000);
            }
            else if (rightAnsweres == 5)
            {
                score.Add(10000);
            }
            else if (rightAnsweres == 6)
            {
                score.Add(20000);
            }
            else if (rightAnsweres == 7)
            {
                score.Add(40000);
            }
            else if (rightAnsweres == 8)
            {
                score.Add(80000);
            }
            else if (rightAnsweres == 9)
            {
                score.Add(160000);
            }
            else if (rightAnsweres == 10)
            {
                score.Add(320000);
            }
            else if (rightAnsweres == 11)
            {
                score.Add(640000);
            }
            else if (rightAnsweres == 12)
            {
                score.Add(1250000);
            }
            else if (rightAnsweres == 13)
            {
                score.Add(2500000);
            }
            else if (rightAnsweres == 14)
            {
                score.Add(5000000);
            }
            else if (rightAnsweres == 15)
            {
                score.Add(10000000);
            }
            else
            {
                score.Add(0);
                score.Add(0);

                return score;
            }

            score.Add(rightAnsweres);
            return score;
        }

        void createQuestions()
        {
            Question question = new Question("Kolik gramů má 1 kilo?", "1000", new List<string> { "100000", "100", "10000" });
            questions.Add(question);

            Question question2 = new Question("Kolik prstů má slon na jedné noze", "4", new List<string> { "5", "6", "3" });
            questions.Add(question2);

            Question question3 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question3);

            Question question4 = new Question("Kolik gramů má 1 kilo?", "1000", new List<string> { "100000", "100", "10000" });
            questions.Add(question4);

            Question question5 = new Question("Kolik prstů má slon na jedné noze", "4", new List<string> { "5", "6", "3" });
            questions.Add(question5);

            Question question6 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question6);

            Question question7 = new Question("Kolik gramů má 1 kilo?", "1000", new List<string> { "100000", "100", "10000" });
            questions.Add(question7);

            Question question8 = new Question("Kolik prstů má slon na jedné noze", "4", new List<string> { "5", "6", "3" });
            questions.Add(question8);

            Question question9 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question9);

            Question question10 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question10);

            Question question11 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question11);

            Question question12 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question12);

            Question question13 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question13);

            Question question14 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question14);

            Question question15 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question15);

            Question question16 = new Question("Slovenské národní jídlo halušky jsou", "noky z bramorového těsta", new List<string> { "bezvaječné těstoviny", "vaječné těstoviny", "smažené plátky uzeného masa" });
            questions.Add(question16);
        }

        void loadQuestion(int questionIndex)
        {
            currentQuestion = questions[questionIndex];

            questions.RemoveAt(questionIndex);
        }

        void generateQuestion()
        {
            questionText.Content = currentQuestion.Text;

            int rightAnswer = rn.Next(1,5);

            if (rightAnswer == 1)
            {
                answer1.Content = currentQuestion.Answer;
                answer2.Content = currentQuestion.WrongAnswers[0];
                answer3.Content = currentQuestion.WrongAnswers[1];
                answer4.Content = currentQuestion.WrongAnswers[2];
            }
            else if (rightAnswer == 2)
            {
                answer1.Content = currentQuestion.WrongAnswers[0];
                answer2.Content = currentQuestion.Answer;
                answer3.Content = currentQuestion.WrongAnswers[1];
                answer4.Content = currentQuestion.WrongAnswers[2];
            }
            else if (rightAnswer == 3)
            {
                answer1.Content = currentQuestion.WrongAnswers[0];
                answer2.Content = currentQuestion.WrongAnswers[1];
                answer3.Content = currentQuestion.Answer;
                answer4.Content = currentQuestion.WrongAnswers[2];
            }
            else if (rightAnswer == 4)
            {
                answer1.Content = currentQuestion.WrongAnswers[0];
                answer2.Content = currentQuestion.WrongAnswers[1];
                answer3.Content = currentQuestion.WrongAnswers[2];
                answer4.Content = currentQuestion.Answer;
            }
        }

        // Check if answer is right
        private bool isRightAnswer(string answer, Question question)
        {
            return answer == question.Answer;
        }

        // Game Over action
        private void gameOver()
        {
            mainFrame.Navigate(new WinPage(this, mainFrame));
        }

        // Set award backgroun
        private void checkAward()
        {
            Style active = Resources["activeLabel"] as Style;
            Style pased = Resources["pasedLabel"] as Style;

            if (rightAnsweres == 0)
            {
                price1.Style = active;
            }
            if (rightAnsweres == 1)
            {
                price2.Style = active;
                price1.Style = pased;
            }
            if (rightAnsweres == 2)
            {
                price3.Style = active;
                price2.Style = pased;
                //gameOver();
            }
            if (rightAnsweres == 3)
            {
                price4.Style = active;
                price3.Style = pased;
            }
            if (rightAnsweres == 4)
            {
                price5.Style = active;
                price4.Style = pased;
            }
            if (rightAnsweres == 5)
            {
                price6.Style = active;
                price5.Style = pased;
            }
            if (rightAnsweres == 6)
            {
                price7.Style = active;
                price6.Style = pased;
            }
            if (rightAnsweres == 7)
            {
                price8.Style = active;
                price7.Style = pased;
            }
            if (rightAnsweres == 8)
            {
                price9.Style = active;
                price8.Style = pased;
            }
            if (rightAnsweres == 9)
            {
                price10.Style = active;
                price9.Style = pased;
            }
            if (rightAnsweres == 10)
            {
                price11.Style = active;
                price10.Style = pased;
            }
            if (rightAnsweres == 11)
            {
                price12.Style = active;
                price11.Style = pased;
            }
            if (rightAnsweres == 12)
            {
                price13.Style = active;
                price12.Style = pased;
            }
            if (rightAnsweres == 13)
            {
                price14.Style = active;
                price13.Style = pased;
            }
            if (rightAnsweres == 14)
            {
                price15.Style = active;
                price14.Style = pased;
            }
            if (rightAnsweres == 15)
            {
                price15.Style = pased;
                gameOver();
            }
        }

        private void answer_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button answerButton = sender as Button;

                if (isRightAnswer(answerButton.Content.ToString(), currentQuestion))
                {
                    rightAnsweres++;
                    checkAward();

                    nextQuestion();
                }
                else
                {
                    gameOver();
                }
            }
            else
            {
                throw new Exception("Sender must be 'Button'");
            }
        }
    }
}
