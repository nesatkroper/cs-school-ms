using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.model
{
    public class Instructor
    {
        public int ins_id { get; set; }
        public string photo { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime hire_date { get; set; }
        public int dep_id { get; set; }
        public string status { get; set; }
        public string isDelete { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
