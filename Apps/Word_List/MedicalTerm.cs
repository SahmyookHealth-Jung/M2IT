using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_List
{
    /// <summary>
    /// DTO : 데이터를 나르는 상자 역할을 하는 클래스
    /// </summary>
    public class MedicalTerm
    {
        public int Id { get; set; }
        public string TermCode { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        
        // DB의 reg_date는 DATETIME 타입이니, DATETIME으로 받는 게 정석.
        // 지금처럼 string으로 받아도 에러는 나지 않음.
        public string RegDate { get; set; }
    }
}
