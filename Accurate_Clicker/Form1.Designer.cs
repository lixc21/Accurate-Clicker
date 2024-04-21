namespace Accurate_mouse_clicker
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 61);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 0;
            label1.Text = "Hour:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 120);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 1;
            label2.Text = "Minute:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 182);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Second:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 240);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 3;
            label4.Text = "Computer - NTP = ";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            textBox1.Text = "12";
            textBox1.Leave += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            textBox2.Text = "0";
            textBox2.Leave += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 4;
            textBox3.Text = "0";
            textBox3.Click += textBox3_TextChanged;
            textBox3.Leave += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(293, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 4;
            textBox4.Text = "0";
            textBox4.Leave += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(54, 363);
            button1.Name = "button1";
            button1.Size = new Size(439, 88);
            button1.TabIndex = 5;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(54, 303);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 6;
            label5.Text = "state: non-active";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 512);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(589, 583);
            MaximizeBox = false;
            MaximumSize = new Size(589, 583);
            Name = "Form1";
            Text = "Accurate Mouse Clicker";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
    }
}