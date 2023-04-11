using BossAzAPI.DTOs.ResumeDTOs;

namespace BossAzAPI.BLL.Abstract
{
    public interface IResumeService
    {
        void Add(ResumeToAddDto dto);
        void Delete(int id);
        void Update(ResumeToUpdateDto dto);
        List<ResumeToListDto> Get();
        ResumeByIdDto Get(int id);
    }
}
