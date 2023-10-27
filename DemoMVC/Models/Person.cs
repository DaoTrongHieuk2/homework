using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
{
    [Table("Persons")]
    public class Person
    {

        public string? PersonId { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }

}
//Đào Trọng Hiếu 2021050258