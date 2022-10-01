namespace Library
{
    public class Administrador : IPersonalData
    {
        private Administrador(string Nickname, PersonalData AdminData)
        {
            this.Nickname = Nickname;
            this.AdminData = AdminData;
        }
        private string Nickname { get; set; }
        private PersonalData AdminData { get; set; }

        private void AddCategory(string categoryName)
        {
            /*Cómo administrador, quiero poder indicar categorías sobre
            las cuales se realizarán las ofertas de servicios para que
            de esa forma, pueda clasificarlos.*/
        }
        private void RemoveCategory(string categoryName)
        {
            /*Cómo administrador, quiero poder indicar categorías sobre
            las cuales se realizarán las ofertas de servicios para que
            de esa forma, pueda clasificarlos.*/
        }
        private void CancelOffer(string descripcion, int offerID)
        {
            /*Como administrador, quiero poder dar de baja ofertas de
            servicios, avisando al oferente para que de esa forma, pueda
            evitar ofertas inadecudas.*/
        }
        private Offer[] GerOfferByCategory(Category category)
        {
            /*quiero buscar ofertas de trabajo, opcionalmente filtrando
            por categoría para que de esa forma, pueda contratar un servicio.*/
        }
    }
}