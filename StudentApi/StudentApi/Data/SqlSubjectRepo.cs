using StudentApi.Models;
using StudentApi.Repository;

namespace StudentApi.Data
{
    public class SqlSubjectRepo : ISubject
    {
        private readonly StudentContext _studentContext;
        public SqlSubjectRepo(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public void CreateSubject(Subject subject)
        {
           if(subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }
           _studentContext.Subjects.Add(subject);

        }

        public void DeleteSubject(Subject subject)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }
            _studentContext.Subjects.Remove(subject);  
        }

        public Subject GetSubjectById(int id)
        {
            return _studentContext.Subjects.FirstOrDefault(p=>p.SubjectId == id);
        }

        public IEnumerable<Subject> GetSubjects()
        {
            return _studentContext.Subjects.ToList();
        }

        public bool SaveChanges()
        {
            return (_studentContext.SaveChanges() >= 0);
        }

        public void UpdateSubject(Subject subject)
        {
            
        }
    }
}
