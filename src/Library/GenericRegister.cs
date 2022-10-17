namespace Library
{
    public class GenericRegister<T>
    {
        private List<T> Registereds { get; set; }
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