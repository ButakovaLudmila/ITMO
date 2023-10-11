using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Final.Models
{
    public class Value
        
    {
        public int ID { get; set; }
        public int StudentId { get; set; }

        public int ThemeId { get; set; }

        [Display(Name = "Оценка")]
        [RegularExpression(@"^[1-5]*$")]
        public int Mark { get; set; }
    }
}
