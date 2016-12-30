namespace Schießzettel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_btn = new System.Windows.Forms.Button();
            this.score_tb = new System.Windows.Forms.TextBox();
            this.score_lb = new System.Windows.Forms.Label();
            this.count_lb = new System.Windows.Forms.Label();
            this.count_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(313, 118);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // score_tb
            // 
            this.score_tb.Location = new System.Drawing.Point(12, 163);
            this.score_tb.Name = "score_tb";
            this.score_tb.ReadOnly = true;
            this.score_tb.Size = new System.Drawing.Size(145, 20);
            this.score_tb.TabIndex = 1;
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Location = new System.Drawing.Point(15, 147);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(55, 13);
            this.score_lb.TabIndex = 2;
            this.score_lb.Text = "Highscore";
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(177, 146);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(83, 13);
            this.count_lb.TabIndex = 3;
            this.count_lb.Text = "Count of Games";
            // 
            // count_tb
            // 
            this.count_tb.Location = new System.Drawing.Point(174, 162);
            this.count_tb.Name = "count_tb";
            this.count_tb.ReadOnly = true;
            this.count_tb.Size = new System.Drawing.Size(151, 20);
            this.count_tb.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 115);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 337);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.count_tb);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Schießzettel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.TextBox count_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

