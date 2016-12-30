namespace Schießzettel
{
    partial class Form3
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
            this.select_btn = new System.Windows.Forms.Button();
            this.countPl_lb = new System.Windows.Forms.Label();
            this.select2_btn = new System.Windows.Forms.Button();
            this.select3_btn = new System.Windows.Forms.Button();
            this.select4_btn = new System.Windows.Forms.Button();
            this.select5_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(12, 89);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(190, 65);
            this.select_btn.TabIndex = 0;
            this.select_btn.Text = "Select Player";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // countPl_lb
            // 
            this.countPl_lb.AutoSize = true;
            this.countPl_lb.Location = new System.Drawing.Point(115, 12);
            this.countPl_lb.Name = "countPl_lb";
            this.countPl_lb.Size = new System.Drawing.Size(84, 13);
            this.countPl_lb.TabIndex = 1;
            this.countPl_lb.Text = "Count of Players";
            // 
            // select2_btn
            // 
            this.select2_btn.Location = new System.Drawing.Point(12, 160);
            this.select2_btn.Name = "select2_btn";
            this.select2_btn.Size = new System.Drawing.Size(190, 65);
            this.select2_btn.TabIndex = 3;
            this.select2_btn.Text = "Select Player";
            this.select2_btn.UseVisualStyleBackColor = true;
            this.select2_btn.Click += new System.EventHandler(this.select2_btn_Click);
            // 
            // select3_btn
            // 
            this.select3_btn.Location = new System.Drawing.Point(208, 89);
            this.select3_btn.Name = "select3_btn";
            this.select3_btn.Size = new System.Drawing.Size(190, 65);
            this.select3_btn.TabIndex = 4;
            this.select3_btn.Text = "Select Player";
            this.select3_btn.UseVisualStyleBackColor = true;
            this.select3_btn.Click += new System.EventHandler(this.select3_btn_Click);
            // 
            // select4_btn
            // 
            this.select4_btn.Location = new System.Drawing.Point(208, 160);
            this.select4_btn.Name = "select4_btn";
            this.select4_btn.Size = new System.Drawing.Size(190, 65);
            this.select4_btn.TabIndex = 5;
            this.select4_btn.Text = "Select Player";
            this.select4_btn.UseVisualStyleBackColor = true;
            this.select4_btn.Click += new System.EventHandler(this.select4_btn_Click);
            // 
            // select5_btn
            // 
            this.select5_btn.Location = new System.Drawing.Point(118, 231);
            this.select5_btn.Name = "select5_btn";
            this.select5_btn.Size = new System.Drawing.Size(190, 65);
            this.select5_btn.TabIndex = 6;
            this.select5_btn.Text = "Select Player";
            this.select5_btn.UseVisualStyleBackColor = true;
            this.select5_btn.Click += new System.EventHandler(this.select5_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(323, 307);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "Next";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(176, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listBox1.Location = new System.Drawing.Point(208, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(95, 69);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.select5_btn);
            this.Controls.Add(this.select4_btn);
            this.Controls.Add(this.select3_btn);
            this.Controls.Add(this.select2_btn);
            this.Controls.Add(this.countPl_lb);
            this.Controls.Add(this.select_btn);
            this.Name = "Form3";
            this.Text = "Schießzettel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.VisibleChanged += new System.EventHandler(this.Form3_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Label countPl_lb;
        private System.Windows.Forms.Button select2_btn;
        private System.Windows.Forms.Button select3_btn;
        private System.Windows.Forms.Button select4_btn;
        private System.Windows.Forms.Button select5_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}