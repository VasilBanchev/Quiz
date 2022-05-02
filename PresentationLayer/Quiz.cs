using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PresentationLayer
{
    public partial class Quiz : Form
    {
        private int click50 = 0;
        private int clickPublic = 0;
        private int clickFriend = 0;
        QuestionView questionView;
        Question currQuestion;
        char correctAnswerChar;
        int level = 1;
        bool startButtClick = false;
        char[] answ = { 'A', 'B', 'C', 'D' };
        int[] sums = { 0, 100, 200, 300, 500, 700, 1000, 1500, 2000, 2500, 5000, 10000, 15000, 20000, 100000 };
        public Quiz()
        {

            InitializeComponent();
            AnswerAButton.BackColor = System.Drawing.Color.Black;
            AnswerAButton.FlatAppearance.BorderSize = 0;

            AnswerBButton.BackColor = System.Drawing.Color.Black;
            AnswerBButton.FlatAppearance.BorderSize = 0;

            AnswerCButton.BackColor = System.Drawing.Color.Black;
            AnswerCButton.FlatAppearance.BorderSize = 0;

            AnswerDButton.BackColor = System.Drawing.Color.Black;
            AnswerDButton.FlatAppearance.BorderSize = 0;

            QuestionButtonAsLabel.BackColor = System.Drawing.Color.Black;
            QuestionButtonAsLabel.FlatAppearance.BorderSize = 0;

            LabelsUpdate(0);
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.ShowDialog();      
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void ButPublic_Click(object sender, EventArgs e)
        {

        }

        private void ButFriend_Click(object sender, EventArgs e)
        {

        }

        private void pic50_Click(object sender, EventArgs e)
        {
            if (click50 == 0)
            {
                click50++;
                var XPic50 = Image.FromFile(@"..\..\..\..\Resources\circle-50-x.png");
                pic50.BackgroundImage = XPic50;

                EliminateTwoAnswers();
            }
        }
        private void EliminateTwoAnswers()
        {
           
            Random firstRan = new Random();
            int AnswToELM1;
            int AnswToELM2;
            do
            {
                AnswToELM1 = firstRan.Next(0, 4);
            } while (answ[AnswToELM1] == correctAnswerChar);

            RanAnswCheck(AnswToELM1);


            do
            {
                AnswToELM2 = firstRan.Next(0, 4);
            } while (answ[AnswToELM2] == correctAnswerChar|| AnswToELM2== AnswToELM1);
            RanAnswCheck(AnswToELM2);

        }
        private void ActivateButtons()
        {
            AnswerAButton.Enabled = true;
            AnswerBButton.Enabled = true;
            AnswerCButton.Enabled = true;
            AnswerDButton.Enabled = true;
        }
        private void RanAnswCheck(int AnswToELM1)
        {
            if (AnswToELM1 == 0)
            {
                AnswerAButton.Text = "A: ";
                AnswerAButton.Enabled = false;
            }
            else if (AnswToELM1 == 1)
            {
                AnswerBButton.Text = "B: ";
                AnswerBButton.Enabled = false;
            }
            else if (AnswToELM1 == 2)
            {
                AnswerCButton.Text = "C: ";
                AnswerCButton.Enabled = false;
            }
            else if (AnswToELM1 == 3)
            {
                AnswerDButton.Text = "D: ";
                AnswerDButton.Enabled = false;
            }
        }
        private void picPublic_Click(object sender, EventArgs e)
        {
            if (clickPublic == 0)
            {
                clickPublic++;
                var XPicPublic = Image.FromFile(@"..\..\..\..\Resources\circle-public-x.png");
                picPublic.BackgroundImage = XPicPublic;
                PublicAnsw();
            }

        }
        private void PublicAnsw()
        {
            int[] coefs = { 67, 67, 67, 67, 67, 47, 47, 47, 24, 24, 20, 10, 5, 3, 2 };
            string text = "Мнозинството реши: ";

            FriendPublicAlghorithm(coefs, text);
        }

        private void FriendPublicAlghorithm(int [] coefs, string text)
        {
            Random rand = new Random();

            bool trueOrFalse = rand.Next(0, 100) % coefs[level] == 0;
            if (trueOrFalse)
            {
                int randAnsw = rand.Next(0, 4);
                MessageBox.Show(text + answ[randAnsw]);
            }
            else
            {
                MessageBox.Show(text + correctAnswerChar);
            }
        }
        private void picPhone_Click(object sender, EventArgs e)
        {
            if (clickFriend == 0)
            {
                clickFriend++;
                var XPicFriend = Image.FromFile(@"..\..\..\..\Resources\circle-phone-x.png");
                picPhone.BackgroundImage = XPicFriend;

                FriendAnsw();
            }

        }
        private void FriendAnsw()
        {
            int[] coefs = { 67, 67, 67, 67, 67, 47, 47, 47, 27, 27, 23, 13, 6, 4, 3 };
            string text = "Приятелят реши: ";

            FriendPublicAlghorithm(coefs, text);
        }
        private void StartStopButt_Click(object sender, EventArgs e)
        {
            if (startButtClick == false)
            {
                questionView = new QuestionView(level);
                SetQuestion(questionView);
                startButtClick = true;
                StartStopButt.Text = "Отказвам се";
                StartStopButt.BackColor = Color.Red;
                LabelsUpdate(level);

                AnswerAButton.Enabled = true;
                AnswerBButton.Enabled = true;
                AnswerCButton.Enabled = true;
                AnswerDButton.Enabled = true;

                pic50.Enabled = true;
                picPublic.Enabled = true;
                picPhone.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Поздравления твоята игра приключи! Ти спечели {sums[level - 1]} лв.");
            }

        }

        private void SetQuestion(QuestionView questionView)
        {
            currQuestion = questionView.ChooseQuestion();
            List<string> answ = questionView.AnswersRand(currQuestion);
            correctAnswerChar = correctAnswerCHAR(answ, currQuestion);
            AnswerAButton.Text = "A: " + answ[0];
            AnswerBButton.Text = "B: " + answ[1];
            AnswerCButton.Text = "C: " + answ[2];
            AnswerDButton.Text = "D: " + answ[3];
            QuestionButtonAsLabel.Text = currQuestion.Question1;
        }
        private char correctAnswerCHAR(List<string> answers, Question question)
        {
            char[] charAnsw = { 'A', 'B', 'C', 'D'};
            for (int i = 0; i < answers.Count; i++)
            {
                if (answers[i] == question.CorrectAnswer)
                {
                    return charAnsw[i];
                }
            }

            return ' ';
            }
        private void CheckAnswer(Question question, string answer, Button button)
        {
            try
            {
                var buttNewPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-orange.png");
                button.BackgroundImage = buttNewPNG;
                Application.DoEvents();
                Thread.Sleep(1000);

                string answerText = string.Empty;
                for (int i = 0; i < answer.Length - 3; i++)
                {
                    answerText += answer[i + 3];
                }
                if (answerText == question.CorrectAnswer)
                {
                    level++;
                    questionView = new QuestionView(level);

                    buttNewPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-green.png");
                    button.BackgroundImage = buttNewPNG;
                    Application.DoEvents();
                    Thread.Sleep(1000);

                    buttNewPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons.png");
                    button.BackgroundImage = buttNewPNG;

                    ActivateButtons();
                    SetQuestion(questionView);
                    LabelsUpdate(level);
                }
                else
                {
                    buttNewPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-red.png");
                    button.BackgroundImage = buttNewPNG;

                    if (correctAnswerChar == 'A')
                    {
                        var newPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-green.png");
                        AnswerAButton.BackgroundImage = newPNG;
                    }
                    else if (correctAnswerChar == 'B')
                    {
                        var newPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-green.png");
                        AnswerBButton.BackgroundImage = newPNG;
                    }
                    else if (correctAnswerChar == 'C')
                    {
                        var newPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-green.png");
                        AnswerCButton.BackgroundImage = newPNG;
                    }
                    else if (correctAnswerChar == 'D')
                    {
                        var newPNG = Image.FromFile(@"..\..\..\..\Resources\Buttons-green.png");
                        AnswerDButton.BackgroundImage = newPNG;
                    }
                    Application.DoEvents();
                    Thread.Sleep(500);
                    MessageBox.Show($"Грешен отговор! :( \nВерен отговор: {question.CorrectAnswer}");

                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void AnswerAButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(currQuestion, AnswerAButton.Text, AnswerAButton);
        }

        private void AnswerBButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(currQuestion, AnswerBButton.Text, AnswerBButton);

        }

        private void AnswerCButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(currQuestion, AnswerCButton.Text, AnswerCButton);

        }

        private void AnswerDButton_Click(object sender, EventArgs e)
        {
            CheckAnswer(currQuestion, AnswerDButton.Text, AnswerDButton);

        }

        private void LabelsUpdate(int level)
        {
           
            label5.Text = level.ToString();
            label6.Text = sums[level].ToString() + " лв.";
            if (level<6)
            {
                label7.Text = "0 лв.";
            }
            else if (level < 11)
            {
                label7.Text = "500 лв.";
            }
            else
            {
                label7.Text = "2500 лв";
            }
        }

        private void Quiz_Resize(object sender, EventArgs e)
        {
            StartStopButt.Location = new Point((pictureBox1.Width / 2) - (StartStopButt.Width / 2), StartStopButt.Location.Y);
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }
    }

}
