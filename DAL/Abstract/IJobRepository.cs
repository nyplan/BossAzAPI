using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Abstract
{
    public interface IJobRepository
    {
        List<Job> Get();
        Job Get(int id);
        void Add(Job job);
        void Update(Job job);
        void Delete(Job job);
    }
}
