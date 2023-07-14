using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        //[StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string CategoryDescription { get; set; }
        
        //status bool oldugu için ekstra bir kısıtlamaya gerek yoktur.
        public bool CategoryStatus { get; set; }
        //Kategori silmek yerine durum true veya
        //false işlemi kullanılacak bunu o yüzden oluşturduk

        public ICollection<Heading> Headings { get; set;}
    }
}
