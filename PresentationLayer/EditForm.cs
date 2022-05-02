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
    public partial class EditForm : Form
    {
        private Question _question;
        private string _adder;
        private QuestionManager qm;
        public EditForm(Question question, string adder)
        {
            InitializeComponent();
            _question = question;
            _adder = adder;
            qm = new QuestionManager(DBContextManager.CreateContext());
            showQuestion();

        }
        private void showQuestion()
        {
            try
            {
                textBox1.Text = _question.Question1;
                textBox2.Text = _question.Level.ToString();
                textBox3.Text = _question.CorrectAnswer;
                textBox4.Text = _question.InCorrectAnswer1;
                textBox5.Text = _question.InCorrectAnswer2;
                textBox7.Text = _question.InCorrectAnswer3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                qm.Delete(_question.Id);
                MessageBox.Show("Успешно изтрит въпрос");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Question editedQ = _question;
                editedQ.Question1 = textBox1.Text;
                editedQ.Level = int.Parse(textBox2.Text.ToString());
                editedQ.CorrectAnswer = textBox3.Text;
                editedQ.InCorrectAnswer1 = textBox4.Text;
                editedQ.InCorrectAnswer2 = textBox5.Text;
                editedQ.InCorrectAnswer3 = textBox7.Text;
                editedQ.Author = _adder;

                qm.Update(editedQ);
                MessageBox.Show("Успешно редактиран въпрос! Благодарим ти " + _adder + "!  :)");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
