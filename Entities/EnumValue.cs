namespace BossAzAPI.Entities
{
    public class EnumValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int KeyId { get; set; }
        public virtual EnumKey Key { get; set; }
    }
}
