using System;
using System.Collections.Generic;
public class Company {
    public DateTime Datefounded { get; set; }
    public string CompanyName { get; set; }
    public List<Employee> Employees { get; set; }

    public void ListEmployees() {
        foreach (Employee employee in Employees) {
            Console.WriteLine ($"{employee.FirstName} {employee.LastNAme} ");
        }
    }
};