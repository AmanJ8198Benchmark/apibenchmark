using StudentApi.Models;
using StudentApi.Repository;

namespace StudentApi.Data
{
    public class SqlMarkRepo : IMark
    {
        private readonly StudentContext _studentContext;
        public SqlMarkRepo(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public void CreateMark(Mark mark)
        {
            if(mark == null)
            {
                throw new ArgumentNullException(nameof(mark));
            }
            _studentContext.Marks.Add(mark);
        }

        public void DeleteMark(Mark mark)
        {
            if(mark == null)
            {
                throw new ArgumentNullException(nameof(mark));
            }
            _studentContext.Marks.Remove(mark);
        }

        public Mark GetMarkById(int id)
        {
            return _studentContext.Marks.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Mark> GetMarks()
        {
            return _studentContext.Marks.ToList();
        }

        public bool SaveChanges()
        {
            return (_studentContext.SaveChanges() >= 0);
        }

        public void UpdateMark(Mark mark)
        {
            
        }
    }
}
