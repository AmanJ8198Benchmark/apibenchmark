using StudentApi.Models;

namespace StudentApi.Repository
{
    public interface IMark
    {
        bool SaveChanges();
        IEnumerable<Mark> GetMarks();
        Mark GetMarkById(int id);
        void CreateMark(Mark mark);
        void UpdateMark(Mark mark);
        void DeleteMark(Mark mark);
    }
}
