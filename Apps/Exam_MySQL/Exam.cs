using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_MySQL
{
    public class Exam
    {
        // DTO (Data Transfer Object) 또는 Entity : User 테이블의 레코드를 표현한다.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        
    }
}
