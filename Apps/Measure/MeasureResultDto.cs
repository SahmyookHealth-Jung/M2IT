using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measure
{
    public class MeasureResultDto
    {
        public string AcptNo   { get; set; }
        public string AcptDate { get; set; }
        public string Height { get; set; }   // 신장 (S0001)
        public string Weight { get; set; }   // 체중 (S0002)
        public string Bmi { get; set; }      // 비만도 (S0003)
        public string Waist { get; set; }    // 허리둘레 (S0012)
        public string Chest { get; set; }    // 가슴둘레 (S0014)
        public string Neck { get; set; }     // 목둘레 (S0078)
        
    }
}
