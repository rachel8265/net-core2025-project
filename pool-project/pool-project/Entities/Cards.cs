namespace pool_project.Entities
{
    public enum cardType { single, group }
    public enum subscribType { year, month, single };
    public class Cards
    {
        public int Id { get; set; }
        public bool Subsidization { get; set; }
        public subscribType SubscribType { get; set; }
        public int Price { get; set; }
        public int Age { get; set; }
        public int Hours { get; set; }
    }
}
