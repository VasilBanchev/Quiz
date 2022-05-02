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
    public partial class Menu : Form
    {
        string _adder;
        public Menu(string adder)
        {
            InitializeComponent();
            _adder = adder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuestion form = new AddQuestion(_adder);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionFind form = new QuestionFind(_adder);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
