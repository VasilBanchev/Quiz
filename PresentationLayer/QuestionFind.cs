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

    public partial class QuestionFind : Form
    {
        QuestionManager qm1;
        List<Question> allQuestions;
        string _adder;
        int rows = 1;
        List<Question> questions;
        public QuestionFind(string adder)
        {
            InitializeComponent();
            _adder = adder;
            qm1 = new QuestionManager(DBContextManager.CreateContext());
            allQuestions = qm1.ReadAll().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDTextBox.Text);

               questions  = new List<Question>();
                questions.Add(qm1.Read(id));

                ShowQuestions();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ShowQuestions()
        {
            try
            {

                tableLayoutPanel4.Controls.Clear();
                rows = 1;
                for (int i = 0; i < questions.Count; i++)
                {
                   
                    tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    rows++;
                    Label labelID = new Label();
                    labelID.Dock = DockStyle.Fill;
                    labelID.Text = questions[i].Id.ToString();
                    tableLayoutPanel4.Controls.Add(labelID, 0, rows);

                    Label labelQuestion = new Label();
                    labelQuestion.Dock = DockStyle.Fill; 
                    labelQuestion.Text = questions[i].Question1;
                    tableLayoutPanel4.Controls.Add(labelQuestion, 1, rows);

                    Label labelAnswer = new Label();
                    labelAnswer.Dock = DockStyle.Fill;
                    labelAnswer.Text = questions[i].CorrectAnswer;
                    tableLayoutPanel4.Controls.Add(labelAnswer, 2,rows);

                    Button buttonChoose = new Button();
                    buttonChoose.AutoSize = true;
                    buttonChoose.Text = "Редактирай";
                    tableLayoutPanel4.Controls.Add(buttonChoose, 3, rows);
                    buttonChoose.AccessibleName =  i.ToString();
                    buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
                    

                    //Controls.Add(buttonChoose);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
           

        }
        private void OpenEditForm(int row)
        {

        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                Button chosenB = (Button)sender;
                string strName = chosenB.AccessibleName;
                EditForm form = new EditForm(questions[int.Parse(strName)], _adder);
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private void buttonChooseAll_Click(object sender, EventArgs e)
        {
            try
            {
                Button chosenB = (Button)sender;
                string strName = chosenB.AccessibleName;
                EditForm form = new EditForm(allQuestions[int.Parse(strName)], _adder);
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuestionEdit_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel2.Width = tableLayoutPanel1.Width;
            tableLayoutPanel3.Width = tableLayoutPanel1.Width;
            tableLayoutPanel4.Width = tableLayoutPanel1.Width;
        }
       
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = KeyWordTextBox.Text.ToString();
               questions = allQuestions.Where(x => x.Question1.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) > -1).ToList();

                ShowQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowAllQuestions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string corrAnsw = CorrectAnswerTextBox.Text.ToString();
          questions = allQuestions.Where(x => x.CorrectAnswer.ToLower() == corrAnsw.ToLower()).ToList();

            ShowQuestions();
        }
        private void ShowAllQuestions()
        {
            try
            {

                tableLayoutPanel4.Controls.Clear();
                rows = 1;
                for (int i = 0; i < allQuestions.Count; i++)
                {

                    tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    rows++;
                    Label labelID = new Label();
                    labelID.Dock = DockStyle.Fill;
                    labelID.Text = allQuestions[i].Id.ToString();
                    tableLayoutPanel4.Controls.Add(labelID, 0, rows);

                    Label labelQuestion = new Label();
                    labelQuestion.Dock = DockStyle.Fill;
                    labelQuestion.Text = allQuestions[i].Question1;
                    tableLayoutPanel4.Controls.Add(labelQuestion, 1, rows);

                    Label labelAnswer = new Label();
                    labelAnswer.Dock = DockStyle.Fill;
                    labelAnswer.Text = allQuestions[i].CorrectAnswer;
                    tableLayoutPanel4.Controls.Add(labelAnswer, 2, rows);

                    Button buttonChoose = new Button();
                    buttonChoose.AutoSize = true;
                    buttonChoose.Text = "Редактирай";
                    tableLayoutPanel4.Controls.Add(buttonChoose, 3, rows);
                    buttonChoose.AccessibleName = i.ToString();
                    buttonChoose.Click += new System.EventHandler(this.buttonChooseAll_Click);


                    //Controls.Add(buttonChoose);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu form = new Menu(_adder);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
