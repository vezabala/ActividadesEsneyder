namespace Actividad7.Models
{
    public class Employee :Entity
    {
        public string Identification { get; private set; }

        public string Name { get; private set; }

        public DateTime FechaDeIngreso { get; private set; }

        public Guid EnterpriseId { get; private set; }

        public Enterprise Enterprise { get; private set; }

        /// <summary>
        /// for
        /// </summary>
        public Employee() :base()
        {

        }

        public Employee(Guid id, string identification, string name, DateTime fechaDeIngreso,
            Guid enterpriseId) : base(id)
        {
            Identification = identification;
            Name = name;
            FechaDeIngreso = fechaDeIngreso;
            EnterpriseId = enterpriseId;
        }

        public Employee Build(Guid id, string identification, string name, 
            DateTime fechaDeIngreso, Guid enterpriseId)
        {
            return new Employee(id, identification, name, fechaDeIngreso, enterpriseId);
        }
    }
}
