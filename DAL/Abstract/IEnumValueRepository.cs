using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Abstract
{
    public interface IEnumValueRepository
    {
        List<EnumValue> Get(int id);
    }
}
