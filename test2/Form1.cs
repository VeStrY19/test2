using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jouer jouer = new Jouer();
            jouer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void test1_CheckedChanged(object sender, EventArgs e)
        {
            if(test1.Checked)
            {
                Label label = new Label();
                label.Text = "salut";
                //label.Show();
                test1.Location = new Point(480, 40);
                label.Location = new Point(400, 100);
                    //(int)test1.Location.X;
                this.Controls.Add(label);
            }
        }
    }
}
