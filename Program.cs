using System;
using System.Collections.Generic;

namespace Progams {
    class Program {
        public static void Main (string[] args) {

            Employee EmployeeJANEInfo = new Employee () {
                FirstName = "Jane",
                LastNAme = "Plain",
                Title = "Acountant",
                StartDate = new DateTime (2013, 04, 25)
            };
            Employee EmployeeROBYInfo = new Employee () {
                FirstName = "Roby",
                LastNAme = "Shmow",
                Title = "Sales Manager",
                StartDate = new DateTime (2015, 04, 15)
            };

            Employee EmployeePATTYInfo = new Employee () {
                FirstName = "Paty",
                LastNAme = "Whack",
                Title = "C.E.O",
                StartDate = new DateTime (2008, 06, 15)
            };

            List<Employee> ListEmployeesSmalGoodompany = new List<Employee> {
                EmployeeJANEInfo,
                EmployeeROBYInfo,
                EmployeePATTYInfo
            };
            Company SmalGoodompany = new Company {
                Datefounded = new DateTime (2008, 06, 15),
                CompanyName = "nick nack patty whack's",
                Employees = ListEmployeesSmalGoodompany

            };
            Console.WriteLine ($"{SmalGoodompany.Datefounded}");
            Console.WriteLine ($"{SmalGoodompany.CompanyName}");
            SmalGoodompany.ListEmployees ();
            Console.WriteLine ("----------------------------");

            Employee EmployeeBOBInfo = new Employee () {
                FirstName = "BOB",
                LastNAme = "Normal",
                Title = "Acountant",
                StartDate = new DateTime (2008, 12, 25)
            };

            Employee EmployeeJOEInfo = new Employee () {
                FirstName = "JOE",
                LastNAme = "Shmow",
                Title = "C.E.O",
                StartDate = new DateTime (1995, 04, 25)
            };

            List<Employee> ListEmployeesbigbadcompany = new List<Employee> {
                EmployeeBOBInfo,
                EmployeeJOEInfo
            };

            Company bigbadcompany = new Company {
                Datefounded = new DateTime (1995, 04, 25),
                CompanyName = "Joe Shmow's Grill",
                Employees = ListEmployeesbigbadcompany
            };
            Console.WriteLine ($"{bigbadcompany.Datefounded}");
            Console.WriteLine ($"{bigbadcompany.CompanyName}");
            bigbadcompany.ListEmployees ();
            Console.WriteLine ("----------------------------");

        }

    };
}