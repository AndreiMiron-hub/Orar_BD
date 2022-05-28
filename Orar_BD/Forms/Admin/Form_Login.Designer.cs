namespace Orar_BD
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.Button_Autentificare = new System.Windows.Forms.Button();
            this.pictureBox_USV_Banner = new System.Windows.Forms.PictureBox();
            this.lblErrorNume = new System.Windows.Forms.Label();
            this.labelErrorParola = new System.Windows.Forms.Label();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_USV_Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.HeaderPanel.Controls.Add(this.ButtonBack);
            this.HeaderPanel.Controls.Add(this.ButtonExit);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(600, 76);
            this.HeaderPanel.TabIndex = 16;
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Wingdings 3", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonBack.Location = new System.Drawing.Point(488, 10);
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
            this.ButtonExit.Location = new System.Drawing.Point(540, 10);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "r";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pass.Location = new System.Drawing.Point(205, 488);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(68, 25);
            this.Label_Pass.TabIndex = 20;
            this.Label_Pass.Text = "Parola";
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.Location = new System.Drawing.Point(205, 392);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(140, 25);
            this.Label_ID.TabIndex = 18;
            this.Label_ID.Text = "Nume utilizator";
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxParola.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(205, 516);
            this.textBoxParola.MaxLength = 18;
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(190, 29);
            this.textBoxParola.TabIndex = 19;
            this.textBoxParola.Text = "1234";
            // 
            // textBoxNume
            // 
            this.textBoxNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxNume.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNume.Location = new System.Drawing.Point(205, 422);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(190, 29);
            this.textBoxNume.TabIndex = 14;
            this.textBoxNume.Text = "admin";
            // 
            // Button_Autentificare
            // 
            this.Button_Autentificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Autentificare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Autentificare.FlatAppearance.BorderSize = 0;
            this.Button_Autentificare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Autentificare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Autentificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Autentificare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Autentificare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Autentificare.Location = new System.Drawing.Point(160, 580);
            this.Button_Autentificare.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Autentificare.Name = "Button_Autentificare";
            this.Button_Autentificare.Size = new System.Drawing.Size(280, 50);
            this.Button_Autentificare.TabIndex = 15;
            this.Button_Autentificare.Text = "Autentificare";
            this.Button_Autentificare.UseVisualStyleBackColor = false;
            this.Button_Autentificare.Click += new System.EventHandler(this.Button_Autentificare_Click);
            // 
            // pictureBox_USV_Banner
            // 
            this.pictureBox_USV_Banner.BackgroundImage = global::Orar_BD.Properties.Resources.Sigla_USV_Banner;
            this.pictureBox_USV_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_USV_Banner.Location = new System.Drawing.Point(175, 92);
            this.pictureBox_USV_Banner.Name = "pictureBox_USV_Banner";
            this.pictureBox_USV_Banner.Size = new System.Drawing.Size(250, 290);
            this.pictureBox_USV_Banner.TabIndex = 17;
            this.pictureBox_USV_Banner.TabStop = false;
            // 
            // lblErrorNume
            // 
            this.lblErrorNume.AutoSize = true;
            this.lblErrorNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNume.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNume.Location = new System.Drawing.Point(207, 454);
            this.lblErrorNume.Name = "lblErrorNume";
            this.lblErrorNume.Size = new System.Drawing.Size(201, 20);
            this.lblErrorNume.TabIndex = 21;
            this.lblErrorNume.Text = "COMPLETATI CAMPUL *";
            this.lblErrorNume.Visible = false;
            // 
            // labelErrorParola
            // 
            this.labelErrorParola.AutoSize = true;
            this.labelErrorParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorParola.ForeColor = System.Drawing.Color.Red;
            this.labelErrorParola.Location = new System.Drawing.Point(206, 548);
            this.labelErrorParola.Name = "labelErrorParola";
            this.labelErrorParola.Size = new System.Drawing.Size(201, 20);
            this.labelErrorParola.TabIndex = 22;
            this.labelErrorParola.Text = "COMPLETATI CAMPUL *";
            this.labelErrorParola.Visible = false;
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLogin.Location = new System.Drawing.Point(178, 548);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(247, 20);
            this.labelErrorLogin.TabIndex = 23;
            this.labelErrorLogin.Text = "NUME SAU PAROLA GRESITA";
            this.labelErrorLogin.Visible = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(600, 650);
            this.Controls.Add(this.labelErrorLogin);
            this.Controls.Add(this.labelErrorParola);
            this.Controls.Add(this.lblErrorNume);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.Label_Pass);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.Button_Autentificare);
            this.Controls.Add(this.pictureBox_USV_Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_USV_Banner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label Label_Pass;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Button Button_Autentificare;
        private System.Windows.Forms.PictureBox pictureBox_USV_Banner;
        private System.Windows.Forms.Label lblErrorNume;
        private System.Windows.Forms.Label labelErrorParola;
        private System.Windows.Forms.Label labelErrorLogin;
    }
}