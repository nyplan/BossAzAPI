using BossAzAPI.DTOs.EnumValueDTOs;
using BossAzAPI.DTOs.PhoneDTOs;
using BossAzAPI.Entities;

namespace BossAzAPI.DTOs.ResumeDTOs
{
    public record ResumeByIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EnumValueToListDto Gender { get; set; }
        public string Image { get; set; }
        public EnumValueToListDto Education { get; set; }
        public string MoreEduInfo { get; set; }
        public EnumValueToListDto Experience { get; set; }
        public string MoreExperienceInfo { get; set; }
        public EnumValueToListDto Category { get; set; }
        public string Position { get; set; }
        public EnumValueToListDto City { get; set; }
        public int MinWage { get; set; }
        public string Skills { get; set; }
        public string MoreInfo { get; set; }
        public string Email { get; set; }
        public ICollection<PhoneToListDto> Phones { get; set; }
    }
}
