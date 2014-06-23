using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SelfTest
{
    public partial class MainForm : Form
    {
        private Question.QuestionBank Bank;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Bank = Question.QuestionBank.GetInstance();
            this.Bank.ReadQuestionFromFile("Question.txt");
        }
    }
}
