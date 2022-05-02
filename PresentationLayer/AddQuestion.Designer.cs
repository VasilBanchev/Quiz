
namespace PresentationLayer
{
    partial class AddQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.IncorectAnswerTextBox3 = new System.Windows.Forms.TextBox();
            this.IncorectAnswerTextBox2 = new System.Windows.Forms.TextBox();
            this.IncorectAnswerTextBox1 = new System.Windows.Forms.TextBox();
            this.correctAnswerTextBox = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.IncorrectAnswerLabel3 = new System.Windows.Forms.Label();
            this.IncorrectAnswerLabel2 = new System.Windows.Forms.Label();
            this.IncorrectAnswerLabel1 = new System.Windows.Forms.Label();
            this.CorrectAnswerLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddQuestionText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(681, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.LevelTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.IncorectAnswerTextBox3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.IncorectAnswerTextBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.IncorectAnswerTextBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.correctAnswerTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LevelLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.IncorrectAnswerLabel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.IncorrectAnswerLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.IncorrectAnswerLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CorrectAnswerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.QuestionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuestionTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 260);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelTextBox.Location = new System.Drawing.Point(155, 218);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.PlaceholderText = "Въведете трудност от 1-15";
            this.LevelTextBox.Size = new System.Drawing.Size(602, 27);
            this.LevelTextBox.TabIndex = 16;
            // 
            // IncorectAnswerTextBox3
            // 
            this.IncorectAnswerTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorectAnswerTextBox3.Location = new System.Drawing.Point(155, 175);
            this.IncorectAnswerTextBox3.Name = "IncorectAnswerTextBox3";
            this.IncorectAnswerTextBox3.PlaceholderText = "Въведете грешен отговор";
            this.IncorectAnswerTextBox3.Size = new System.Drawing.Size(602, 27);
            this.IncorectAnswerTextBox3.TabIndex = 15;
            // 
            // IncorectAnswerTextBox2
            // 
            this.IncorectAnswerTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorectAnswerTextBox2.Location = new System.Drawing.Point(155, 132);
            this.IncorectAnswerTextBox2.Name = "IncorectAnswerTextBox2";
            this.IncorectAnswerTextBox2.PlaceholderText = "Въведете грешен отговор";
            this.IncorectAnswerTextBox2.Size = new System.Drawing.Size(602, 27);
            this.IncorectAnswerTextBox2.TabIndex = 14;
            // 
            // IncorectAnswerTextBox1
            // 
            this.IncorectAnswerTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorectAnswerTextBox1.Location = new System.Drawing.Point(155, 89);
            this.IncorectAnswerTextBox1.Name = "IncorectAnswerTextBox1";
            this.IncorectAnswerTextBox1.PlaceholderText = "Въведете грешен отговор";
            this.IncorectAnswerTextBox1.Size = new System.Drawing.Size(602, 27);
            this.IncorectAnswerTextBox1.TabIndex = 13;
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.correctAnswerTextBox.Location = new System.Drawing.Point(155, 46);
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.PlaceholderText = "Въведете правилния отговор";
            this.correctAnswerTextBox.Size = new System.Drawing.Size(602, 27);
            this.correctAnswerTextBox.TabIndex = 12;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelLabel.Location = new System.Drawing.Point(5, 220);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(5);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(142, 35);
            this.LevelLabel.TabIndex = 10;
            this.LevelLabel.Text = "Ниво (1-15):";
            // 
            // IncorrectAnswerLabel3
            // 
            this.IncorrectAnswerLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorrectAnswerLabel3.Location = new System.Drawing.Point(5, 177);
            this.IncorrectAnswerLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.IncorrectAnswerLabel3.Name = "IncorrectAnswerLabel3";
            this.IncorrectAnswerLabel3.Size = new System.Drawing.Size(142, 33);
            this.IncorrectAnswerLabel3.TabIndex = 8;
            this.IncorrectAnswerLabel3.Text = "Грешен отговор 3:";
            // 
            // IncorrectAnswerLabel2
            // 
            this.IncorrectAnswerLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorrectAnswerLabel2.Location = new System.Drawing.Point(5, 134);
            this.IncorrectAnswerLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.IncorrectAnswerLabel2.Name = "IncorrectAnswerLabel2";
            this.IncorrectAnswerLabel2.Size = new System.Drawing.Size(142, 33);
            this.IncorrectAnswerLabel2.TabIndex = 6;
            this.IncorrectAnswerLabel2.Text = "Грешен отговор 2:";
            // 
            // IncorrectAnswerLabel1
            // 
            this.IncorrectAnswerLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorrectAnswerLabel1.Location = new System.Drawing.Point(5, 91);
            this.IncorrectAnswerLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.IncorrectAnswerLabel1.Name = "IncorrectAnswerLabel1";
            this.IncorrectAnswerLabel1.Size = new System.Drawing.Size(142, 33);
            this.IncorrectAnswerLabel1.TabIndex = 4;
            this.IncorrectAnswerLabel1.Text = "Грешен отговор 1:";
            // 
            // CorrectAnswerLabel
            // 
            this.CorrectAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorrectAnswerLabel.Location = new System.Drawing.Point(5, 48);
            this.CorrectAnswerLabel.Margin = new System.Windows.Forms.Padding(5);
            this.CorrectAnswerLabel.Name = "CorrectAnswerLabel";
            this.CorrectAnswerLabel.Size = new System.Drawing.Size(142, 33);
            this.CorrectAnswerLabel.TabIndex = 2;
            this.CorrectAnswerLabel.Text = "Правилен отговор:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLabel.Location = new System.Drawing.Point(5, 5);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(142, 33);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Въпрос:";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionTextBox.Location = new System.Drawing.Point(155, 3);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.PlaceholderText = "Въведете въпрос за вкарване в системата";
            this.QuestionTextBox.Size = new System.Drawing.Size(602, 27);
            this.QuestionTextBox.TabIndex = 11;
            this.QuestionTextBox.Tag = "";
            this.QuestionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(273, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добави";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddQuestionText
            // 
            this.AddQuestionText.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddQuestionText.Location = new System.Drawing.Point(183, 1);
            this.AddQuestionText.Name = "AddQuestionText";
            this.AddQuestionText.Size = new System.Drawing.Size(342, 40);
            this.AddQuestionText.TabIndex = 3;
            this.AddQuestionText.Text = "Добавяне на въпрос";
            this.AddQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddQuestionText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LevelTextBox;
        private System.Windows.Forms.TextBox IncorectAnswerTextBox3;
        private System.Windows.Forms.TextBox IncorectAnswerTextBox2;
        private System.Windows.Forms.TextBox IncorectAnswerTextBox1;
        private System.Windows.Forms.TextBox correctAnswerTextBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label IncorrectAnswerLabel3;
        private System.Windows.Forms.Label IncorrectAnswerLabel2;
        private System.Windows.Forms.Label IncorrectAnswerLabel1;
        private System.Windows.Forms.Label CorrectAnswerLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label AddQuestionText;
    }
}