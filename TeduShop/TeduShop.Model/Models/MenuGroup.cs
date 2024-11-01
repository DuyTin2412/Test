using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Tự tăng
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; } //nhiều menu trong 1 group
    }
}
