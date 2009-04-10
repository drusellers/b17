namespace b17.domain
{
    using System.Threading;

    public class Employee
    {
        public string NetworkId { get; private set; }
        public string Name { get; set; }

        public static Employee GetCurrent()
        {
            return new Employee() {NetworkId = Thread.CurrentPrincipal.Identity.Name };
        }
    }
}