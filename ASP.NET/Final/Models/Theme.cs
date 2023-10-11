using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Final.Models
{
    public class Theme
    {
        public int ID { get; set; }

        [Display(Name = "Название предмета")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

    }
}
