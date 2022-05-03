using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("ProjectPictures")]
    public class ProjectPictures : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500, ErrorMessage = "Ürün resim yolu en fazla 400 karakter")]
        public string Picture { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
