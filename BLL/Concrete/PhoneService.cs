using AutoMapper;
using BossAzAPI.BLL.Abstract;
using BossAzAPI.DAL.Abstract;
using BossAzAPI.DTOs.PhoneDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.BLL.Concrete
{
    public class PhoneService : IPhoneService
    {
        private readonly IMapper _mapper;
        private readonly IPhoneRepository _repository;
        public PhoneService(IMapper mapper, IPhoneRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public void Add(PhoneToAddDto dto)
        {
            _repository.Add(_mapper.Map<Phone>(dto));
        }
    }
}
