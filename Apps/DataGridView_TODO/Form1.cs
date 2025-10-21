using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_TODO
{
    public partial class Form1 : Form
    {
        private BindingList<Item> todoItems = new BindingList<Item>();

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();           
        }

        private void SetupDataGridView()
        {
            dgvTasks.DataSource = todoItems;
            dgvTasks.AutoGenerateColumns = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtNewTask.Text.Trim();

            if (string.IsNullOrEmpty(task)) { return; }

            Item newItem = new Item(task);
            todoItems.Add(newItem);
            txtNewTask.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0) 
            {
                DataGridViewRow selectedRow = dgvTasks.SelectedRows[0];
                
                // DataBounItem을 사용하여 연결된 Item 객체를 추출합니다.
                Item selectedItem = selectedRow.DataBoundItem as Item;

                if (selectedItem != null)
                {
                    todoItems.Remove(selectedItem);
                }
            }
        }
    }
    public class Item
    {
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public Item(string name)
        {            
            this.TaskName = name;
            this.IsCompleted = false;
        }
    }
}
