using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.model
{
    public class Address
    {
        public int add_id { get; set; }
        public int foreign_key { get; set; }
        public string village { get; set; }
        public string commune { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string road { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
