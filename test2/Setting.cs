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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

            /*if(radioButton_auto_detail.Checked)
            {
                Label auto_detail = new Label();
                auto_detail.Text = "Laissez le jeu";
                this.Controls.Add(auto_detail);
            }

            if (radioButton_basse.Checked)
            {
                Label basse = new Label();
                basse.Text = "Le niveau de ";
                this.Controls.Add(basse);
            }

            if(radioButton_moy.Checked);
            {
                
                Label moy = new Label();
                moy.Text = "Moy";
                this.Controls.Add(moy);
                
            }*/

        }

        private void config_affiche_Click(object sender, EventArgs e)
        {
            panel_affiche.BringToFront();
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            panel_Audio.BringToFront();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void radioButton_ple_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton_pld.Checked == true)
            {
                Label full = new Label();

            }
        }

        private void radioButton_auto_detail_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_auto_detail.Checked)
            {
                Label auto = new Label();
                //string set = "Laissez le jeu déterminer la qualité optimale des paramètres pour votre système";
                auto.Text = "Laissez le";
                //auto.Location = new Point(400, 100);
                groupBox3.Controls.Add(auto);
                this.Controls.Add(groupBox3);
            }
        }
    }
}
