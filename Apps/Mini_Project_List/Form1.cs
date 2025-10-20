using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_List
{
    public partial class Form1 : Form
    {
        private bool isButtonClicked = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string newItemText = txt.Text.Trim(); // trim은 앞뒤 공백 제거

            if (!string.IsNullOrEmpty(newItemText))
            {
                // ListBox의 Item 컬렉션에 새 항목을 추가
                ListBox.Items.Add(newItemText);

                // 추가 후 TextBox 내용을 지워주는 것이 좋음
                txt.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 삭제할 항목이 선택되었는지 확인 
            if (ListBox.SelectedItems.Count > 0)
            {
                // 선택된 항목 컬랙션에서 첫 번째 항목을 가져와 제거
                ListBox.Items.Remove(ListBox.SelectedItems[0]);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Item newItem = new Item("새 항목");
            lblStatus.Text = $"{newItem.Name}이(가) 성공적으로 생성되었습니다.";
        }


    }
    public class Item
    {
        public string Name { get; set; }
        public Item(string name)
        {
            this.Name = name;
        }
    }
}