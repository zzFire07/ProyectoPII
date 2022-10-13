namespace Library
{
    public class GenericRegister<T>
    {
        //private List<T> Registereds { get; set; }
        private static List<T> registereds;
        
        public static List<T> Registereds()
        {
            get
            {
                if (registereds == null)
                {
                    registereds = new List<T>;
                }

                return registereds;
            }
        }
        public void Register(T item)
        {
            registereds.Add(item);
        }
        public void Unsuscribe(T item)
        {
            registereds.Remove(item);
        }
    }
}