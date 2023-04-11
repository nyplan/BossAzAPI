using BossAzAPI.DTOs.EnumValueDTOs;
using BossAzAPI.DTOs.PhoneDTOs;

namespace BossAzAPI.DTOs.ResumeDTOs
{
    public record ResumeToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public EnumValueToListDto Category { get; set; }
        public string Position { get; set; }
        public EnumValueToListDto City { get; set; }
        public int MinWage { get; set; }
    }
}
