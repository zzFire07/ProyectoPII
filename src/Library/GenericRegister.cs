namespace Library
{
    public class GenericRegister<T>
    {
        private List<T> Registereds { get; set; }
        public GenericRegister()
        {
            List<T> Registereds = new List<T>();
        }
        public void Register(T item)
        {
            Registereds.Add(item);
        }
        public void Unsuscribe(T item)
        {
            Registereds.Remove(item);
        }
    }
}