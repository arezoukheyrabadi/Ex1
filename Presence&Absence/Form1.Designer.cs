namespace Presence_Absence
{
    partial class addPerson
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(76, 25);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(178, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(76, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(179, 201);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 86);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 27);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 10;
            label3.Text = "Id :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 118);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 11;
            label4.Text = "Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 171);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 12;
            label5.Text = "Absence  :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(76, 141);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(178, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 147);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 14;
            label6.Text = "Date :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(389, 281);
            dataGridView1.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(82, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(41, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "AB";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(185, 388);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(82, 315);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(178, 23);
            dateTimePicker3.TabIndex = 19;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(82, 344);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(178, 23);
            dateTimePicker4.TabIndex = 20;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(82, 373);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(41, 19);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "AB";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // addPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 492);
            Controls.Add(checkBox2);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "addPerson";
            Text = "Add Person";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
        private Button button2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private CheckBox checkBox2;
    }
}
