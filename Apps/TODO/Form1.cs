using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Item 객체를 저장할 List<Item>을 정의
        /// </summary>
        private List<Item> todoList = new List<Item>();
        public Form1()
        {
            InitializeComponent();
            UpdateTaskListUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtNewTask.Text.Trim();

            if (string.IsNullOrEmpty(task)) return;
            // 객체 생성
            Item newItem = new Item(task);
            // List<Item>에 객체 저장
            todoList.Add(newItem);

            txtNewTask.Clear();
            UpdateTaskListUI();
            
        }
        /// <summary>
        /// 데이터는 List<Item> 변수에 저장이 되어 있기 때문에 초기화를 해도 문제 발생 X
        /// </summary>
        private void UpdateTaskListUI()
        { 
            lstTasks.Items.Clear();
            foreach (Item item in todoList)
            {
                lstTasks.Items.Add(item);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인
            int selectedIndex = lstTasks.SelectedIndex;

            if (selectedIndex != -1) 
            {   
                // todoList에서 해당 인덱스의 Item 객체를 제거
                todoList.RemoveAt(selectedIndex);
                UpdateTaskListUI(); 
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public Item(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// ListBox가 이 메서드를 호출하여 화면에 표시할 문자열을 가져옵니다.
        /// 우리는 Name 속성을 표시하고 싶으므로 Name을 반환하도록 재정의합니다.
        /// </summary>     
        public override string ToString()
        {
            return this.Name;
        }
    }
}
