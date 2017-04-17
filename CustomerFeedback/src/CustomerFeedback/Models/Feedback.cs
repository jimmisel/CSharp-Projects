using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedback.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
