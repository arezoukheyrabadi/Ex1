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
            var tempList1 = precenceService.GetList();

            foreach (var item in tempList1)
            {

                comboBox1.Items.Add(item.Id);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            precenceService.EditList(comboBox1.SelectedIndex, dateTimePicker1.Value, dateTimePicker2.Value, checkBox1.Checked);
        }
    }
}
