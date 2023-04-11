using AutoMapper.Configuration.Conventions;

namespace BossAzAPI.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Phone> Telephones { get; set; }
        public int CategoryId { get; set; }
        public virtual EnumValue Category { get; set; }
        public string Position { get; set; }
        public int CityId { get; set; }
        public virtual EnumValue City { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int EducationId { get; set; }
        public virtual EnumValue Education { get; set; }
        public int ExperienceId { get; set; }
        public virtual EnumValue Experience { get; set; }
        public string Requirements { get; set; }
        public string JobInfo { get; set; }
        public string CompanyName { get; set; }
        public string RelevantPerson { get; set; }
    }
}
