using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardProject
{
    public class BoardPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PostDate { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
