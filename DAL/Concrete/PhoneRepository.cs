using BossAzAPI.DAL.Abstract;
using BossAzAPI.Entities;

namespace BossAzAPI.DAL.Concrete
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly MyContext _context;
        public PhoneRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Phone phone)
        {
            _context.Add(phone);
        }
    }
}
