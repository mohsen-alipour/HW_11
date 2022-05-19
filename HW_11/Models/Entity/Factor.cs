namespace HW_11.Models.Entity
{
    public class Factor
    {
        public int ID { get; set; }
        public int? SellerID { get; set; }
        public Seller? Sellers { get; set; }

        public int? CustomerID { get; set; }
        public Customer? Customers { get; set; }

        public int? ProducerID { get; set; }
        public Producer? Producers { get; set; }


    }



}
