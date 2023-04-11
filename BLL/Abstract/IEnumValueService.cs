using BossAzAPI.DTOs.EnumValueDTOs;

namespace BossAzAPI.BLL.Abstract
{
    public interface IEnumValueService
    {
        List<EnumValueToListDto> Get(int id);
    }
}
