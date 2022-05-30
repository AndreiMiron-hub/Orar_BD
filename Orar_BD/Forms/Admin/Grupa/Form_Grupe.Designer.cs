namespace Orar_BD
{
    partial class Form_Grupe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Grupe));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel_Dash_Menu = new System.Windows.Forms.Panel();
            this.labelMeniu = new System.Windows.Forms.Label();
            this.Button_Sterge = new System.Windows.Forms.Button();
            this.Button_Modificare = new System.Windows.Forms.Button();
            this.Button_Adaugare = new System.Windows.Forms.Button();
            this.Button_Afisare = new System.Windows.Forms.Button();
            this.dataGridDashboard = new System.Windows.Forms.DataGridView();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Dash_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDashboard)).BeginInit();
            this.SuspendLayout();
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
            this.HeaderPanel.Size = new System.Drawing.Size(1150, 120);
            this.HeaderPanel.TabIndex = 16;
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
            // ButtonBack
            // 
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Wingdings 3", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonBack.Location = new System.Drawing.Point(1030, 12);
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
            this.ButtonExit.Location = new System.Drawing.Point(1082, 12);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "r";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel_Dash_Menu
            // 
            this.panel_Dash_Menu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel_Dash_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(84)))));
            this.panel_Dash_Menu.Controls.Add(this.labelMeniu);
            this.panel_Dash_Menu.Controls.Add(this.Button_Sterge);
            this.panel_Dash_Menu.Controls.Add(this.Button_Modificare);
            this.panel_Dash_Menu.Controls.Add(this.Button_Adaugare);
            this.panel_Dash_Menu.Controls.Add(this.Button_Afisare);
            this.panel_Dash_Menu.Location = new System.Drawing.Point(0, 116);
            this.panel_Dash_Menu.Name = "panel_Dash_Menu";
            this.panel_Dash_Menu.Size = new System.Drawing.Size(210, 686);
            this.panel_Dash_Menu.TabIndex = 18;
            // 
            // labelMeniu
            // 
            this.labelMeniu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMeniu.AutoSize = true;
            this.labelMeniu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeniu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMeniu.Location = new System.Drawing.Point(61, 30);
            this.labelMeniu.Name = "labelMeniu";
            this.labelMeniu.Size = new System.Drawing.Size(89, 25);
            this.labelMeniu.TabIndex = 17;
            this.labelMeniu.Text = "GRUPE";
            // 
            // Button_Sterge
            // 
            this.Button_Sterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Sterge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Sterge.FlatAppearance.BorderSize = 0;
            this.Button_Sterge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Sterge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Sterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Sterge.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Sterge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Sterge.Location = new System.Drawing.Point(1, 325);
            this.Button_Sterge.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Sterge.Name = "Button_Sterge";
            this.Button_Sterge.Size = new System.Drawing.Size(210, 50);
            this.Button_Sterge.TabIndex = 16;
            this.Button_Sterge.Text = "Sterge";
            this.Button_Sterge.UseVisualStyleBackColor = false;
            this.Button_Sterge.Click += new System.EventHandler(this.Button_Sterge_Click);
            // 
            // Button_Modificare
            // 
            this.Button_Modificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Modificare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Modificare.FlatAppearance.BorderSize = 0;
            this.Button_Modificare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Modificare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Modificare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Modificare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Modificare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Modificare.Location = new System.Drawing.Point(1, 245);
            this.Button_Modificare.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Modificare.Name = "Button_Modificare";
            this.Button_Modificare.Size = new System.Drawing.Size(209, 50);
            this.Button_Modificare.TabIndex = 15;
            this.Button_Modificare.Text = "Modifica";
            this.Button_Modificare.UseVisualStyleBackColor = false;
            this.Button_Modificare.Click += new System.EventHandler(this.Button_Modificare_Click);
            // 
            // Button_Adaugare
            // 
            this.Button_Adaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Adaugare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Adaugare.FlatAppearance.BorderSize = 0;
            this.Button_Adaugare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Adaugare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Adaugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Adaugare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Adaugare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Adaugare.Location = new System.Drawing.Point(1, 165);
            this.Button_Adaugare.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Adaugare.Name = "Button_Adaugare";
            this.Button_Adaugare.Size = new System.Drawing.Size(208, 50);
            this.Button_Adaugare.TabIndex = 14;
            this.Button_Adaugare.Text = "Adauga";
            this.Button_Adaugare.UseVisualStyleBackColor = false;
            this.Button_Adaugare.Click += new System.EventHandler(this.Button_Adaugare_Click);
            // 
            // Button_Afisare
            // 
            this.Button_Afisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Button_Afisare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Button_Afisare.FlatAppearance.BorderSize = 0;
            this.Button_Afisare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Button_Afisare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.Button_Afisare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Afisare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Afisare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.Button_Afisare.Location = new System.Drawing.Point(0, 85);
            this.Button_Afisare.Margin = new System.Windows.Forms.Padding(1);
            this.Button_Afisare.Name = "Button_Afisare";
            this.Button_Afisare.Size = new System.Drawing.Size(209, 50);
            this.Button_Afisare.TabIndex = 13;
            this.Button_Afisare.Text = "Afiseaza";
            this.Button_Afisare.UseVisualStyleBackColor = false;
            this.Button_Afisare.Click += new System.EventHandler(this.Button_Afisare_Click);
            // 
            // dataGridDashboard
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDashboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDashboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.dataGridDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDashboard.Location = new System.Drawing.Point(242, 179);
            this.dataGridDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDashboard.Name = "dataGridDashboard";
            this.dataGridDashboard.RowHeadersWidth = 51;
            this.dataGridDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDashboard.Size = new System.Drawing.Size(895, 461);
            this.dataGridDashboard.TabIndex = 17;
            // 
            // Form_Grupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel_Dash_Menu);
            this.Controls.Add(this.dataGridDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Grupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Grupe";
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Dash_Menu.ResumeLayout(false);
            this.panel_Dash_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel_Dash_Menu;
        private System.Windows.Forms.Label labelMeniu;
        private System.Windows.Forms.Button Button_Sterge;
        private System.Windows.Forms.Button Button_Modificare;
        private System.Windows.Forms.Button Button_Adaugare;
        private System.Windows.Forms.Button Button_Afisare;
        private System.Windows.Forms.DataGridView dataGridDashboard;
    }
}