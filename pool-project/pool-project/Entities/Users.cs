namespace pool_project.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int Address { get; set; }
        public string Tz { get; set; }
        public string Phon { get; set; }
        public DateOnly Birhtday { get; set; }
        public int age { get; set; }
    }
}
