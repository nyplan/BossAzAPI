using BossAzAPI.DTOs.PhoneDTOs;

namespace BossAzAPI.DTOs.JobDTOs
{
    public record JobToUpdateDto
    {
        public string Email { get; set; }
        public virtual ICollection<PhoneToAddDto> Telephones { get; set; }
        public int CategoryId { get; set; }
        public string Position { get; set; }
        public int CityId { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int EducationId { get; set; }
        public int ExperienceId { get; set; }
        public string Requirements { get; set; }
        public string JobInfo { get; set; }
        public string CompanyName { get; set; }
        public string RelevantPerson { get; set; }
    }
}
