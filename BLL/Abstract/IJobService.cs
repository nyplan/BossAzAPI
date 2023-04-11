using BossAzAPI.DTOs.JobDTOs;

namespace BossAzAPI.BLL.Abstract
{
    public interface IJobService
    {
        List<JobToListDto> Get();
        JobByIdDto Get(int id);
        void Add(JobToAddDto dto);
        void Delete(int id);
        void Update(JobToUpdateDto dto);
    }
}
