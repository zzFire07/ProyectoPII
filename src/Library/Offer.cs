namespace Library
{
    public class Offer
    {
        public Offer(int offerID, string description, int price, Category category)
        {
            OfferID = offerID;
            Description = description;
            Price = price;
            Category = category;
        }
        private Category Category { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }
        private int OfferID { get; set; }
        private Offer[] OffersList { get; set; }
        public Offer[] GetOffersList()
        {
            //Devolver lista Offer[] de las Ofertas
        }
        public Offer[] Offer(string category, int intIn)
        {
            //Devolver Offer por Int
        }
        public int GetReputation(Offer offer)
        {
            //Devolver valor de reputación de la oferta
        }
    }
}