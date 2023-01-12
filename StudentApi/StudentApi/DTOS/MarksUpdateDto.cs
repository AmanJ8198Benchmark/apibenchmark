using System.ComponentModel.DataAnnotations;

namespace StudentApi.DTOS
{
    public class MarksUpdateDto
    {
        [Required]
        public int Marks { get; set; }

        public List<StudentCreateDto> Students { get; set; }
        public List<SubjectCreateDto> Subjects { get; set; }
    }
}
