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
            DataGridViewButtonCell b = new DataGridViewButtonCell();
            b.Value = "name";
            

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var list = (List<Person>)dataGridView1.DataSource;
            var item = list[e.RowIndex];

            Form4 EditForm = new Form4();

            var temp = precenceService.Select(item.Id);
            precenceService.selectList(temp);

            Form4.Instance.my_DataGridView2.DataSource = null;
            Form4.Instance.my_DataGridView2.DataSource = precenceService.getList();
            
            
            EditForm.ShowDialog();
           

        }

        private void addPerson_Load(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.Id = 0;
            p1.Name = "Arezou";
            p1.LastName = "Kheyrabadi";
            p1.Arrival = DateTime.Now;
            p1.Departure = DateTime.Now;
            p1.Absence = false;
            precenceService.saveList(p1);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = precenceService.GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 SelectForm = new Form4();

        }
    }
}
