﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer:IEntity
    {
        [Key]
        public int? WriterId { get; set; }

        [StringLength(20)]
        public string WriterName { get; set; }
         
        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(250)]
        public string WriterAbout { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(200)]
        public string WriterMail { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(200)]
        public string WriterTitle { get; set; }
        public bool WriterStatus { get; set; }

        public  ICollection<Content> Contents { get; set; }
        public  ICollection<Heading> Headings { get; set; }
    }
}
