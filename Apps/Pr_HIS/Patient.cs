using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_HIS
{
    /// <summary>
    /// 데이터 모델(Model) 
    /// Id - 환자 아이디, Name - 환자명 CheckupDate - 검진 날짜, Status - 상태
    /// Database 와 연결될 때, 각 클래스에서 사용되는 상태를 정의한다.
    /// DB 테이블의 행(Row)와 1:1로 대응되는 객체 역할을 한다.
    /// </summary>
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CheckupDate { get; set; }
        public string Status { get; set; }
    }
}
