namespace Presence_Absence
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
            checkBox2 = new CheckBox();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(99, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(41, 19);
            checkBox2.TabIndex = 31;
            checkBox2.Text = "AB";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(99, 70);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(178, 23);
            dateTimePicker4.TabIndex = 30;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(99, 41);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(178, 23);
            dateTimePicker3.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(202, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 27;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 76);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 37;
            label6.Text = "Departure Date :";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-4, 159);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 36;
            label5.Text = "Absence  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 47);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 35;
            label4.Text = "Arrival Date :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 15);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 34;
            label3.Text = "Id :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 38;
            label1.Text = "Absence :";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 141);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}