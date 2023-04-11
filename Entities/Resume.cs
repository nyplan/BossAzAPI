namespace BossAzAPI.Entities
{
    public class Resume
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GenderId { get; set; }
        public EnumValue Gender { get; set; }
        public string Image { get; set; }
        public int EducationId { get; set; }
        public EnumValue Education { get; set; }
        public string MoreEduInfo { get; set; }
        public int ExperienceId { get; set; }
        public EnumValue Experience { get; set; }
        public string MoreExperienceInfo { get; set; }
        public int CategoryId { get; set; }
        public EnumValue Category { get; set; }
        public string Position { get; set; }
        public int CityId { get; set; }
        public EnumValue City { get; set; }
        public int MinWage { get; set; }
        public string Skills { get; set; }
        public string MoreInfo { get; set; }
        public string Email { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
