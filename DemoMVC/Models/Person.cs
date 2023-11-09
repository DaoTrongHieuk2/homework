using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    [Table("Person")]
    public class Person
    {
        //2021050258-Dao Trong Hieu//
        [Key]

        public string? PersonId { get; set; }
        [Required(ErrorMessage = "FullName không được để trống.")]
        public string? FullName { get; set; }
        [Required(ErrorMessage = "Address không được để trống.")]
        public string? Address { get; set; }
        public int Age { get; set; }
    }

}
//Đào Trọng Hiếu 2021050258