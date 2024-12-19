namespace KooliProjekt.Data
{
    public class customerName
    {
        public int Id { get; set; }
        public invoiceNumber Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Code { get; set; } // Max length: 15
        public string Description { get; set; } // Max length: 255
        public List<billingAddress> billingAddress { get; set; }
    }



}
