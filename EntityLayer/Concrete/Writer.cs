using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterMail { get; set; }
        public string Password { get; set; }
    }
}
