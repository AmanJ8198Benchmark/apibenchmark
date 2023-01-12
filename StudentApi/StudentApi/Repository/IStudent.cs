using StudentApi.Models;

namespace StudentApi.Repository
{
    public interface IStudent
    {
        bool SaveChanges();
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        void CreateStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
    }
}
