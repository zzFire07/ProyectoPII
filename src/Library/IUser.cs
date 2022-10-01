namespace Library
{
    public interface IUser
    {
        private PersonalData PersonalData { get; set; }
        private Address Address { get; set; }
        private Rubro Rubro { get; set; }
        private int Reputation { get; set; }
        private GenericRegister<Employee> Employees { get; set; }
        private GenericRegister<Employer> Employers { get; set; }

        public void Register(Employee employee);
        public void Register(Employer employer);
        public void Unsuscribe(Employee employee);
        public void Unsuscribe(Employer employer);
    }
