using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    public class Post : Base
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostCotent { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
    }
}
