using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewAppLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(tb1.Text != "")
            {
                lbl2.Text = "ПРИВЕТ " + tb1.Text + ", " + "Это вы?";
                pictureBox1.Visible = true;
                checkBox1.Visible = true;
                tb1.Clear();
            }
            else
            {
                lbl2.Text = "Введите текст";
                lbl2.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                lbl2.Text = "Вы нам подходите!";
            }
            else
            {
                lbl2.Text = "Идите ЛЕСОМ!";
            }
        }
    }
}
