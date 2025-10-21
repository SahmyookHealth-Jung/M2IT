using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_List
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 버튼을 누르면 텍스트 박스에 입력한 값을 task 변수에 저장하고
        /// listBox.Items.Add(task)를 해서 새 항목으로 추가하며
        /// 새로운 Item 객체를 생성하여 레이블에 생성 완료 메세지를 표시한 후
        /// 텍스트 박스의 내용을 지운다.
        /// </summary>
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                listBox.Items.Add(task);
                Item newItem = new Item(task);
                lblOutput.Text = $"{newItem.Name}이(가) 성공적으로 생성되었습니다.";
                txtInput.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0) 
            {
                int selectIndex = listBox.SelectedIndex;

                // 삭제되기 전에 항목 내용을 미리 가져와 변수에 저장!!! 
                string deleteItemText = listBox.Items[selectIndex].ToString();

                listBox.Items.RemoveAt(listBox.SelectedIndex);

                lblOutput.Text = $"{deleteItemText}이(가) 삭제되었습니다.";
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public Item(string name)
        {
            this.Name= name;
        }
    }
}
