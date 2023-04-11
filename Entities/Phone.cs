namespace BossAzAPI.Entities
{
    public class Phone
    {
        public int Id { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Resume> Resumes { get; set; }
    }
}
