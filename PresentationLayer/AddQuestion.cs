using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AddQuestion : Form
    {
        private Question quest;
        private string _adder;
        public AddQuestion(string adder)
        {
            InitializeComponent();
            quest = new Question();
            _adder = adder;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string levelString = LevelTextBox.Text;
                int level = Convert.ToInt32(levelString);
                if (QuestionTextBox.TextLength < 15)
                {
                    MessageBox.Show("Твърде малък брой символи във въпроса");

                }
                else if (correctAnswerTextBox.TextLength < 1)
                {
                    MessageBox.Show("Твърде малък брой символи в правилния отговор");

                }
                else if (IncorectAnswerTextBox1.TextLength < 1)
                {
                    MessageBox.Show("Твърде малък брой символи в грешнен отговор 1");

                }
                else if (IncorectAnswerTextBox2.TextLength < 1)
                {
                    MessageBox.Show("Твърде малък брой символи в грешнен отговор 2");

                }
                else if (IncorectAnswerTextBox3.TextLength < 1)
                {
                    MessageBox.Show("Твърде малък брой символи в грешнен отговор 3");

                }

                else if (level > 15 || level < 1)
                {
                    MessageBox.Show("Навалидна стойност при трудноста на въпроса");

                }


                else
                {
                    quest.Question1 = QuestionTextBox.Text.ToString();
                    quest.CorrectAnswer = correctAnswerTextBox.Text.ToString();
                    quest.InCorrectAnswer1 = IncorectAnswerTextBox1.Text.ToString();
                    quest.InCorrectAnswer2 = IncorectAnswerTextBox2.Text.ToString();
                    quest.InCorrectAnswer3 = IncorectAnswerTextBox3.Text.ToString();
                    quest.Level = int.Parse(LevelTextBox.Text.ToString());
                    quest.Author = _adder;

                    QuestionManager qm = new QuestionManager(DBContextManager.GetContext());
                    qm.Create(quest);

                    QuestionTextBox.Clear();
                    correctAnswerTextBox.Clear();
                    IncorectAnswerTextBox1.Clear();
                    IncorectAnswerTextBox2.Clear();
                    IncorectAnswerTextBox3.Clear();
                    LevelTextBox.Clear();

                    MessageBox.Show($"Успешно добавен въпрос! Благодарим ти, {this._adder}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu(_adder);
            this.Hide();
            form.ShowDialog();
            this.Hide();
        }
    }
}
