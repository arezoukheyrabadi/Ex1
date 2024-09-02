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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Presence_Absence
{
    public partial class Form3 : Form
    {
        PrecenceService precenceService = new PrecenceService();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var tempList1 = precenceService.GetList();

            foreach (var item in tempList1)
            {
                comboBox1.Items.Add(item.Id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Are You Sure ? ", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                precenceService.DeleteList(Convert.ToInt32(comboBox1.SelectedItem));
                addPerson.Instance.my_DataGridView1.DataSource = null;
                addPerson.Instance.my_DataGridView1.DataSource = precenceService.GetList();
               
            }
                
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
