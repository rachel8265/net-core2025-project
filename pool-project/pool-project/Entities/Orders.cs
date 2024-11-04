

namespace pool_project
{
    public class Orders
    {
        public int Id { get; set; }
        public int IdSubscriber { get; set; }
        public int IdCard { get; set; }
        public string PaymentType { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfCards { get; set; }
        public int TotalPrice { get; set; }//......אולי לשנות שם
        //7 דברים
    }
}
