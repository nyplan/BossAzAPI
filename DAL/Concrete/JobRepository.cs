using BossAzAPI.DAL.Abstract;
using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Concrete
{
    public class JobRepository : IJobRepository
    {
        private readonly MyContext _context;
        public JobRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
        }

        public void Delete(Job job)
        {
            _context.Jobs.Remove(job);
            _context.SaveChanges();
        }

        public List<Job> Get()
        {
            return _context.Jobs.ToList();
        }

        public Job Get(int id)
        {
            return _context.Jobs.Find(id);
        }

        public void Update(Job job)
        {
            _context.Jobs.Update(job);
            _context.SaveChanges();
        }
    }
}
