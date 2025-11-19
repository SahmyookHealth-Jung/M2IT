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
        public string RegDate { get; set; }
    }
}
