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
    public partial class Jouer : Form
    {
        public Jouer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Bonjour";
            label.Location = new Point(200, 100);
            //this.groupBox1 = new GroupBox();
            this.groupBox1.Controls.Add(label);
            Controls.Add(groupBox1);
            
            //MessageBox.Show("Hello");
            //this.Controls.Add(label);
            
        }
    }
}
