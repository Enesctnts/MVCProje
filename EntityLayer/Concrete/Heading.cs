using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingId { get; set; }
        public int CategoryId { get; set; } // Bağlayacağımız sutunu ekledik
        public int WriterId { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
        
    }
}
