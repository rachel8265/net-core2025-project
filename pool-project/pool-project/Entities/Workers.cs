namespace pool_project.Entities
{
    public enum paymentOption { cash,check,bankTransfer}
    public class Workers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }
        public string address { get; set; }
        public string JobType { get; set; }
        public int YearsOfSeniority { get; set; }
        public int Salary { get; set; }
        public paymentOption paymentMethod { get; set; }
    }
}
