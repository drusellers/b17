namespace b17.domain
{
    using System.Threading;

    public class Employee
    {
        public string Name { get; private set; }

        public static Employee GetCurrent()
        {
            return new Employee() {Name = Thread.CurrentPrincipal.Identity.Name };
        }
    }
}