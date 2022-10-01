namespace Library
{
    public class Rubro
    {
        private string Rubro { get; set; }
        private int YearExperience { get; set; }
        private string ReferenceName { get; set; }
        private string ReferencePhone { get; set; }

        public Rubro(string rubro, int yearExperience, string referenceName, string referencePhone)
        {
            Rubro = rubro;
            YearExperience = yearExperience;
            ReferenceName = referenceName;
            ReferencePhone = referencePhone;
        }
    }
}