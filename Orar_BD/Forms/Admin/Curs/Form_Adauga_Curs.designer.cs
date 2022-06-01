namespace Orar_BD
{
    partial class Form_Adauga_Curs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Adauga_Curs));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.textBoxProfesor = new System.Windows.Forms.TextBox();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.textBoxSala = new System.Windows.Forms.TextBox();
            this.labelSala = new System.Windows.Forms.Label();
            this.textBoxSaptamani = new System.Windows.Forms.TextBox();
            this.labelSaptamani = new System.Windows.Forms.Label();
            this.textBoxInceputIntervalOrar = new System.Windows.Forms.TextBox();
            this.labelIntervalOrar = new System.Windows.Forms.Label();
            this.textBoxNumeCurs = new System.Windows.Forms.TextBox();
            this.labelCurs = new System.Windows.Forms.Label();
            this.lblIndexFac = new System.Windows.Forms.Label();
            this.ButtonAnuleaza = new System.Windows.Forms.Button();
            this.lblAdaugaCurs = new System.Windows.Forms.Label();
            this.ButtonAdauga = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIntervalStart = new System.Windows.Forms.Label();
            this.textBoxFinalIntervalOrar = new System.Windows.Forms.TextBox();
            this.comboBoxFacultati = new System.Windows.Forms.ComboBox();
            this.labelFacultate = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.ButtonExit);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(2, 2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(796, 129);
            this.HeaderPanel.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Orar_BD.Properties.Resources.Sigla_USV_Banner_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Orar_BD.Properties.Resources.Sigla_USV_Banner_2;
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 123);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonExit
            // 
            this.ButtonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Webdings", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonExit.Location = new System.Drawing.Point(717, 33);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "r";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Curs",
            "Seminar",
            "Laborator"});
            this.comboBoxTip.Location = new System.Drawing.Point(285, 501);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(222, 24);
            this.comboBoxTip.TabIndex = 80;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(280, 472);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(40, 25);
            this.labelTip.TabIndex = 79;
            this.labelTip.Text = "Tip";
            // 
            // textBoxProfesor
            // 
            this.textBoxProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfesor.Location = new System.Drawing.Point(285, 425);
            this.textBoxProfesor.Name = "textBoxProfesor";
            this.textBoxProfesor.Size = new System.Drawing.Size(222, 26);
            this.textBoxProfesor.TabIndex = 78;
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesor.Location = new System.Drawing.Point(280, 395);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(85, 25);
            this.labelProfesor.TabIndex = 77;
            this.labelProfesor.Text = "Profesor";
            // 
            // textBoxSala
            // 
            this.textBoxSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSala.Location = new System.Drawing.Point(285, 345);
            this.textBoxSala.Name = "textBoxSala";
            this.textBoxSala.Size = new System.Drawing.Size(222, 26);
            this.textBoxSala.TabIndex = 76;
            // 
            // labelSala
            // 
            this.labelSala.AutoSize = true;
            this.labelSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSala.Location = new System.Drawing.Point(280, 315);
            this.labelSala.Name = "labelSala";
            this.labelSala.Size = new System.Drawing.Size(52, 25);
            this.labelSala.TabIndex = 75;
            this.labelSala.Text = "Sala";
            // 
            // textBoxSaptamani
            // 
            this.textBoxSaptamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaptamani.Location = new System.Drawing.Point(285, 265);
            this.textBoxSaptamani.Name = "textBoxSaptamani";
            this.textBoxSaptamani.Size = new System.Drawing.Size(222, 26);
            this.textBoxSaptamani.TabIndex = 74;
            // 
            // labelSaptamani
            // 
            this.labelSaptamani.AutoSize = true;
            this.labelSaptamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaptamani.Location = new System.Drawing.Point(280, 235);
            this.labelSaptamani.Name = "labelSaptamani";
            this.labelSaptamani.Size = new System.Drawing.Size(106, 25);
            this.labelSaptamani.TabIndex = 73;
            this.labelSaptamani.Text = "Saptamani";
            // 
            // textBoxInceputIntervalOrar
            // 
            this.textBoxInceputIntervalOrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInceputIntervalOrar.Location = new System.Drawing.Point(285, 183);
            this.textBoxInceputIntervalOrar.Name = "textBoxInceputIntervalOrar";
            this.textBoxInceputIntervalOrar.Size = new System.Drawing.Size(101, 26);
            this.textBoxInceputIntervalOrar.TabIndex = 72;
            // 
            // labelIntervalOrar
            // 
            this.labelIntervalOrar.AutoSize = true;
            this.labelIntervalOrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervalOrar.Location = new System.Drawing.Point(280, 119);
            this.labelIntervalOrar.Name = "labelIntervalOrar";
            this.labelIntervalOrar.Size = new System.Drawing.Size(114, 25);
            this.labelIntervalOrar.TabIndex = 71;
            this.labelIntervalOrar.Text = "Interval orar";
            // 
            // textBoxNumeCurs
            // 
            this.textBoxNumeCurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeCurs.Location = new System.Drawing.Point(285, 78);
            this.textBoxNumeCurs.Name = "textBoxNumeCurs";
            this.textBoxNumeCurs.Size = new System.Drawing.Size(222, 26);
            this.textBoxNumeCurs.TabIndex = 70;
            // 
            // labelCurs
            // 
            this.labelCurs.AutoSize = true;
            this.labelCurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurs.Location = new System.Drawing.Point(280, 48);
            this.labelCurs.Name = "labelCurs";
            this.labelCurs.Size = new System.Drawing.Size(106, 25);
            this.labelCurs.TabIndex = 69;
            this.labelCurs.Text = "Nume curs";
            // 
            // lblIndexFac
            // 
            this.lblIndexFac.AutoSize = true;
            this.lblIndexFac.Location = new System.Drawing.Point(419, 510);
            this.lblIndexFac.Name = "lblIndexFac";
            this.lblIndexFac.Size = new System.Drawing.Size(0, 16);
            this.lblIndexFac.TabIndex = 37;
            // 
            // ButtonAnuleaza
            // 
            this.ButtonAnuleaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ButtonAnuleaza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAnuleaza.FlatAppearance.BorderSize = 0;
            this.ButtonAnuleaza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonAnuleaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonAnuleaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnuleaza.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAnuleaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.ButtonAnuleaza.Location = new System.Drawing.Point(416, 656);
            this.ButtonAnuleaza.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonAnuleaza.Name = "ButtonAnuleaza";
            this.ButtonAnuleaza.Size = new System.Drawing.Size(255, 50);
            this.ButtonAnuleaza.TabIndex = 46;
            this.ButtonAnuleaza.Text = "Anuleaza";
            this.ButtonAnuleaza.UseVisualStyleBackColor = false;
            this.ButtonAnuleaza.Click += new System.EventHandler(this.ButtonAnuleaza_Click);
            // 
            // lblAdaugaCurs
            // 
            this.lblAdaugaCurs.AutoSize = true;
            this.lblAdaugaCurs.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAdaugaCurs.Location = new System.Drawing.Point(296, 22);
            this.lblAdaugaCurs.Name = "lblAdaugaCurs";
            this.lblAdaugaCurs.Size = new System.Drawing.Size(184, 26);
            this.lblAdaugaCurs.TabIndex = 43;
            this.lblAdaugaCurs.Text = "ADAUGA CURS";
            // 
            // ButtonAdauga
            // 
            this.ButtonAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ButtonAdauga.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonAdauga.FlatAppearance.BorderSize = 0;
            this.ButtonAdauga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonAdauga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdauga.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdauga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.ButtonAdauga.Location = new System.Drawing.Point(131, 656);
            this.ButtonAdauga.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonAdauga.Name = "ButtonAdauga";
            this.ButtonAdauga.Size = new System.Drawing.Size(255, 50);
            this.ButtonAdauga.TabIndex = 42;
            this.ButtonAdauga.Text = "Adauga";
            this.ButtonAdauga.UseVisualStyleBackColor = false;
            this.ButtonAdauga.Click += new System.EventHandler(this.ButtonAdauga_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.HeaderPanel);
            this.panel1.Controls.Add(this.lblIndexFac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(800, 900);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelIntervalStart);
            this.panel2.Controls.Add(this.textBoxFinalIntervalOrar);
            this.panel2.Controls.Add(this.comboBoxFacultati);
            this.panel2.Controls.Add(this.labelFacultate);
            this.panel2.Controls.Add(this.comboBoxTip);
            this.panel2.Controls.Add(this.labelTip);
            this.panel2.Controls.Add(this.textBoxProfesor);
            this.panel2.Controls.Add(this.labelProfesor);
            this.panel2.Controls.Add(this.textBoxSala);
            this.panel2.Controls.Add(this.labelSala);
            this.panel2.Controls.Add(this.textBoxSaptamani);
            this.panel2.Controls.Add(this.labelSaptamani);
            this.panel2.Controls.Add(this.textBoxInceputIntervalOrar);
            this.panel2.Controls.Add(this.labelIntervalOrar);
            this.panel2.Controls.Add(this.textBoxNumeCurs);
            this.panel2.Controls.Add(this.labelCurs);
            this.panel2.Controls.Add(this.ButtonAnuleaza);
            this.panel2.Controls.Add(this.lblAdaugaCurs);
            this.panel2.Controls.Add(this.ButtonAdauga);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 767);
            this.panel2.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 86;
            this.label2.Text = "Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = ":";
            // 
            // labelIntervalStart
            // 
            this.labelIntervalStart.AutoSize = true;
            this.labelIntervalStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntervalStart.Location = new System.Drawing.Point(280, 155);
            this.labelIntervalStart.Name = "labelIntervalStart";
            this.labelIntervalStart.Size = new System.Drawing.Size(76, 25);
            this.labelIntervalStart.TabIndex = 84;
            this.labelIntervalStart.Text = "Inceput";
            // 
            // textBoxFinalIntervalOrar
            // 
            this.textBoxFinalIntervalOrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFinalIntervalOrar.Location = new System.Drawing.Point(406, 184);
            this.textBoxFinalIntervalOrar.Name = "textBoxFinalIntervalOrar";
            this.textBoxFinalIntervalOrar.Size = new System.Drawing.Size(101, 26);
            this.textBoxFinalIntervalOrar.TabIndex = 83;
            // 
            // comboBoxFacultati
            // 
            this.comboBoxFacultati.FormattingEnabled = true;
            this.comboBoxFacultati.Location = new System.Drawing.Point(285, 569);
            this.comboBoxFacultati.Name = "comboBoxFacultati";
            this.comboBoxFacultati.Size = new System.Drawing.Size(222, 24);
            this.comboBoxFacultati.TabIndex = 82;
            // 
            // labelFacultate
            // 
            this.labelFacultate.AutoSize = true;
            this.labelFacultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacultate.Location = new System.Drawing.Point(280, 540);
            this.labelFacultate.Name = "labelFacultate";
            this.labelFacultate.Size = new System.Drawing.Size(92, 25);
            this.labelFacultate.TabIndex = 81;
            this.labelFacultate.Text = "Facultate";
            // 
            // Form_Adauga_Curs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Adauga_Curs";
            this.Text = "Form_Adauga_Curs";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TextBox textBoxProfesor;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.TextBox textBoxSala;
        private System.Windows.Forms.Label labelSala;
        private System.Windows.Forms.TextBox textBoxSaptamani;
        private System.Windows.Forms.Label labelSaptamani;
        private System.Windows.Forms.TextBox textBoxInceputIntervalOrar;
        private System.Windows.Forms.Label labelIntervalOrar;
        private System.Windows.Forms.TextBox textBoxNumeCurs;
        private System.Windows.Forms.Label labelCurs;
        private System.Windows.Forms.Label lblIndexFac;
        private System.Windows.Forms.Button ButtonAnuleaza;
        private System.Windows.Forms.Label lblAdaugaCurs;
        private System.Windows.Forms.Button ButtonAdauga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxFacultati;
        private System.Windows.Forms.Label labelFacultate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIntervalStart;
        private System.Windows.Forms.TextBox textBoxFinalIntervalOrar;
    }
}