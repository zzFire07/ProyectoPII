namespace ponganElNamespace
{
    public class Offer
    {
        private Category Category { get; set; }
        private string Description { get; set; }
        private int Price { get; set; }
        private int OfferID { get; set; }
        private Offer[] OffersList { get; set; }

        //+ GetOffersList() : Offer[]
        // +Offer(Category, string, int, int) : Offer[]
        // + GetReputation(Reputation : int) : Int
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