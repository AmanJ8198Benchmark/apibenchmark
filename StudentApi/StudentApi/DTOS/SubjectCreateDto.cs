using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOS
{
    public class SubjectCreateDto
    {
       
        [Required]
        public string Name { get; set; }
    }
}
