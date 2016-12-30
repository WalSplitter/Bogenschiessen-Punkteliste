namespace Schießzettel
{
    partial class Form2
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
            this.player_lb = new System.Windows.Forms.Label();
            this.player_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.existingPl_chk = new System.Windows.Forms.CheckBox();
            this.score_lb = new System.Windows.Forms.Label();
            this.count_lb = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player_lb
            // 
            this.player_lb.AutoSize = true;
            this.player_lb.Location = new System.Drawing.Point(34, 26);
            this.player_lb.Name = "player_lb";
            this.player_lb.Size = new System.Drawing.Size(39, 13);
            this.player_lb.TabIndex = 0;
            this.player_lb.Text = "Player:";
            // 
            // player_tb
            // 
            this.player_tb.Location = new System.Drawing.Point(168, 26);
            this.player_tb.Name = "player_tb";
            this.player_tb.Size = new System.Drawing.Size(351, 20);
            this.player_tb.TabIndex = 1;
            this.player_tb.TextChanged += new System.EventHandler(this.player_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use existing Player";
            // 
            // existingPl_chk
            // 
            this.existingPl_chk.AutoSize = true;
            this.existingPl_chk.Location = new System.Drawing.Point(168, 56);
            this.existingPl_chk.Name = "existingPl_chk";
            this.existingPl_chk.Size = new System.Drawing.Size(15, 14);
            this.existingPl_chk.TabIndex = 3;
            this.existingPl_chk.UseVisualStyleBackColor = true;
            this.existingPl_chk.CheckedChanged += new System.EventHandler(this.existingPl_chk_CheckedChanged);
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Location = new System.Drawing.Point(34, 115);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(55, 13);
            this.score_lb.TabIndex = 5;
            this.score_lb.Text = "Highscore";
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(213, 115);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(83, 13);
            this.count_lb.TabIndex = 6;
            this.count_lb.Text = "Count of Games";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(415, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 76);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(216, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 17);
            this.listBox1.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 214);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.existingPl_chk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player_tb);
            this.Controls.Add(this.player_lb);
            this.Name = "Form2";
            this.Text = "Schießzettel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player_lb;
        private System.Windows.Forms.TextBox player_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox existingPl_chk;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}