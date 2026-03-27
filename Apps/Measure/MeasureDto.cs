using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measure
{
    public class MeasureDto
    {
        
        public string RoomCode { get; set; }
        public string RoomName { get; set; }

        // 실제 DB에서 가져오는 값
        public string AcptNo { get; set; }
        public string RegiFnt { get; set; }
        public string RegiBack {  get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string FixPcustNo { get; set; }
        public string ItemName { get; set; }

        // 서비스에서 계산
        public string Age { get; set; }
        public string FullRegiNum { get; set; }

        // 검사코드, 검사이름
        public string ExamCode { get; set; }
        public string ExamName { get; set; }

    }
}
