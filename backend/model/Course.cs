using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.model
{
    public class Course
    {
        public int cou_id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int credit_hour { get; set; }
        public int dep_id { get; set; }
        public int ins_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
