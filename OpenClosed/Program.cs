using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    //public class Employee
    //{
    //    Employee() { }
    //    public Employee(int id, string name, string type)
    //    {
    //        this.ID = id;
    //        this.Name = name;
    //        this.EmployeeType = type;
    //    }

    //    public int ID { get; set; }
    //    public string EmployeeType { get; set; }
    //    public string Name { get; set; }

    //    public decimal CalculateBonus(decimal salary)
    //    {
    //        if (this.EmployeeType == "Permanent")
    //            return salary * .1M;
    //        else
    //            return salary * .05M;
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Employee empJohn = new Employee(1, "John", "Permanent");
            //Employee empJason = new Employee(2, "Jason", "Temp");

            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                empJohn.ToString(),
                empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
             empJason.ToString(),
             empJason.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}
