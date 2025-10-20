using System;
using System.ComponentModel;
using System.Windows.Forms;
// (생략된 using 구문)

namespace To_Do_List_1
{
    // Form1 클래스는 Windows Forms의 '창' 역할을 상속받습니다.
    public partial class Form1 : Form
    {
        // 🧱 기둥 2: 데이터 컨테이너 (할 일 항목들을 실제로 저장할 '창고'입니다)
        // BindingList는 일반 List와 달리, DataGridView에 데이터 변경을 자동으로 알려줍니다.
        BindingList<TodoItem> todoItems = new BindingList<TodoItem>();

        public Form1()
        {
            // 초기화: 디자이너 파일(Form1.Designer.cs)에 정의된 모든 UI 요소(버튼, DataGridView 등)를 메모리에 로드합니다.
            InitializeComponent();

            // DataGridView 설정
            // 💡 DataGridView의 자동 컬럼 생성을 막고, 우리가 정의한 컬럼만 사용하도록 설정합니다.
            dgvTask.AutoGenerateColumns = false;

            // 💡 데이터 바인딩: DataGridView의 컬럼을 TodoItem 클래스의 속성과 연결합니다.
            // DataPropertyName은 바인딩할 TodoItem 클래스의 속성 이름과 일치해야 합니다.
            colComplete.DataPropertyName = nameof(TodoItem.Completed);     // '완료' 체크박스 컬럼을 TodoItem.Completed (bool) 속성과 연결
            colTasks.DataPropertyName = nameof(TodoItem.TaskDescription); // '할 일' 텍스트 컬럼을 TodoItem.TaskDescription (string) 속성과 연결

            // DataGridView의 데이터 소스를 우리가 만든 리스트(todoItems)로 설정하여 연결합니다.
            dgvTask.DataSource = todoItems;
        }

        // 🧱 기둥 3: 기능 로직 - 항목 추가 버튼 클릭 시 실행
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. TextBox(txtTask)에서 사용자가 입력한 내용을 가져오고, 앞뒤 공백을 제거합니다.
            string task = txtTask.Text.Trim();

            // 2. 텍스트가 비어있지 않은지 확인합니다. (유효성 검사)
            if (!string.IsNullOrEmpty(task))
            {
                // 3. 입력된 텍스트를 사용하여 새로운 TodoItem 객체를 생성합니다. (TodoItem 생성자 호출)
                TodoItem newItem = new TodoItem(task); // 1. 새로운 객체를 생성하고, newItem에 주소를 저장

                // 4. 리스트(todoItems)에 새 객체를 추가합니다. 
                //    BindingList 덕분에 DataGridView에 즉시 새 행이 나타납니다.
                todoItems.Add(newItem);

                // 5. 다음 입력을 위해 TextBox의 내용을 지웁니다.
                txtTask.Clear();
            }
        }

        // 🧱 기둥 3: 기능 로직 - 완료된 항목 삭제 버튼 클릭 시 실행 (청소 기능)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. ✨ 핵심: 리스트를 끝에서부터 처음으로 (역순으로) 반복 처리합니다.
            //    항목을 삭제할 때마다 인덱스가 꼬이는 문제를 방지하기 위함입니다.
            for (int i = todoItems.Count - 1; i >= 0; i--)
            {
                // 2. 현재 인덱스(i)에 해당하는 TodoItem 객체를 가져옵니다.
                TodoItem item = todoItems[i];

                // 3. 현재 항목의 Completed 속성(체크박스 상태)이 true인지 확인합니다.
                if (item.Completed)
                {
                    // 4. 완료된 항목을 리스트에서 제거합니다. 
                    //    BindingList가 DataGridView에서 해당 행을 자동으로 지웁니다.
                    todoItems.RemoveAt(i);
                }
            }
        }

        // 🧱 기둥 1: 데이터 모델 (할 일 항목의 청사진)
        // Form1 클래스 안에 정의된 중첩 클래스입니다.
        public class TodoItem
        {
            // 💡 속성: 할 일의 완료 상태를 저장 (DataGridView의 체크박스 컬럼과 바인딩됨)
            public bool Completed { get; set; } = false; // 새 항목은 기본적으로 false로 시작

            // 💡 속성: 할 일의 내용을 저장 (DataGridView의 텍스트 컬럼과 바인딩됨)
            public string TaskDescription { get; set; }

            // 💡 생성자: 새 객체가 만들어질 때 호출되며, 필수값인 'description'을 받아 속성을 초기화합니다.
            public TodoItem(string description)
            {
                this.TaskDescription = description;
            }
        }
    }
}