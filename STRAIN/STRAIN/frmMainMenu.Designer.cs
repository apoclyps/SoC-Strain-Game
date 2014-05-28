namespace STRAIN
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMainButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMission = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnDNA = new System.Windows.Forms.Button();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.txtSelectedText = new System.Windows.Forms.TextBox();
            this.pbMute = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblRules1 = new System.Windows.Forms.Label();
            this.lblRules2 = new System.Windows.Forms.Label();
            this.lblRules3 = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblScatter = new System.Windows.Forms.Label();
            this.lblBlinker = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.PbScatter = new System.Windows.Forms.PictureBox();
            this.pbBlinker = new System.Windows.Forms.PictureBox();
            this.pbBlock = new System.Windows.Forms.PictureBox();
            this.lblBlockDes = new System.Windows.Forms.Label();
            this.lblBlinkerDes = new System.Windows.Forms.Label();
            this.lblScatterDes = new System.Windows.Forms.Label();
            this.pnlMainButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbScatter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlinker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Coalition", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "STRAIN";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Font = new System.Drawing.Font("Coalition", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(48, 108);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.Font = new System.Drawing.Font("Coalition", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(48, 364);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlMainButtons
            // 
            this.pnlMainButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainButtons.Controls.Add(this.label1);
            this.pnlMainButtons.Controls.Add(this.btnMission);
            this.pnlMainButtons.Controls.Add(this.btnRules);
            this.pnlMainButtons.Controls.Add(this.btnDNA);
            this.pnlMainButtons.Controls.Add(this.btnExit);
            this.pnlMainButtons.Controls.Add(this.btnStart);
            this.pnlMainButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainButtons.Location = new System.Drawing.Point(0, 64);
            this.pnlMainButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainButtons.Name = "pnlMainButtons";
            this.pnlMainButtons.Size = new System.Drawing.Size(278, 505);
            this.pnlMainButtons.TabIndex = 2;
            this.pnlMainButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainButtons_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Coalition", 7.753846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = " by Kyle Harrison";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnMission
            // 
            this.btnMission.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMission.Font = new System.Drawing.Font("Coalition", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMission.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMission.Location = new System.Drawing.Point(48, 172);
            this.btnMission.Margin = new System.Windows.Forms.Padding(4);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(160, 49);
            this.btnMission.TabIndex = 6;
            this.btnMission.Text = "&Mission";
            this.btnMission.UseVisualStyleBackColor = false;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRules.Font = new System.Drawing.Font("Coalition", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRules.Location = new System.Drawing.Point(48, 236);
            this.btnRules.Margin = new System.Windows.Forms.Padding(4);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(160, 49);
            this.btnRules.TabIndex = 5;
            this.btnRules.Text = "&Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnDNA
            // 
            this.btnDNA.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDNA.Font = new System.Drawing.Font("Coalition", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDNA.Location = new System.Drawing.Point(48, 300);
            this.btnDNA.Margin = new System.Windows.Forms.Padding(4);
            this.btnDNA.Name = "btnDNA";
            this.btnDNA.Size = new System.Drawing.Size(160, 49);
            this.btnDNA.TabIndex = 4;
            this.btnDNA.Text = "&DNA";
            this.btnDNA.UseVisualStyleBackColor = false;
            this.btnDNA.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectedTitle.Location = new System.Drawing.Point(387, 76);
            this.lblSelectedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(312, 36);
            this.lblSelectedTitle.TabIndex = 4;
            this.lblSelectedTitle.Text = "Ground Zero";
            // 
            // txtSelectedText
            // 
            this.txtSelectedText.BackColor = System.Drawing.Color.Black;
            this.txtSelectedText.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedText.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSelectedText.Location = new System.Drawing.Point(303, 165);
            this.txtSelectedText.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectedText.Multiline = true;
            this.txtSelectedText.Name = "txtSelectedText";
            this.txtSelectedText.Size = new System.Drawing.Size(576, 312);
            this.txtSelectedText.TabIndex = 5;
            this.txtSelectedText.Text = "\r\n   < Enter Scientist name to initiate \r\n\r\n\r\n   < Mission Protocols\r\n\r\n\r\n   < DN" +
    "A Mutation Laws\r\n\r\n\r\n   < Strain DNA structures\r\n\r\n\r\n   < Abort Mission\r\n";
            // 
            // pbMute
            // 
            this.pbMute.BackColor = System.Drawing.Color.Transparent;
            this.pbMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMute.BackgroundImage")));
            this.pbMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMute.Location = new System.Drawing.Point(808, 492);
            this.pbMute.Margin = new System.Windows.Forms.Padding(4);
            this.pbMute.Name = "pbMute";
            this.pbMute.Size = new System.Drawing.Size(73, 57);
            this.pbMute.TabIndex = 6;
            this.pbMute.TabStop = false;
            this.pbMute.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayer.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPlayer.Location = new System.Drawing.Point(304, 502);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(245, 36);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Scientist :";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.Black;
            this.txtPlayerName.Font = new System.Drawing.Font("Coalition", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtPlayerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPlayerName.Location = new System.Drawing.Point(555, 501);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(237, 42);
            this.txtPlayerName.TabIndex = 11;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblRules1
            // 
            this.lblRules1.AutoSize = true;
            this.lblRules1.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRules1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRules1.Location = new System.Drawing.Point(311, 170);
            this.lblRules1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules1.Name = "lblRules1";
            this.lblRules1.Size = new System.Drawing.Size(266, 19);
            this.lblRules1.TabIndex = 12;
            this.lblRules1.Text = "Living Cells [ White ]";
            this.lblRules1.Visible = false;
            // 
            // lblRules2
            // 
            this.lblRules2.AutoSize = true;
            this.lblRules2.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRules2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRules2.Location = new System.Drawing.Point(311, 282);
            this.lblRules2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules2.Name = "lblRules2";
            this.lblRules2.Size = new System.Drawing.Size(277, 19);
            this.lblRules2.TabIndex = 13;
            this.lblRules2.Text = "Netural Cells [ Blue ]";
            this.lblRules2.Visible = false;
            // 
            // lblRules3
            // 
            this.lblRules3.AutoSize = true;
            this.lblRules3.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRules3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRules3.Location = new System.Drawing.Point(312, 354);
            this.lblRules3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules3.Name = "lblRules3";
            this.lblRules3.Size = new System.Drawing.Size(239, 19);
            this.lblRules3.TabIndex = 14;
            this.lblRules3.Text = "Virus Cells [ Red ] ";
            this.lblRules3.Visible = false;
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMission.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMission.Location = new System.Drawing.Point(310, 170);
            this.lblMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(100, 19);
            this.lblMission.TabIndex = 15;
            this.lblMission.Text = "Mission";
            this.lblMission.Visible = false;
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObjective.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblObjective.Location = new System.Drawing.Point(309, 322);
            this.lblObjective.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(127, 19);
            this.lblObjective.TabIndex = 16;
            this.lblObjective.Text = "Objective";
            this.lblObjective.Visible = false;
            // 
            // lblScatter
            // 
            this.lblScatter.AutoSize = true;
            this.lblScatter.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblScatter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScatter.Location = new System.Drawing.Point(680, 176);
            this.lblScatter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScatter.Name = "lblScatter";
            this.lblScatter.Size = new System.Drawing.Size(168, 19);
            this.lblScatter.TabIndex = 24;
            this.lblScatter.Text = "Scatter DNA";
            this.lblScatter.Visible = false;
            // 
            // lblBlinker
            // 
            this.lblBlinker.AutoSize = true;
            this.lblBlinker.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBlinker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBlinker.Location = new System.Drawing.Point(503, 175);
            this.lblBlinker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlinker.Name = "lblBlinker";
            this.lblBlinker.Size = new System.Drawing.Size(158, 19);
            this.lblBlinker.TabIndex = 23;
            this.lblBlinker.Text = "Blinker DNA";
            this.lblBlinker.Visible = false;
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBlock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBlock.Location = new System.Drawing.Point(327, 175);
            this.lblBlock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(137, 19);
            this.lblBlock.TabIndex = 22;
            this.lblBlock.Text = "Block DNA";
            this.lblBlock.Visible = false;
            // 
            // PbScatter
            // 
            this.PbScatter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbScatter.BackgroundImage")));
            this.PbScatter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbScatter.Location = new System.Drawing.Point(683, 215);
            this.PbScatter.Margin = new System.Windows.Forms.Padding(4);
            this.PbScatter.Name = "PbScatter";
            this.PbScatter.Size = new System.Drawing.Size(133, 111);
            this.PbScatter.TabIndex = 21;
            this.PbScatter.TabStop = false;
            this.PbScatter.Visible = false;
            // 
            // pbBlinker
            // 
            this.pbBlinker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBlinker.BackgroundImage")));
            this.pbBlinker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBlinker.Location = new System.Drawing.Point(512, 214);
            this.pbBlinker.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlinker.Name = "pbBlinker";
            this.pbBlinker.Size = new System.Drawing.Size(133, 111);
            this.pbBlinker.TabIndex = 20;
            this.pbBlinker.TabStop = false;
            this.pbBlinker.Visible = false;
            // 
            // pbBlock
            // 
            this.pbBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBlock.BackgroundImage")));
            this.pbBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBlock.Location = new System.Drawing.Point(341, 212);
            this.pbBlock.Margin = new System.Windows.Forms.Padding(4);
            this.pbBlock.Name = "pbBlock";
            this.pbBlock.Size = new System.Drawing.Size(133, 111);
            this.pbBlock.TabIndex = 19;
            this.pbBlock.TabStop = false;
            this.pbBlock.Visible = false;
            // 
            // lblBlockDes
            // 
            this.lblBlockDes.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBlockDes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBlockDes.Location = new System.Drawing.Point(333, 340);
            this.lblBlockDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlockDes.Name = "lblBlockDes";
            this.lblBlockDes.Size = new System.Drawing.Size(133, 130);
            this.lblBlockDes.TabIndex = 25;
            this.lblBlockDes.Text = "Stable Mutation  - Remains Static";
            this.lblBlockDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlockDes.Visible = false;
            this.lblBlockDes.Click += new System.EventHandler(this.lblBlockDes_Click);
            // 
            // lblBlinkerDes
            // 
            this.lblBlinkerDes.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBlinkerDes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBlinkerDes.Location = new System.Drawing.Point(504, 340);
            this.lblBlinkerDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlinkerDes.Name = "lblBlinkerDes";
            this.lblBlinkerDes.Size = new System.Drawing.Size(155, 130);
            this.lblBlinkerDes.TabIndex = 26;
            this.lblBlinkerDes.Text = "Stable Mutation   - Fluxuates states";
            this.lblBlinkerDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlinkerDes.Visible = false;
            this.lblBlinkerDes.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblScatterDes
            // 
            this.lblScatterDes.Font = new System.Drawing.Font("Coalition", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblScatterDes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblScatterDes.Location = new System.Drawing.Point(683, 340);
            this.lblScatterDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScatterDes.Name = "lblScatterDes";
            this.lblScatterDes.Size = new System.Drawing.Size(169, 130);
            this.lblScatterDes.TabIndex = 27;
            this.lblScatterDes.Text = "Unstable Mutation          -      Chaotic Evolution";
            this.lblScatterDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScatterDes.Visible = false;
            this.lblScatterDes.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 569);
            this.Controls.Add(this.lblScatterDes);
            this.Controls.Add(this.lblBlinkerDes);
            this.Controls.Add(this.lblBlockDes);
            this.Controls.Add(this.lblScatter);
            this.Controls.Add(this.lblBlinker);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.PbScatter);
            this.Controls.Add(this.pbBlinker);
            this.Controls.Add(this.pbBlock);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblRules3);
            this.Controls.Add(this.lblRules2);
            this.Controls.Add(this.lblRules1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.pbMute);
            this.Controls.Add(this.txtSelectedText);
            this.Controls.Add(this.lblSelectedTitle);
            this.Controls.Add(this.pnlMainButtons);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "STRAIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlMainButtons.ResumeLayout(false);
            this.pnlMainButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbScatter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlinker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlMainButtons;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.TextBox txtSelectedText;
        private System.Windows.Forms.PictureBox pbMute;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblRules1;
        private System.Windows.Forms.Label lblRules2;
        private System.Windows.Forms.Label lblRules3;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Button btnDNA;
        private System.Windows.Forms.Label lblScatter;
        private System.Windows.Forms.Label lblBlinker;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.PictureBox PbScatter;
        private System.Windows.Forms.PictureBox pbBlinker;
        private System.Windows.Forms.PictureBox pbBlock;
        private System.Windows.Forms.Label lblBlockDes;
        private System.Windows.Forms.Label lblBlinkerDes;
        private System.Windows.Forms.Label lblScatterDes;
        private System.Windows.Forms.Label label1;

    }
}

