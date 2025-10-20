using System;
using System.Collections.Generic;
using System.ComponentModel; // BindingList를 사용하기 위해 필요
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    // 메인 폼 클래스
    public partial class Form1 : Form
    {
        // 'TodoItem' 객체를 저장하는 리스트.
        // **BindingList<T>**는 리스트 내용이 변경될 때(추가/삭제/수정)
        // DataGridView와 같은 바인딩된 컨트롤에 자동으로 알림을 보내 업데이트되도록 합니다.
        private BindingList<TodoItem> taskList = new BindingList<TodoItem>();

        // 폼의 생성자 (폼이 로드될 때 실행되는 초기화 메서드)
        public Form1()
        {
            InitializeComponent(); // 디자이너에서 생성된 컨트롤 초기화

            // DataGridView 설정 및 데이터 바인딩
            // DataGridView에 열(Column)을 수동으로 추가했으므로, 
            // 데이터 소스에 있는 모든 속성에 대해 자동으로 열을 생성하는 것을 막습니다.
            dgvTasks.AutoGenerateColumns = false;

            // **Completed** 속성을 바인딩할 CheckBoxColumn (colCompleted) 설정
            // nameof()는 속성 이름을 문자열로 가져오는 안전한 방법입니다.
            colCompleted.DataPropertyName = nameof(TodoItem.Completed);

            // **TaskDescription** 속성을 바인딩할 TextBoxColumn (colTask) 설정
            colTask.DataPropertyName = nameof(TodoItem.TaskDescription);

            // DataGridView의 데이터 소스를 taskList로 설정합니다.
            dgvTasks.DataSource = taskList;


            // DataGridView 셀의 정렬 설정
            this.colCompleted.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // 체크박스 열은 중앙 정렬
            this.colTask.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;     // 할 일 내용 열은 왼쪽 정렬

            // 초기 할 일 목록 데이터 추가
            taskList.Add(new TodoItem("C# DataGridView 설정 공부하기"));
            taskList.Add(new TodoItem("ToDo List UI 완성하기"));
        }

        // '추가' 버튼 클릭 이벤트 핸들러 (btnAdd)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 입력 텍스트 상자(txtNewTask)의 내용을 가져와 공백을 제거합니다.
            string task = txtNewTask.Text.Trim();

            // 입력 내용이 비어있지 않은지 확인
            if (!string.IsNullOrEmpty(task))
            {
                // 새 TodoItem 객체를 생성하여 taskList에 추가합니다.
                // taskList가 BindingList이므로 DataGridView에 자동으로 새 항목이 표시됩니다.
                taskList.Add(new TodoItem(task));
                txtNewTask.Clear(); // 입력 창 초기화
            }
        }

        // '완료 항목 삭제' 버튼 클릭 이벤트 핸들러 (btnDelete)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 리스트의 끝에서부터(i = taskList.Count - 1) 처음으로(i >= 0) 역순으로 반복합니다.
            // 리스트에서 항목을 삭제할 때는 인덱스가 꼬이는 것을 방지하기 위해 역순 반복이 필수입니다.
            for (int i = taskList.Count - 1; i >= 0; i--)
            {
                TodoItem item = taskList[i];

                // 해당 항목이 완료(Completed == true)되었는지 확인
                if (item.Completed)
                {
                    // taskList에서 해당 항목을 삭제합니다.
                    // BindingList이므로 DataGridView에서도 항목이 사라집니다.
                    taskList.RemoveAt(i);
                }
            }
        }

        // '완료/미완료 토글' 버튼 클릭 이벤트 핸들러 (btnComplete)
        private void btnComplete_Click(object sender, EventArgs e)
        {
            // DataGridView에 행이 존재하는지 확인
            if (dgvTasks.Rows.Count > 0)
            {
                // DataGridView에서 **선택된 모든 행**을 반복합니다.
                foreach (DataGridViewRow row in dgvTasks.SelectedRows)
                {
                    // 선택된 행의 인덱스를 가져옵니다.
                    int selectedIndex = row.Index;

                    // DataGridView의 행 인덱스에 해당하는 taskList의 TodoItem 객체를 가져옵니다.
                    TodoItem item = taskList[selectedIndex];

                    // TodoItem의 'Completed' 속성 값을 반전시킵니다. (true -> false, false -> true)
                    item.Completed = !item.Completed;
                }

                // 데이터 소스의 변경사항을 DataGridView에 즉시 반영하도록 강제로 새로 고칩니다.
                // (BindingList는 자체적인 추가/삭제를 감지하지만, 개별 속성 변경에는 Refresh()가 유용할 수 있습니다.)
                dgvTasks.Refresh();
            }
        }
    }

    // 할 일 목록의 각 항목을 나타내는 클래스
    public class TodoItem
    {
        // CheckBoxColumn에 바인딩될 속성: 할 일의 완료 상태 (기본값: 미완료)
        public bool Completed { get; set; } = false;

        // DataGridViewTextBoxColumn에 바인딩될 속성: 할 일 내용/설명
        public string TaskDescription { get; set; }

        // 생성자: 항목이 생성될 때 할 일 내용을 설정합니다.
        public TodoItem(string description)
        {
            this.TaskDescription = description;
        }
    }
}