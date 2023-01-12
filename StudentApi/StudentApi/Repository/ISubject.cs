using StudentApi.Models;

namespace StudentApi.Repository
{
    public interface ISubject
    {
        bool SaveChanges();
        IEnumerable<Subject> GetSubjects();
        Subject GetSubjectById(int id);
        void CreateSubject(Subject subject);    
        void UpdateSubject(Subject subject);    
        void DeleteSubject(Subject subject);

    }
}
