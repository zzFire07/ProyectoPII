namespace Library
{
    public class GenericRegister<T>
    {
        private List<T> Register { get; set; }
        public GenericRegister()
        {
            Register = new List<T>();
        }
        public void Register(T item)
        {
            Register.Add(item);
        }
        public void Unsuscribe(T item)
        {
            Register.Remove(item);
        }
    }
}