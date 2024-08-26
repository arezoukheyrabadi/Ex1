using Presence_Absence.Service;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presence_Absence
{

    public partial class addPerson : Form


    {
        PrecenceService precenceService = new PrecenceService();
        public addPerson()
        {
            InitializeComponent();
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

            var tempList1 = precenceService.GetList();

            foreach (var item in tempList1)
            {

                comboBox1.Items.Add(item.Id);
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            precenceService.EditList(comboBox1.SelectedIndex, dateTimePicker3.Value, dateTimePicker4.Value, Convert.ToBoolean(checkBox2.Checked));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = precenceService.GetList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
