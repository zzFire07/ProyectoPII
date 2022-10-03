namespace Library
{
    public interface IUser
    {
        public PersonalData PersonalData { get; set; }
        public Rubro Rubro { get; set; }
        public int Reputation { get; set; }
        public GenericRegister<Employee> Employees { get; set; }
        public GenericRegister<Employer> Employers { get; set; }

        public void Register(Employee employee);
        public void Register(Employer employer);
        public void Unsuscribe(Employee employee);
        public void Unsuscribe(Employer employer);
    }
