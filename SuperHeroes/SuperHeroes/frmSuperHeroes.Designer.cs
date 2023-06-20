namespace SuperHeroes
{
    partial class frmSuperHeroes
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.pbSuperHeroImage = new System.Windows.Forms.PictureBox();
            this.cboSuperHero = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlterEgo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperHeroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(57, 743);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(255, 52);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(445, 743);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(255, 52);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblURL
            // 
            this.lblURL.BackColor = System.Drawing.Color.Fuchsia;
            this.lblURL.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.ForeColor = System.Drawing.Color.White;
            this.lblURL.Location = new System.Drawing.Point(54, 675);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(646, 47);
            this.lblURL.TabIndex = 4;
            // 
            // lblBio
            // 
            this.lblBio.BackColor = System.Drawing.Color.Fuchsia;
            this.lblBio.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.ForeColor = System.Drawing.Color.White;
            this.lblBio.Location = new System.Drawing.Point(57, 138);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(528, 516);
            this.lblBio.TabIndex = 3;
            // 
            // pbSuperHeroImage
            // 
            this.pbSuperHeroImage.Location = new System.Drawing.Point(624, 138);
            this.pbSuperHeroImage.Name = "pbSuperHeroImage";
            this.pbSuperHeroImage.Size = new System.Drawing.Size(519, 516);
            this.pbSuperHeroImage.TabIndex = 4;
            this.pbSuperHeroImage.TabStop = false;
            // 
            // cboSuperHero
            // 
            this.cboSuperHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuperHero.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuperHero.FormattingEnabled = true;
            this.cboSuperHero.Location = new System.Drawing.Point(64, 12);
            this.cboSuperHero.Name = "cboSuperHero";
            this.cboSuperHero.Size = new System.Drawing.Size(521, 45);
            this.cboSuperHero.TabIndex = 0;
            this.cboSuperHero.SelectedIndexChanged += new System.EventHandler(this.cboSuperHero_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Fuchsia;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(66, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(519, 47);
            this.lblName.TabIndex = 5;
            // 
            // lblAlterEgo
            // 
            this.lblAlterEgo.BackColor = System.Drawing.Color.Fuchsia;
            this.lblAlterEgo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterEgo.ForeColor = System.Drawing.Color.White;
            this.lblAlterEgo.Location = new System.Drawing.Point(624, 78);
            this.lblAlterEgo.Name = "lblAlterEgo";
            this.lblAlterEgo.Size = new System.Drawing.Size(519, 47);
            this.lblAlterEgo.TabIndex = 6;
            // 
            // frmSuperHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1167, 807);
            this.Controls.Add(this.lblAlterEgo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboSuperHero);
            this.Controls.Add(this.pbSuperHeroImage);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Name = "frmSuperHeroes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSuperHeroes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuperHeroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.PictureBox pbSuperHeroImage;
        private System.Windows.Forms.ComboBox cboSuperHero;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAlterEgo;
    }
}

