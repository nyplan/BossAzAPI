using BossAzAPI.DTOs.EnumValueDTOs;
using BossAzAPI.DTOs.PhoneDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.DTOs.JobDTOs
{
    public record JobByIdDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public virtual ICollection<PhoneToListDto> Telephones { get; set; }
        public virtual EnumValueToListDto Category { get; set; }
        public string Position { get; set; }
        public virtual EnumValueToListDto City { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public virtual EnumValueToListDto Education { get; set; }
        public virtual EnumValueToListDto Experience { get; set; }
        public string Requirements { get; set; }
        public string JobInfo { get; set; }
        public string CompanyName { get; set; }
        public string RelevantPerson { get; set; }
    }
}
