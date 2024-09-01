using Presence_Absence.Models;
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

namespace Presence_Absence
{
    public partial class Form4 : Form
    {
        public static Form4 Instance;
        public DataGridView my_DataGridView2;
        PrecenceService precenceService = new PrecenceService();
        public Form4()
        {
            InitializeComponent();
            Instance = this;
            my_DataGridView2 = dataGridView1;


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
