﻿namespace Presence_Absence
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
            checkBox2 = new CheckBox();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(101, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(41, 19);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "AB";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(101, 70);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(178, 23);
            dateTimePicker4.TabIndex = 25;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(101, 41);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(178, 23);
            dateTimePicker3.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(204, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-2, 159);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 31;
            label5.Text = "Absence  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 99);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 42;
            label1.Text = "Absence :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 76);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 41;
            label6.Text = "Departure Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 47);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 40;
            label4.Text = "Arrival Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 15);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 39;
            label3.Text = "Id :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 142);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private Button button2;
        private Label label5;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label3;
    }
}