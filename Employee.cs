using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First //used to organize code and prevent the naming conflicts.
{
    /* When a class is marked as "internal," it means that the 
     * class is only accessible within the same assembly. In other words, 
     * any code residing in the same assembly can access and use the internal class,
     * but code in other assemblies cannot.
     */
    public class Employee //class always start uppercase
    {   //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double HoursWorked { get; set; }
        public double PayRate { get; set; }

        public double ComputePay()
        {
            // Implement the logic to calculate the pay based on hours worked and pay rate
            // For example:
            return PayRate = HoursWorked * PayRate;
           
        }
    }

}

