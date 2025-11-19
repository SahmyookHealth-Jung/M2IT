using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvGrid.AutoGenerateColumns = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MedicalTerm newTerm = new MedicalTerm();

            string newCode = txtCode.Text.Trim();
            string newName = txtName.Text.Trim();
            string newDesc = txtDesc.Text.Trim();

            Insert(newTerm);

            btnSelect_Click(sender, e); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
