using StudentApi.Models;
using StudentApi.Repository;

namespace StudentApi.Data

{
    public class SqlStudentRepo : IStudent
    {
        private readonly StudentContext _studentContext;
        public SqlStudentRepo(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public void CreateStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _studentContext.Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            if(student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _studentContext.Students.Remove(student);
         
        }

        public Student GetStudentById(int id)
        {
            return _studentContext.Students.FirstOrDefault(p=> p.StudentId == id);
        }

        public IEnumerable<Student> GetStudents()
        {
          return  _studentContext.Students.ToList();
        }

        public bool SaveChanges()
        {
            return (_studentContext.SaveChanges() >= 0);
        }

        public void UpdateStudent(Student student)
        {
          
        }
    }
}
