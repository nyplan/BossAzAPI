using AutoMapper;
using BossAzAPI.BLL.Abstract;
using BossAzAPI.DAL.Abstract;
using BossAzAPI.DTOs.JobDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.BLL.Concrete
{
    public class JobService : IJobService
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;
        public JobService(IMapper mapper, IJobRepository jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }

        public void Add(JobToAddDto dto)
        {
            _jobRepository.Add(_mapper.Map<Job>(dto));
        }

        public void Delete(int id)
        {
            Job entity = _jobRepository.Get(id);
            _jobRepository.Delete(entity);
        }

        public List<JobToListDto> Get()
        {
            List<JobToListDto> dtos = _mapper.Map<List<JobToListDto>>(_jobRepository.Get());
            return dtos;
        }

        public JobByIdDto Get(int id)
        {
            return _mapper.Map<JobByIdDto>(_jobRepository.Get(id));
        }

        public void Update(JobToUpdateDto dto)
        {
            _jobRepository.Update(_mapper.Map<Job>(dto));
        }
    }
}
