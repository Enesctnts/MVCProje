﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingId { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryId { get; set; }//bağlıyacagımız sutunu ekledik
        public virtual Category Category { get; set; }
        public ICollection<Content> Contents { get; set; }

    }
}
