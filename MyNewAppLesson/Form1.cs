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
            if(tb1.Text != null)
            {
                lbl2.Text = "ПРИВЕТ " + tb1.Text;
                tb1.Clear();
            }
            else
            {
                lbl2.Text = "Введите текст";
                lbl2.Text = "";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            lbl2.Text = "";
        }
    }
}
