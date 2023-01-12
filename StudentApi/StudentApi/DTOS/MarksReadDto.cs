namespace StudentApi.DTOS
{
    public class MarksReadDto
    {
        public int Id { get; set; }
        public int Marks { get; set; }
        public List<StudentCreateDto> Students { get; set; }
        public List<SubjectCreateDto> Subjects { get; set; }
    }
}
