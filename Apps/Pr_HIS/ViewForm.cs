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
    /// <summary>
    /// 조회 - 환자 데이터를 조회하고 이름으로 실시간 필터링을 제공하는 폼
    /// </summary>
    public partial class ViewForm : Form
    {
        // allPatients 라는 이름의 리스트 그릇 생성
        private List<Patient> allPatients;

        public ViewForm()
        {
            InitializeComponent();

            // 리스트 변수 allPatients 는 PatientService 클래스의 GetAllPatients 메서드 / 데이터를 메모리로 로드
            allPatients = PatientService.GetAllPatients();
            
            // AutoGenerateColumns가 true 이면 Patient 클래스의 속성 이름으로 컬럼이 자동 생성됩니다.
            this.dgvPatients.AutoGenerateColumns = false;

            // TxtSearchName.TextChanged 이벤트에 TxtSearchName_TextChanged 메서드를 연결합니다.
            txtSearchName.TextChanged += TxtSearchName_TextChanged;
        }

        
        private void TxtSearchName_TextChanged(object sender, EventArgs e)
        {
            // 환자 검색 textbox에 입력된 값을 searchText 변수에 할당
            string searchText = txtSearchName.Text.ToLower();

            // 입력된 값이 없으면 
            if (string.IsNullOrWhiteSpace(searchText)) 
            {
                dgvPatients.DataSource = null;
            }
            else
            {
                // LINQ (Language Integrated Query)를 사용하여 allPatients 리스트를 필터링합니다.
                // 이름에 검색어가 포함된 환자들만 추출
                var filteredList = allPatients.Where(p => p.Name.ToLower().Contains(searchText)).ToList();
                // DataGridView에 데이터 담아서 보여주기 
                dgvPatients.DataSource = filteredList;
            }
            // DataGridView의 UI를 강제 갱신하여 즉시 변경 사항을 반영합니다.
            dgvPatients.Refresh();
        }
    }
}
