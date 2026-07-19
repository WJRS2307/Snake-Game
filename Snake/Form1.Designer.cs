namespace Snake
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
            this.boardPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.highscore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(10, 11);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(433, 282);
            this.boardPanel.TabIndex = 19;
            this.boardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPanel_Paint);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.controlPanel.BackgroundImage = global::Snake.Properties.Resources._4434748;
            this.controlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.exit);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.name);
            this.controlPanel.Controls.Add(this.highscore);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Location = new System.Drawing.Point(9, 298);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(450, 187);
            this.controlPanel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Made by Sean 201850J";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // exit
            // 
            this.exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Location = new System.Drawing.Point(345, 98);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 32);
            this.exit.TabIndex = 33;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(172, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Direction : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Timer : ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(104, 16);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 25);
            this.name.TabIndex = 29;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // highscore
            // 
            this.highscore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.highscore.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.highscore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.highscore.Location = new System.Drawing.Point(226, 104);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(103, 32);
            this.highscore.TabIndex = 28;
            this.highscore.Text = "Highscore";
            this.highscore.UseVisualStyleBackColor = false;
            this.highscore.Click += new System.EventHandler(this.highscore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level : ";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.levelLBL.Location = new System.Drawing.Point(260, 16);
            this.levelLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(25, 27);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(322, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score : ";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLBL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.scoreLBL.Location = new System.Drawing.Point(411, 16);
            this.scoreLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(25, 27);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "0";
            // 
            // pauseBTN
            // 
            this.pauseBTN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pauseBTN.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBTN.Location = new System.Drawing.Point(128, 98);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(74, 38);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "PAUSE";
            this.pauseBTN.UseVisualStyleBackColor = false;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.startBTN.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startBTN.Location = new System.Drawing.Point(19, 98);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(79, 38);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "START";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.modeLBL.Location = new System.Drawing.Point(290, 57);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(87, 25);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "modeLBL";
            this.modeLBL.Click += new System.EventHandler(this.modeLBL_Click);
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.timerLBL.Location = new System.Drawing.Point(106, 55);
            this.timerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(25, 27);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "0";
            this.timerLBL.Click += new System.EventHandler(this.timerLBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(465, 490);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game By Sean";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button highscore;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label6;
    }
}

