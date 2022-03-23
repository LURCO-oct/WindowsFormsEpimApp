namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.secteurCC1 = new WindowsFormsApp2.SecteurCC();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnAgc = new System.Windows.Forms.Button();
            this.BtnTic = new System.Windows.Forms.Button();
            this.BtnAcc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.acceuilCC1 = new WindowsFormsApp2.AccréditationCC();
            this.secteurCC2 = new WindowsFormsApp2.SecteurCC();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.secteurCC1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnAgc);
            this.panel1.Controls.Add(this.BtnTic);
            this.panel1.Controls.Add(this.BtnAcc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 811);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secteurCC1
            // 
            this.secteurCC1.Location = new System.Drawing.Point(281, 223);
            this.secteurCC1.Name = "secteurCC1";
            this.secteurCC1.Size = new System.Drawing.Size(1022, 673);
            this.secteurCC1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 49);
            this.panel4.TabIndex = 3;
            // 
            // BtnAgc
            // 
            this.BtnAgc.FlatAppearance.BorderSize = 0;
            this.BtnAgc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgc.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgc.Image")));
            this.BtnAgc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgc.Location = new System.Drawing.Point(67, 298);
            this.BtnAgc.Name = "BtnAgc";
            this.BtnAgc.Size = new System.Drawing.Size(216, 49);
            this.BtnAgc.TabIndex = 6;
            this.BtnAgc.Text = "Sécteur AGC";
            this.BtnAgc.UseVisualStyleBackColor = true;
            // 
            // BtnTic
            // 
            this.BtnTic.FlatAppearance.BorderSize = 0;
            this.BtnTic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTic.Image = ((System.Drawing.Image)(resources.GetObject("BtnTic.Image")));
            this.BtnTic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTic.Location = new System.Drawing.Point(67, 243);
            this.BtnTic.Name = "BtnTic";
            this.BtnTic.Size = new System.Drawing.Size(219, 49);
            this.BtnTic.TabIndex = 5;
            this.BtnTic.Text = "Sécteur TIC";
            this.BtnTic.UseVisualStyleBackColor = true;
            this.BtnTic.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnAcc
            // 
            this.BtnAcc.FlatAppearance.BorderSize = 0;
            this.BtnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAcc.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcc.Image")));
            this.BtnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcc.Location = new System.Drawing.Point(67, 133);
            this.BtnAcc.Name = "BtnAcc";
            this.BtnAcc.Size = new System.Drawing.Size(216, 49);
            this.BtnAcc.TabIndex = 0;
            this.BtnAcc.Text = "Acceuil";
            this.BtnAcc.UseVisualStyleBackColor = true;
            this.BtnAcc.Click += new System.EventHandler(this.BtnAcc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(370, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(878, 107);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // acceuilCC1
            // 
            this.acceuilCC1.Location = new System.Drawing.Point(283, 137);
            this.acceuilCC1.Name = "acceuilCC1";
            this.acceuilCC1.Size = new System.Drawing.Size(1051, 674);
            this.acceuilCC1.TabIndex = 3;
            // 
            // secteurCC2
            // 
            this.secteurCC2.Location = new System.Drawing.Point(283, 137);
            this.secteurCC2.Name = "secteurCC2";
            this.secteurCC2.Size = new System.Drawing.Size(1051, 674);
            this.secteurCC2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(65, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Accréditation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 811);
            this.Controls.Add(this.secteurCC2);
            this.Controls.Add(this.acceuilCC1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnTic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAgc;
        private AccréditationCC acceuilCC1;
        private SecteurCC secteurCC1;
        private System.Windows.Forms.Button button1;
        private SecteurCC secteurCC2;
        private System.Windows.Forms.Button button2;
    }
}

