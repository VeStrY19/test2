namespace test2
{
    partial class Setting
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
            this.config_affiche = new System.Windows.Forms.Button();
            this.Audio = new System.Windows.Forms.Button();
            this.panel_affiche = new System.Windows.Forms.Panel();
            this.button_default = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_pld = new System.Windows.Forms.RadioButton();
            this.radioButton_60ips = new System.Windows.Forms.RadioButton();
            this.radioButton_30ips = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton_4x_msaa = new System.Windows.Forms.RadioButton();
            this.radioButton_2x_msaa = new System.Windows.Forms.RadioButton();
            this.radioButton_sans_msaa = new System.Windows.Forms.RadioButton();
            this.radioButton_auto_msaa = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_ultra = new System.Windows.Forms.RadioButton();
            this.radioButton_haute = new System.Windows.Forms.RadioButton();
            this.radioButton_moy = new System.Windows.Forms.RadioButton();
            this.radioButton_basse = new System.Windows.Forms.RadioButton();
            this.radioButton_auto_detail = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton_f_sansbd = new System.Windows.Forms.RadioButton();
            this.radioButton_fenetre = new System.Windows.Forms.RadioButton();
            this.radioButton_ple = new System.Windows.Forms.RadioButton();
            this.panel_Audio = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.panel_affiche.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_Audio.SuspendLayout();
            this.SuspendLayout();
            // 
            // config_affiche
            // 
            this.config_affiche.Location = new System.Drawing.Point(2, 12);
            this.config_affiche.Name = "config_affiche";
            this.config_affiche.Size = new System.Drawing.Size(167, 23);
            this.config_affiche.TabIndex = 0;
            this.config_affiche.Text = "Afficher configuration";
            this.config_affiche.UseVisualStyleBackColor = true;
            this.config_affiche.Click += new System.EventHandler(this.config_affiche_Click);
            // 
            // Audio
            // 
            this.Audio.Location = new System.Drawing.Point(166, 12);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(167, 23);
            this.Audio.TabIndex = 1;
            this.Audio.Text = "Audio";
            this.Audio.UseVisualStyleBackColor = true;
            this.Audio.Click += new System.EventHandler(this.Audio_Click);
            // 
            // panel_affiche
            // 
            this.panel_affiche.Controls.Add(this.button_default);
            this.panel_affiche.Controls.Add(this.groupBox5);
            this.panel_affiche.Controls.Add(this.groupBox4);
            this.panel_affiche.Controls.Add(this.groupBox3);
            this.panel_affiche.Controls.Add(this.groupBox1);
            this.panel_affiche.Location = new System.Drawing.Point(2, 41);
            this.panel_affiche.Name = "panel_affiche";
            this.panel_affiche.Size = new System.Drawing.Size(792, 441);
            this.panel_affiche.TabIndex = 2;
            // 
            // button_default
            // 
            this.button_default.Location = new System.Drawing.Point(4, 414);
            this.button_default.Name = "button_default";
            this.button_default.Size = new System.Drawing.Size(232, 23);
            this.button_default.TabIndex = 4;
            this.button_default.Text = "Restaurer par défaut";
            this.button_default.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton_pld);
            this.groupBox5.Controls.Add(this.radioButton_60ips);
            this.groupBox5.Controls.Add(this.radioButton_30ips);
            this.groupBox5.Location = new System.Drawing.Point(10, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(769, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image par seconde";
            // 
            // radioButton_pld
            // 
            this.radioButton_pld.AutoSize = true;
            this.radioButton_pld.Location = new System.Drawing.Point(449, 29);
            this.radioButton_pld.Name = "radioButton_pld";
            this.radioButton_pld.Size = new System.Drawing.Size(108, 17);
            this.radioButton_pld.TabIndex = 2;
            this.radioButton_pld.TabStop = true;
            this.radioButton_pld.Text = "Pas de limite d\'ips";
            this.radioButton_pld.UseVisualStyleBackColor = true;
            // 
            // radioButton_60ips
            // 
            this.radioButton_60ips.AutoSize = true;
            this.radioButton_60ips.Location = new System.Drawing.Point(236, 29);
            this.radioButton_60ips.Name = "radioButton_60ips";
            this.radioButton_60ips.Size = new System.Drawing.Size(108, 17);
            this.radioButton_60ips.TabIndex = 1;
            this.radioButton_60ips.TabStop = true;
            this.radioButton_60ips.Text = "Verrouillé à 60 ips";
            this.radioButton_60ips.UseVisualStyleBackColor = true;
            // 
            // radioButton_30ips
            // 
            this.radioButton_30ips.AutoSize = true;
            this.radioButton_30ips.Location = new System.Drawing.Point(6, 29);
            this.radioButton_30ips.Name = "radioButton_30ips";
            this.radioButton_30ips.Size = new System.Drawing.Size(108, 17);
            this.radioButton_30ips.TabIndex = 0;
            this.radioButton_30ips.TabStop = true;
            this.radioButton_30ips.Text = "Verrouillé à 30 ips";
            this.radioButton_30ips.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton_4x_msaa);
            this.groupBox4.Controls.Add(this.radioButton_2x_msaa);
            this.groupBox4.Controls.Add(this.radioButton_sans_msaa);
            this.groupBox4.Controls.Add(this.radioButton_auto_msaa);
            this.groupBox4.Location = new System.Drawing.Point(10, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 77);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Option MSAA";
            // 
            // radioButton_4x_msaa
            // 
            this.radioButton_4x_msaa.AutoSize = true;
            this.radioButton_4x_msaa.Location = new System.Drawing.Point(384, 34);
            this.radioButton_4x_msaa.Name = "radioButton_4x_msaa";
            this.radioButton_4x_msaa.Size = new System.Drawing.Size(36, 17);
            this.radioButton_4x_msaa.TabIndex = 3;
            this.radioButton_4x_msaa.TabStop = true;
            this.radioButton_4x_msaa.Text = "4x";
            this.radioButton_4x_msaa.UseVisualStyleBackColor = true;
            // 
            // radioButton_2x_msaa
            // 
            this.radioButton_2x_msaa.AutoSize = true;
            this.radioButton_2x_msaa.Location = new System.Drawing.Point(252, 34);
            this.radioButton_2x_msaa.Name = "radioButton_2x_msaa";
            this.radioButton_2x_msaa.Size = new System.Drawing.Size(36, 17);
            this.radioButton_2x_msaa.TabIndex = 2;
            this.radioButton_2x_msaa.TabStop = true;
            this.radioButton_2x_msaa.Text = "2x";
            this.radioButton_2x_msaa.UseVisualStyleBackColor = true;
            // 
            // radioButton_sans_msaa
            // 
            this.radioButton_sans_msaa.AutoSize = true;
            this.radioButton_sans_msaa.Location = new System.Drawing.Point(124, 34);
            this.radioButton_sans_msaa.Name = "radioButton_sans_msaa";
            this.radioButton_sans_msaa.Size = new System.Drawing.Size(49, 17);
            this.radioButton_sans_msaa.TabIndex = 1;
            this.radioButton_sans_msaa.TabStop = true;
            this.radioButton_sans_msaa.Text = "Sans";
            this.radioButton_sans_msaa.UseVisualStyleBackColor = true;
            // 
            // radioButton_auto_msaa
            // 
            this.radioButton_auto_msaa.AutoSize = true;
            this.radioButton_auto_msaa.Location = new System.Drawing.Point(7, 34);
            this.radioButton_auto_msaa.Name = "radioButton_auto_msaa";
            this.radioButton_auto_msaa.Size = new System.Drawing.Size(47, 17);
            this.radioButton_auto_msaa.TabIndex = 0;
            this.radioButton_auto_msaa.TabStop = true;
            this.radioButton_auto_msaa.Text = "Auto";
            this.radioButton_auto_msaa.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton_ultra);
            this.groupBox3.Controls.Add(this.radioButton_haute);
            this.groupBox3.Controls.Add(this.radioButton_moy);
            this.groupBox3.Controls.Add(this.radioButton_basse);
            this.groupBox3.Controls.Add(this.radioButton_auto_detail);
            this.groupBox3.Location = new System.Drawing.Point(10, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Niveau de détails";
            // 
            // radioButton_ultra
            // 
            this.radioButton_ultra.AutoSize = true;
            this.radioButton_ultra.Location = new System.Drawing.Point(507, 43);
            this.radioButton_ultra.Name = "radioButton_ultra";
            this.radioButton_ultra.Size = new System.Drawing.Size(47, 17);
            this.radioButton_ultra.TabIndex = 4;
            this.radioButton_ultra.TabStop = true;
            this.radioButton_ultra.Text = "Ultra";
            this.radioButton_ultra.UseVisualStyleBackColor = true;
            // 
            // radioButton_haute
            // 
            this.radioButton_haute.AutoSize = true;
            this.radioButton_haute.Location = new System.Drawing.Point(384, 43);
            this.radioButton_haute.Name = "radioButton_haute";
            this.radioButton_haute.Size = new System.Drawing.Size(54, 17);
            this.radioButton_haute.TabIndex = 3;
            this.radioButton_haute.TabStop = true;
            this.radioButton_haute.Text = "Haute";
            this.radioButton_haute.UseVisualStyleBackColor = true;
            // 
            // radioButton_moy
            // 
            this.radioButton_moy.AutoSize = true;
            this.radioButton_moy.Location = new System.Drawing.Point(252, 43);
            this.radioButton_moy.Name = "radioButton_moy";
            this.radioButton_moy.Size = new System.Drawing.Size(69, 17);
            this.radioButton_moy.TabIndex = 2;
            this.radioButton_moy.TabStop = true;
            this.radioButton_moy.Text = "Moyenne";
            this.radioButton_moy.UseVisualStyleBackColor = true;
            // 
            // radioButton_basse
            // 
            this.radioButton_basse.AutoSize = true;
            this.radioButton_basse.Location = new System.Drawing.Point(124, 43);
            this.radioButton_basse.Name = "radioButton_basse";
            this.radioButton_basse.Size = new System.Drawing.Size(54, 17);
            this.radioButton_basse.TabIndex = 1;
            this.radioButton_basse.TabStop = true;
            this.radioButton_basse.Text = "Basse";
            this.radioButton_basse.UseVisualStyleBackColor = true;
            // 
            // radioButton_auto_detail
            // 
            this.radioButton_auto_detail.AutoSize = true;
            this.radioButton_auto_detail.Location = new System.Drawing.Point(7, 43);
            this.radioButton_auto_detail.Name = "radioButton_auto_detail";
            this.radioButton_auto_detail.Size = new System.Drawing.Size(47, 17);
            this.radioButton_auto_detail.TabIndex = 0;
            this.radioButton_auto_detail.TabStop = true;
            this.radioButton_auto_detail.Text = "Auto";
            this.radioButton_auto_detail.UseVisualStyleBackColor = true;
            this.radioButton_auto_detail.CheckedChanged += new System.EventHandler(this.radioButton_auto_detail_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton_f_sansbd);
            this.groupBox1.Controls.Add(this.radioButton_fenetre);
            this.groupBox1.Controls.Add(this.radioButton_ple);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résolution";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1920x1080"});
            this.comboBox1.Location = new System.Drawing.Point(7, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // radioButton_f_sansbd
            // 
            this.radioButton_f_sansbd.AutoSize = true;
            this.radioButton_f_sansbd.Location = new System.Drawing.Point(331, 77);
            this.radioButton_f_sansbd.Name = "radioButton_f_sansbd";
            this.radioButton_f_sansbd.Size = new System.Drawing.Size(125, 17);
            this.radioButton_f_sansbd.TabIndex = 2;
            this.radioButton_f_sansbd.TabStop = true;
            this.radioButton_f_sansbd.Text = "Fenêtré sans bordure";
            this.radioButton_f_sansbd.UseVisualStyleBackColor = true;
            // 
            // radioButton_fenetre
            // 
            this.radioButton_fenetre.AutoSize = true;
            this.radioButton_fenetre.Location = new System.Drawing.Point(165, 77);
            this.radioButton_fenetre.Name = "radioButton_fenetre";
            this.radioButton_fenetre.Size = new System.Drawing.Size(61, 17);
            this.radioButton_fenetre.TabIndex = 1;
            this.radioButton_fenetre.TabStop = true;
            this.radioButton_fenetre.Text = "Fenêtré";
            this.radioButton_fenetre.UseVisualStyleBackColor = true;
            // 
            // radioButton_ple
            // 
            this.radioButton_ple.AutoSize = true;
            this.radioButton_ple.Location = new System.Drawing.Point(7, 77);
            this.radioButton_ple.Name = "radioButton_ple";
            this.radioButton_ple.Size = new System.Drawing.Size(78, 17);
            this.radioButton_ple.TabIndex = 0;
            this.radioButton_ple.TabStop = true;
            this.radioButton_ple.Text = "Plein écran";
            this.radioButton_ple.UseVisualStyleBackColor = true;
            this.radioButton_ple.CheckedChanged += new System.EventHandler(this.radioButton_ple_CheckedChanged);
            // 
            // panel_Audio
            // 
            this.panel_Audio.Controls.Add(this.groupBox2);
            this.panel_Audio.Location = new System.Drawing.Point(2, 41);
            this.panel_Audio.Name = "panel_Audio";
            this.panel_Audio.Size = new System.Drawing.Size(792, 441);
            this.panel_Audio.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat vocal";
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(700, 488);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(81, 23);
            this.Annuler.TabIndex = 4;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(621, 488);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(73, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "Appliquer";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 518);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Audio);
            this.Controls.Add(this.config_affiche);
            this.Controls.Add(this.panel_affiche);
            this.Controls.Add(this.panel_Audio);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Setting";
            this.Text = "Setting";
            this.panel_affiche.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_Audio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button config_affiche;
        private System.Windows.Forms.Button Audio;
        private System.Windows.Forms.Panel panel_affiche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_Audio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_f_sansbd;
        private System.Windows.Forms.RadioButton radioButton_fenetre;
        private System.Windows.Forms.RadioButton radioButton_ple;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_default;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_pld;
        private System.Windows.Forms.RadioButton radioButton_60ips;
        private System.Windows.Forms.RadioButton radioButton_30ips;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton_4x_msaa;
        private System.Windows.Forms.RadioButton radioButton_2x_msaa;
        private System.Windows.Forms.RadioButton radioButton_sans_msaa;
        private System.Windows.Forms.RadioButton radioButton_auto_msaa;
        private System.Windows.Forms.RadioButton radioButton_ultra;
        private System.Windows.Forms.RadioButton radioButton_haute;
        private System.Windows.Forms.RadioButton radioButton_moy;
        private System.Windows.Forms.RadioButton radioButton_basse;
        private System.Windows.Forms.RadioButton radioButton_auto_detail;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button button_ok;
    }
}