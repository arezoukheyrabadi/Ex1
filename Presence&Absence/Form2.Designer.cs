namespace Presence_Absence
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
            SuspendLayout();
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(63, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(41, 19);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "AB";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(63, 70);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(178, 23);
            dateTimePicker4.TabIndex = 25;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(63, 41);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(178, 23);
            dateTimePicker3.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(166, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 143);
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
    }
}