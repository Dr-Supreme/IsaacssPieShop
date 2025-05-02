using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaacssPieShop
{

    //blueprint of an object.
    //object is an instance of class
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int NumberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorked = 1;

        public employeeType employeeType;

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, employeeType.StoreManager) { }
        public Employee(string frist, string last, string em, DateTime bd, double rate, employeeType emptype)
        {
            firstName = frist;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = emptype;
        }

        //this is a great example of method overriding. as it is the same function name but with different parameters
        public void PerformWork()
        {

            //NumberOfHoursWorked++;
            PerformWork(minimalHoursWorked);
            //Console.WriteLine($"{firstName} {lastName} has worked {NumberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked {NumberOfHoursWorked} hour(s)!");
        }

        public static void UsingACustomType()
        {
            List<string> list = new List<string>();
            
        
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

    }
}
