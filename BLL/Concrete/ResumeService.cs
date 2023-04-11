using AutoMapper;
using BossAzAPI.BLL.Abstract;
using BossAzAPI.DAL.Abstract;
using BossAzAPI.DTOs.ResumeDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.BLL.Concrete
{
    public class ResumeService : IResumeService
    {
        private readonly IMapper _mapper;
        private readonly IResumeRepository _resumeRepository;
        public ResumeService(IMapper mapper, IResumeRepository resumeRepository)
        {
            _mapper = mapper;
            _resumeRepository = resumeRepository;
        }

        public void Add(ResumeToAddDto dto)
        {
            _resumeRepository.Add(_mapper.Map<Resume>(dto));
        }

        public void Delete(int id)
        {
            _resumeRepository.Delete(_resumeRepository.Get(id));
        }

        public List<ResumeToListDto> Get()
        {
            return _mapper.Map<List<ResumeToListDto>>(_resumeRepository.Get());
        }

        public ResumeByIdDto Get(int id)
        {
            return _mapper.Map<ResumeByIdDto>(_resumeRepository.Get(id));
        }

        public void Update(ResumeToUpdateDto dto)
        {
            _resumeRepository.Update(_mapper.Map<Resume>(dto));
        }
    }
}
