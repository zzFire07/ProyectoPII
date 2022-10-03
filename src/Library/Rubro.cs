namespace Library
{
    public class Rubro
    {
        private string NombreRubro { get; set; }
        private int YearExperience { get; set; }
        private string ReferenceName { get; set; }
        private string ReferencePhone { get; set; }

        public Rubro(string nombrederubro, int yearExperience, string referenceName, string referencePhone)
        {
            NombreRubro = nombrederubro;
            YearExperience = yearExperience;
            ReferenceName = referenceName;
            ReferencePhone = referencePhone;
        }
    }
}