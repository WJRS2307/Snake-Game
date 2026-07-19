
namespace Snake
{
    partial class userinput
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
            this.name = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(27, 67);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 25);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(88, 73);
            this.input.Margin = new System.Windows.Forms.Padding(2);
            this.input.MaximumSize = new System.Drawing.Size(114, 50);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(74, 20);
            this.input.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(105, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(304, 251);
            this.Name = "userinput";
            this.Text = "userinput";
            this.Load += new System.EventHandler(this.userinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
    }
}