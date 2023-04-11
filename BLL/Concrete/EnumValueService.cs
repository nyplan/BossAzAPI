using AutoMapper;
using BossAzAPI.BLL.Abstract;
using BossAzAPI.DAL.Abstract;
using BossAzAPI.DTOs.EnumValueDTOs;

namespace BossAzAPI.BLL.Concrete
{
    public class EnumValueService : IEnumValueService
    {
        private readonly IMapper _mapper;
        private readonly IEnumValueRepository _repository;
        public EnumValueService(IMapper mapper, IEnumValueRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public List<EnumValueToListDto> Get(int id)
        {
            return _mapper.Map<List<EnumValueToListDto>>(_repository.Get(id));
        }
    }
}
