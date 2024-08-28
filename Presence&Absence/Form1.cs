using Presence_Absence.Models;
using Presence_Absence.Service;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presence_Absence
{

    public partial class addPerson : Form


    {
        PrecenceService precenceService = new PrecenceService();

        public static addPerson Instance;
        public DataGridView my_DataGridView1;
        public addPerson()
        {
            InitializeComponent();
            Instance = this;
            my_DataGridView1 = dataGridView1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void Save(object sender, EventArgs e)
        {

            precenceService.SaveList(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToBoolean(checkBox1.Checked));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = precenceService.GetList();




        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 EditForm = new Form2();
            EditForm.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 DeleteForm = new Form3();
            DeleteForm.ShowDialog();
        }
    }
}
