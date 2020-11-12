namespace Unity_Csharp___Completo.ExemploHierarquia.Entities
{

    class EmployeeCast
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public EmployeeCast()
        {
        }

        public EmployeeCast(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }

}