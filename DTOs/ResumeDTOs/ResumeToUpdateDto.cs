using BossAzAPI.DTOs.PhoneDTOs;

namespace BossAzAPI.DTOs.ResumeDTOs
{
    public record ResumeToUpdateDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GenderId { get; set; }
        public string Image { get; set; }
        public int EducationId { get; set; }
        public string MoreEduInfo { get; set; }
        public int ExperienceId { get; set; }
        public string MoreExperienceInfo { get; set; }
        public int CategoryId { get; set; }
        public string Position { get; set; }
        public int CityId { get; set; }
        public int MinWage { get; set; }
        public string Skills { get; set; }
        public string MoreInfo { get; set; }
        public string Email { get; set; }
        public ICollection<PhoneToAddDto> Phones { get; set; }
    }
}
