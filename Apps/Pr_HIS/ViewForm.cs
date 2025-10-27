using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_HIS
{
    public partial class ViewForm : Form
    {
        private List<Patient> allPatients;

        public ViewForm()
        {
            InitializeComponent();

            allPatients = PatientService.GetAllPatients();
            
            // AutoGenerateColumns가 true 이면 Patient 클래스의 속성 이름으로 컬럼이 자동 생성됩니다.
            this.dgvPatients.AutoGenerateColumns = false;

            txtSearchName.TextChanged += TxtSearchName_TextChanged;
        }

        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchName.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText)) 
            {
                dgvPatients.DataSource = null;
            }
            else
            {
                var filteredList = allPatients.Where(p => p.Name.ToLower().Contains(searchText)).ToList();
                dgvPatients.DataSource = filteredList;
            }
            dgvPatients.Refresh();
        }
    }
}
