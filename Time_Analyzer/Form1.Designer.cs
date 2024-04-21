namespace click_time_recorder
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(342, 385);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 1;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "ntp.tuna.tsinghua.edu.cn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 62);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 2;
            label1.Text = "NTP Server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 192);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 3;
            label2.Text = "Computer Time (rec): ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 192);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 3;
            label3.Text = "nan";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 253);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 3;
            label4.Text = "NTP Time (rec): ";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(388, 253);
            label5.Name = "label5";
            label5.Size = new Size(54, 32);
            label5.TabIndex = 3;
            label5.Text = "nan";
            label5.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 310);
            label6.Name = "label6";
            label6.Size = new Size(309, 32);
            label6.TabIndex = 4;
            label6.Text = "Computer - NTP (second) =";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Location = new Point(388, 303);
            label7.Name = "label7";
            label7.Size = new Size(354, 39);
            label7.TabIndex = 6;
            label7.Text = "nan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 134);
            label8.Name = "label8";
            label8.Size = new Size(260, 32);
            label8.TabIndex = 3;
            label8.Text = "Computer Time (click): ";
            label8.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 134);
            label9.Name = "label9";
            label9.Size = new Size(54, 32);
            label9.TabIndex = 3;
            label9.Text = "nan";
            label9.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Time Analyzer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox label7;
        private Label label8;
        private Label label9;
    }
}