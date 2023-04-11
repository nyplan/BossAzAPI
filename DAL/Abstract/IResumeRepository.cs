using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Abstract
{
    public interface IResumeRepository
    {
        List<Resume> Get();
        Resume Get(int id);
        void Add(Resume resume);
        void Delete(Resume resume);
        void Update(Resume resume);
    }
}
