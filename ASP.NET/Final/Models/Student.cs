using System;
using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Имя")]
        [RegularExpression(@"^[А-Я]+[а-я]*$")]
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [RegularExpression(@"^[А-Я]+[а-я]*$")]
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Группа")]
        [RegularExpression(@"^[0-9]*$")]
        [StringLength(4)]
        [Required]
        public string Group { get; set; }

    }
}

