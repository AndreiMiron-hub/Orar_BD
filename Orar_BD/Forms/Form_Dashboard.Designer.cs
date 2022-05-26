namespace Orar_BD
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Dash_Menu = new System.Windows.Forms.Panel();
            this.Button_Orar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_Cursuri = new System.Windows.Forms.Button();
            this.Button_Facultati = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Dash_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Wingdings 3", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonBack.Location = new System.Drawing.Point(787, 10);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(50, 50);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "O";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Webdings", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonExit.Location = new System.Drawing.Point(839, 10);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "r";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.ButtonBack);
            this.HeaderPanel.Controls.Add(this.ButtonExit);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(900, 120);
            this.HeaderPanel.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Orar_BD.Properties.Resources.Sigla_USV_Banner_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(23, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 123);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Dash_Menu
            // 
            this.panel_Dash_Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_Dash_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.panel_Dash_Menu.Controls.Add(this.Button_Orar);
            this.panel_Dash_Menu.Controls.Add(this.button2);
            this.panel_Dash_Menu.Controls.Add(this.Button_Cursuri);
            this.panel_Dash_Menu.Controls.Add(this.Button_Facultati);
            this.panel_Dash_Menu.Location = new System.Drawing.Point(0, 118);
            this.panel_Dash_Menu.Name = "panel_Dash_Menu";
            this.panel_Dash_Menu.Size = new System.Drawing.Size(210, 532);
            this.panel_Dash_Menu.TabIndex = 13;
            // 
            // Button_Orar
            // 
            this.Button_Orar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Orar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Orar.FlatAppearance.BorderSize = 0;
            this.Button_Orar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Orar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Orar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Orar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Orar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Orar.Location = new System.Drawing.Point(0, 270);
            this.Button_Orar.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Orar.Name = "Button_Orar";
            this.Button_Orar.Size = new System.Drawing.Size(210, 50);
            this.Button_Orar.TabIndex = 16;
            this.Button_Orar.Text = "Orar";
            this.Button_Orar.UseVisualStyleBackColor = false;
            this.Button_Orar.Click += new System.EventHandler(this.Button_Orar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.button2.Location = new System.Drawing.Point(0, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Facultati";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Button_Cursuri
            // 
            this.Button_Cursuri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Cursuri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Cursuri.FlatAppearance.BorderSize = 0;
            this.Button_Cursuri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Cursuri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Cursuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cursuri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Cursuri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Cursuri.Location = new System.Drawing.Point(1, 110);
            this.Button_Cursuri.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Cursuri.Name = "Button_Cursuri";
            this.Button_Cursuri.Size = new System.Drawing.Size(208, 50);
            this.Button_Cursuri.TabIndex = 14;
            this.Button_Cursuri.Text = "Cursuri";
            this.Button_Cursuri.UseVisualStyleBackColor = false;
            // 
            // Button_Facultati
            // 
            this.Button_Facultati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Facultati.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Facultati.FlatAppearance.BorderSize = 0;
            this.Button_Facultati.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Facultati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Facultati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Facultati.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Facultati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Facultati.Location = new System.Drawing.Point(0, 30);
            this.Button_Facultati.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Facultati.Name = "Button_Facultati";
            this.Button_Facultati.Size = new System.Drawing.Size(209, 50);
            this.Button_Facultati.TabIndex = 13;
            this.Button_Facultati.Text = "Facultati";
            this.Button_Facultati.UseVisualStyleBackColor = false;
            this.Button_Facultati.Click += new System.EventHandler(this.Button_Facultati_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Orar_BD.Properties.Resources.Sigla_USV_Banner;
            this.pictureBox2.Location = new System.Drawing.Point(425, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_Dash_Menu);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Dash_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Dash_Menu;
        private System.Windows.Forms.Button Button_Orar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button_Cursuri;
        private System.Windows.Forms.Button Button_Facultati;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}