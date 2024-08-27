using Presence_Absence.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presence_Absence
{
    public partial class Form2 : Form
    {
        PrecenceService precenceService = new PrecenceService();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var tempList1 = precenceService.GetList();

            foreach (var item in tempList1)
            {
                comboBox1.Items.Add(item.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            precenceService.EditList(comboBox1.SelectedIndex, dateTimePicker3.Value, dateTimePicker4.Value, Convert.ToBoolean(checkBox2.Checked));
            addPerson.Instance.my_DataGridView1.DataSource = null;
            addPerson.Instance.my_DataGridView1.DataSource = precenceService.GetList();
        }
    }
}
