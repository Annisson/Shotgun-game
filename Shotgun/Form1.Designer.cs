
namespace Shotgun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.labelYourBullets = new System.Windows.Forms.Label();
            this.textBoxShotsLeft = new System.Windows.Forms.TextBox();
            this.buttonShotgun = new System.Windows.Forms.Button();
            this.labelOpponentsBullets = new System.Windows.Forms.Label();
            this.textBoxOpponentShotsLeft = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelShotgun = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.textBoxPlayerScore = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOpponentScore = new System.Windows.Forms.Label();
            this.textBoxOpponentScore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShoot
            // 
            this.buttonShoot.BackColor = System.Drawing.Color.LightBlue;
            this.buttonShoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShoot.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.buttonShoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShoot.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShoot.Location = new System.Drawing.Point(316, 323);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(83, 36);
            this.buttonShoot.TabIndex = 0;
            this.buttonShoot.TabStop = false;
            this.buttonShoot.Text = "Shoot";
            this.buttonShoot.UseVisualStyleBackColor = false;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.LightBlue;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReload.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReload.Location = new System.Drawing.Point(213, 323);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(83, 36);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.TabStop = false;
            this.buttonReload.Text = "Load";
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.BackColor = System.Drawing.Color.LightBlue;
            this.buttonBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBlock.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.buttonBlock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBlock.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBlock.Location = new System.Drawing.Point(418, 323);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(83, 36);
            this.buttonBlock.TabIndex = 2;
            this.buttonBlock.TabStop = false;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = false;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // labelYourBullets
            // 
            this.labelYourBullets.AutoSize = true;
            this.labelYourBullets.BackColor = System.Drawing.Color.Transparent;
            this.labelYourBullets.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYourBullets.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelYourBullets.Location = new System.Drawing.Point(37, 138);
            this.labelYourBullets.Name = "labelYourBullets";
            this.labelYourBullets.Size = new System.Drawing.Size(99, 18);
            this.labelYourBullets.TabIndex = 3;
            this.labelYourBullets.Text = "Your bullets";
            // 
            // textBoxShotsLeft
            // 
            this.textBoxShotsLeft.BackColor = System.Drawing.Color.Azure;
            this.textBoxShotsLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxShotsLeft.ForeColor = System.Drawing.Color.Black;
            this.textBoxShotsLeft.Location = new System.Drawing.Point(174, 133);
            this.textBoxShotsLeft.Name = "textBoxShotsLeft";
            this.textBoxShotsLeft.ReadOnly = true;
            this.textBoxShotsLeft.Size = new System.Drawing.Size(23, 29);
            this.textBoxShotsLeft.TabIndex = 5;
            this.textBoxShotsLeft.TabStop = false;
            this.textBoxShotsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonShotgun
            // 
            this.buttonShotgun.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonShotgun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShotgun.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.buttonShotgun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShotgun.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShotgun.ForeColor = System.Drawing.Color.Black;
            this.buttonShotgun.Location = new System.Drawing.Point(35, 312);
            this.buttonShotgun.Name = "buttonShotgun";
            this.buttonShotgun.Size = new System.Drawing.Size(145, 47);
            this.buttonShotgun.TabIndex = 6;
            this.buttonShotgun.TabStop = false;
            this.buttonShotgun.Text = "SHOTGUN";
            this.buttonShotgun.UseVisualStyleBackColor = false;
            this.buttonShotgun.Click += new System.EventHandler(this.buttonShotgun_Click);
            // 
            // labelOpponentsBullets
            // 
            this.labelOpponentsBullets.AutoSize = true;
            this.labelOpponentsBullets.BackColor = System.Drawing.Color.Transparent;
            this.labelOpponentsBullets.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpponentsBullets.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelOpponentsBullets.Location = new System.Drawing.Point(12, 89);
            this.labelOpponentsBullets.Name = "labelOpponentsBullets";
            this.labelOpponentsBullets.Size = new System.Drawing.Size(143, 18);
            this.labelOpponentsBullets.TabIndex = 7;
            this.labelOpponentsBullets.Text = "Opponents bullets";
            // 
            // textBoxOpponentShotsLeft
            // 
            this.textBoxOpponentShotsLeft.BackColor = System.Drawing.Color.Azure;
            this.textBoxOpponentShotsLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOpponentShotsLeft.ForeColor = System.Drawing.Color.Black;
            this.textBoxOpponentShotsLeft.Location = new System.Drawing.Point(174, 84);
            this.textBoxOpponentShotsLeft.Name = "textBoxOpponentShotsLeft";
            this.textBoxOpponentShotsLeft.ReadOnly = true;
            this.textBoxOpponentShotsLeft.Size = new System.Drawing.Size(23, 29);
            this.textBoxOpponentShotsLeft.TabIndex = 9;
            this.textBoxOpponentShotsLeft.TabStop = false;
            this.textBoxOpponentShotsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Azure;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(213, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 199);
            this.listBox1.TabIndex = 10;
            this.listBox1.TabStop = false;
            // 
            // labelShotgun
            // 
            this.labelShotgun.AutoSize = true;
            this.labelShotgun.BackColor = System.Drawing.Color.Transparent;
            this.labelShotgun.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelShotgun.ForeColor = System.Drawing.Color.LightBlue;
            this.labelShotgun.Location = new System.Drawing.Point(230, 25);
            this.labelShotgun.Name = "labelShotgun";
            this.labelShotgun.Size = new System.Drawing.Size(252, 32);
            this.labelShotgun.TabIndex = 11;
            this.labelShotgun.Text = "Shotgun Game";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerScore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerScore.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.labelPlayerScore.Location = new System.Drawing.Point(31, 28);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(32, 16);
            this.labelPlayerScore.TabIndex = 13;
            this.labelPlayerScore.Text = "You";
            // 
            // textBoxPlayerScore
            // 
            this.textBoxPlayerScore.BackColor = System.Drawing.Color.Azure;
            this.textBoxPlayerScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlayerScore.ForeColor = System.Drawing.Color.Black;
            this.textBoxPlayerScore.Location = new System.Drawing.Point(23, 47);
            this.textBoxPlayerScore.Name = "textBoxPlayerScore";
            this.textBoxPlayerScore.ReadOnly = true;
            this.textBoxPlayerScore.Size = new System.Drawing.Size(49, 25);
            this.textBoxPlayerScore.TabIndex = 14;
            this.textBoxPlayerScore.TabStop = false;
            this.textBoxPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelOpponentScore);
            this.groupBox1.Controls.Add(this.textBoxOpponentScore);
            this.groupBox1.Controls.Add(this.labelPlayerScore);
            this.groupBox1.Controls.Add(this.textBoxPlayerScore);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 93);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scoreboard";
            // 
            // labelOpponentScore
            // 
            this.labelOpponentScore.AutoSize = true;
            this.labelOpponentScore.BackColor = System.Drawing.Color.Transparent;
            this.labelOpponentScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOpponentScore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpponentScore.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.labelOpponentScore.Location = new System.Drawing.Point(98, 28);
            this.labelOpponentScore.Name = "labelOpponentScore";
            this.labelOpponentScore.Size = new System.Drawing.Size(70, 16);
            this.labelOpponentScore.TabIndex = 16;
            this.labelOpponentScore.Text = "Opponent";
            // 
            // textBoxOpponentScore
            // 
            this.textBoxOpponentScore.BackColor = System.Drawing.Color.Azure;
            this.textBoxOpponentScore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxOpponentScore.ForeColor = System.Drawing.Color.Black;
            this.textBoxOpponentScore.Location = new System.Drawing.Point(109, 47);
            this.textBoxOpponentScore.Name = "textBoxOpponentScore";
            this.textBoxOpponentScore.ReadOnly = true;
            this.textBoxOpponentScore.Size = new System.Drawing.Size(49, 25);
            this.textBoxOpponentScore.TabIndex = 16;
            this.textBoxOpponentScore.TabStop = false;
            this.textBoxOpponentScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shotgun.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelShotgun);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxOpponentShotsLeft);
            this.Controls.Add(this.labelOpponentsBullets);
            this.Controls.Add(this.buttonShotgun);
            this.Controls.Add(this.textBoxShotsLeft);
            this.Controls.Add(this.labelYourBullets);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonShoot);
            this.Name = "Form1";
            this.Text = "Shotgun";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Label labelYourBullets;
        private System.Windows.Forms.TextBox textBoxShotsLeft;
        private System.Windows.Forms.Button buttonShotgun;
        private System.Windows.Forms.Label labelOpponentsBullets;
        private System.Windows.Forms.TextBox textBoxOpponentShotsLeft;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelShotgun;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.TextBox textBoxPlayerScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOpponentScore;
        private System.Windows.Forms.TextBox textBoxOpponentScore;
    }
}

