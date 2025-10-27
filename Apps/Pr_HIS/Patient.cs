using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_HIS
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CheckupDate { get; set; }
        public string Status { get; set; }
    }
}
