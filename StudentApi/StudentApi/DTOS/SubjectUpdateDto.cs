using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOS
{
    public class SubjectUpdateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
