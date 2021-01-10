namespace BJGU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlayerPointsLabel = new System.Windows.Forms.Label();
            this.PlayerWallet = new System.Windows.Forms.Label();
            this.OppPointsLabel = new System.Windows.Forms.Label();
            this.OppWallet = new System.Windows.Forms.Label();
            this.OppCardsLabel = new System.Windows.Forms.Label();
            this.PlayerCardsLabel = new System.Windows.Forms.Label();
            this.DealButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DealCash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rULESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "BLACKJACK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(62, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 77);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.BackgroundImage = global::BJGU.Properties.Resources.bjtab;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PlayerPointsLabel);
            this.panel2.Controls.Add(this.PlayerWallet);
            this.panel2.Controls.Add(this.OppPointsLabel);
            this.panel2.Controls.Add(this.OppWallet);
            this.panel2.Controls.Add(this.OppCardsLabel);
            this.panel2.Controls.Add(this.PlayerCardsLabel);
            this.panel2.Controls.Add(this.DealButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DealCash);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 418);
            this.panel2.TabIndex = 3;
            // 
            // PlayerPointsLabel
            // 
            this.PlayerPointsLabel.AutoSize = true;
            this.PlayerPointsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerPointsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerPointsLabel.Location = new System.Drawing.Point(226, 279);
            this.PlayerPointsLabel.Name = "PlayerPointsLabel";
            this.PlayerPointsLabel.Size = new System.Drawing.Size(0, 17);
            this.PlayerPointsLabel.TabIndex = 13;
            this.PlayerPointsLabel.Visible = false;
            this.PlayerPointsLabel.Click += new System.EventHandler(this.PlayerPointsLabel_Click);
            // 
            // PlayerWallet
            // 
            this.PlayerWallet.AutoSize = true;
            this.PlayerWallet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWallet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerWallet.Location = new System.Drawing.Point(248, 246);
            this.PlayerWallet.Name = "PlayerWallet";
            this.PlayerWallet.Size = new System.Drawing.Size(16, 18);
            this.PlayerWallet.TabIndex = 12;
            this.PlayerWallet.Text = "0";
            // 
            // OppPointsLabel
            // 
            this.OppPointsLabel.AutoSize = true;
            this.OppPointsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OppPointsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OppPointsLabel.Location = new System.Drawing.Point(226, 154);
            this.OppPointsLabel.Name = "OppPointsLabel";
            this.OppPointsLabel.Size = new System.Drawing.Size(0, 17);
            this.OppPointsLabel.TabIndex = 11;
            this.OppPointsLabel.Visible = false;
            // 
            // OppWallet
            // 
            this.OppWallet.AutoSize = true;
            this.OppWallet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OppWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppWallet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OppWallet.Location = new System.Drawing.Point(248, 115);
            this.OppWallet.Name = "OppWallet";
            this.OppWallet.Size = new System.Drawing.Size(16, 18);
            this.OppWallet.TabIndex = 10;
            this.OppWallet.Text = "0";
            // 
            // OppCardsLabel
            // 
            this.OppCardsLabel.AutoSize = true;
            this.OppCardsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OppCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppCardsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OppCardsLabel.Location = new System.Drawing.Point(408, 11);
            this.OppCardsLabel.Name = "OppCardsLabel";
            this.OppCardsLabel.Size = new System.Drawing.Size(147, 24);
            this.OppCardsLabel.TabIndex = 9;
            this.OppCardsLabel.Text = "Computer Cards";
            // 
            // PlayerCardsLabel
            // 
            this.PlayerCardsLabel.AutoSize = true;
            this.PlayerCardsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerCardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCardsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayerCardsLabel.Location = new System.Drawing.Point(426, 166);
            this.PlayerCardsLabel.Name = "PlayerCardsLabel";
            this.PlayerCardsLabel.Size = new System.Drawing.Size(116, 24);
            this.PlayerCardsLabel.TabIndex = 8;
            this.PlayerCardsLabel.Text = "Player Cards";
            // 
            // DealButton
            // 
            this.DealButton.Enabled = false;
            this.DealButton.Location = new System.Drawing.Point(679, 347);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(180, 48);
            this.DealButton.TabIndex = 2;
            this.DealButton.Text = "DEAL";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(164, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter bet amount\r\n\r\n";
            // 
            // DealCash
            // 
            this.DealCash.Enabled = false;
            this.DealCash.Location = new System.Drawing.Point(358, 362);
            this.DealCash.Name = "DealCash";
            this.DealCash.Size = new System.Drawing.Size(253, 22);
            this.DealCash.TabIndex = 6;
            this.DealCash.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(225, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Computer";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.StopButton);
            this.panel3.Controls.Add(this.HitButton);
            this.panel3.Location = new System.Drawing.Point(1, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 76);
            this.panel3.TabIndex = 0;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(540, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(287, 43);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Location = new System.Drawing.Point(149, 12);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(304, 43);
            this.HitButton.TabIndex = 0;
            this.HitButton.Text = "HIT";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGAToolStripMenuItem,
            this.rULESToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.fILEToolStripMenuItem.Text = "MENU";
            // 
            // nEWGAToolStripMenuItem
            // 
            this.nEWGAToolStripMenuItem.Name = "nEWGAToolStripMenuItem";
            this.nEWGAToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.nEWGAToolStripMenuItem.Text = "NEW GAME";
            this.nEWGAToolStripMenuItem.Click += new System.EventHandler(this.nEWGAToolStripMenuItem_Click);
            // 
            // rULESToolStripMenuItem
            // 
            this.rULESToolStripMenuItem.Name = "rULESToolStripMenuItem";
            this.rULESToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.rULESToolStripMenuItem.Text = "RULES";
            this.rULESToolStripMenuItem.Click += new System.EventHandler(this.rULESToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 43);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(226, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(226, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rULESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox DealCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Label OppCardsLabel;
        private System.Windows.Forms.Label PlayerCardsLabel;
        private System.Windows.Forms.Label PlayerPointsLabel;
        private System.Windows.Forms.Label PlayerWallet;
        private System.Windows.Forms.Label OppPointsLabel;
        private System.Windows.Forms.Label OppWallet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}

