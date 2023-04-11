using BossAzAPI.DTOs.EnumValueDTOs;
using BossAzAPI.DTOs.PhoneDTOs;

namespace BossAzAPI.DTOs.JobDTOs
{
    public record JobToListDto
    {
        public int Id { get; set; }
        public virtual EnumValueToListDto City { get; set; }
        public string CompanyName { get; set; }
        public virtual EnumValueToListDto Category { get; set; }
        public string Position { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
    }
}
