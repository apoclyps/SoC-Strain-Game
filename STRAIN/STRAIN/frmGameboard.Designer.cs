namespace STRAIN
{
    partial class frmGameboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameboard));
            this.button1 = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGameOptions = new System.Windows.Forms.Panel();
            this.txtMutations = new System.Windows.Forms.TextBox();
            this.lblMutations = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnMutate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGameOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 540);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHighScore.Location = new System.Drawing.Point(23, 25);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(244, 36);
            this.lblHighScore.TabIndex = 1;
            this.lblHighScore.Text = "Highscore";
            // 
            // txtHighScore
            // 
            this.txtHighScore.BackColor = System.Drawing.Color.Black;
            this.txtHighScore.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHighScore.Location = new System.Drawing.Point(29, 62);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(228, 42);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "0";
            this.txtHighScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTime.Location = new System.Drawing.Point(23, 191);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(108, 36);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Black;
            this.txtTime.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTime.Location = new System.Drawing.Point(29, 228);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(228, 42);
            this.txtTime.TabIndex = 4;
            this.txtTime.Text = "0:00";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Coalition", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 64);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "STRAIN";
            // 
            // pnlGameOptions
            // 
            this.pnlGameOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnlGameOptions.Controls.Add(this.txtMutations);
            this.pnlGameOptions.Controls.Add(this.lblMutations);
            this.pnlGameOptions.Controls.Add(this.btnRestart);
            this.pnlGameOptions.Controls.Add(this.btnReturn);
            this.pnlGameOptions.Controls.Add(this.btnMutate);
            this.pnlGameOptions.Controls.Add(this.lblHighScore);
            this.pnlGameOptions.Controls.Add(this.txtHighScore);
            this.pnlGameOptions.Controls.Add(this.txtTime);
            this.pnlGameOptions.Controls.Add(this.lblTime);
            this.pnlGameOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGameOptions.Location = new System.Drawing.Point(641, 0);
            this.pnlGameOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGameOptions.Name = "pnlGameOptions";
            this.pnlGameOptions.Size = new System.Drawing.Size(271, 569);
            this.pnlGameOptions.TabIndex = 6;
            // 
            // txtMutations
            // 
            this.txtMutations.BackColor = System.Drawing.Color.Black;
            this.txtMutations.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtMutations.ForeColor = System.Drawing.Color.White;
            this.txtMutations.Location = new System.Drawing.Point(29, 143);
            this.txtMutations.Margin = new System.Windows.Forms.Padding(4);
            this.txtMutations.Name = "txtMutations";
            this.txtMutations.Size = new System.Drawing.Size(227, 42);
            this.txtMutations.TabIndex = 10;
            this.txtMutations.Text = "0";
            this.txtMutations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMutations
            // 
            this.lblMutations.AutoSize = true;
            this.lblMutations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMutations.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMutations.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMutations.Location = new System.Drawing.Point(16, 106);
            this.lblMutations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMutations.Name = "lblMutations";
            this.lblMutations.Size = new System.Drawing.Size(256, 36);
            this.lblMutations.TabIndex = 9;
            this.lblMutations.Text = "Mutations";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestart.Font = new System.Drawing.Font("Coalition", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestart.Location = new System.Drawing.Point(55, 418);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(160, 49);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReturn.Font = new System.Drawing.Font("Coalition", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReturn.Location = new System.Drawing.Point(53, 480);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 49);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "&Exit";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMutate
            // 
            this.btnMutate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMutate.Font = new System.Drawing.Font("Coalition", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMutate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMutate.Location = new System.Drawing.Point(56, 303);
            this.btnMutate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMutate.Name = "btnMutate";
            this.btnMutate.Size = new System.Drawing.Size(160, 49);
            this.btnMutate.TabIndex = 5;
            this.btnMutate.Text = "&Mutate";
            this.btnMutate.UseVisualStyleBackColor = false;
            this.btnMutate.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.Location = new System.Drawing.Point(69, 11);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(221, 36);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status : ";
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGameStatus.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameStatus.Location = new System.Drawing.Point(285, 12);
            this.lblGameStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(288, 36);
            this.lblGameStatus.TabIndex = 8;
            this.lblGameStatus.Text = "Create DNA";
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblGameStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 82);
            this.panel1.TabIndex = 9;
            // 
            // frmGameboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGameOptions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGameboard";
            this.Text = "STRAIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameboard_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlGameOptions.ResumeLayout(false);
            this.pnlGameOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.TextBox txtHighScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlGameOptions;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMutate;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.TextBox txtMutations;
        private System.Windows.Forms.Label lblMutations;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Panel panel1;

    }
}