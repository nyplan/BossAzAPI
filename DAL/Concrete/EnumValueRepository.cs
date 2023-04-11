using BossAzAPI.DAL.Abstract;
using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Concrete
{
    public class EnumValueRepository : IEnumValueRepository
    {
        private readonly MyContext _context;

        public EnumValueRepository(MyContext context)
        {
            _context = context;
        }
        public List<EnumValue> Get(int id)
        {
            return _context.EnumValues.Where(value => value.KeyId== id).ToList();
        }
    }
}
