using BossAzAPI.DAL.Abstract;
using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Concrete
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly MyContext _context;

        public ResumeRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Resume resume)
        {
            _context.Resumes.Add(resume);
            _context.SaveChanges();
        }

        public void Delete(Resume resume)
        {
            _context.Resumes.Remove(resume);
            _context.SaveChanges();
        }

        public List<Resume> Get()
        {
            return _context.Resumes.ToList();
        }

        public Resume Get(int id)
        {
            return _context.Resumes.Find(id);
        }

        public void Update(Resume resume)
        {
            _context.Resumes.Update(resume);
            _context.SaveChanges();
        }
    }
}
